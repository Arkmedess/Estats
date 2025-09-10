using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace Interface_e_sistema_em_C_
{
    public class GroqService
    {
        private readonly string _apiKey;
        private readonly HttpClient _client;

        public GroqService(String apiKey)
        {
            // 
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
        }

        public async Task<bool> TestarConexaoAsync()
        {
            // Teste da conexão com OK
            var carga = new
            {
                model = "llama3-70b-8192",
                messages = new[] { new
                {
                    role = "user",
                    content = "Responda apenas OK"
                } },
                max_tokens = 5
            };

            var json = JsonSerializer.Serialize(carga);
            var corpo = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var resposta = await _client.PostAsync("https://api.groq.com/openai/v1/chat/completions", corpo);

                return resposta.IsSuccessStatusCode; // True 200-299
            }
            catch
            {
                return false;
            }
            finally
            {

            }
        }

        
    }
}
