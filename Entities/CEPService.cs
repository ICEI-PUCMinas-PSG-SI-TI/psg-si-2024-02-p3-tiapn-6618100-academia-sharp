using System.Text.Json;

namespace BodyShape_TI.Entities
{
    public static class CEPService
    {


        #region MÉTODOS
        private static readonly HttpClient httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(10) // Configuração de timeout
        };

        public static async Task<Endereco> BuscarCEPAsync(string cep)
        {
            try
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                HttpResponseMessage httpResponse = await httpClient.GetAsync(url);

                httpResponse.EnsureSuccessStatusCode(); // Lança exceção se o status não for 2xx

                string jsonResponse = await httpResponse.Content.ReadAsStringAsync();
                var dados = JsonSerializer.Deserialize<Endereco>(jsonResponse, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (dados == null || string.IsNullOrEmpty(dados.Cep))
                {
                    throw new Exception("CEP não encontrado.");
                }

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar CEP: " + ex.Message, ex);
            }
        }

        #endregion
    }
}
