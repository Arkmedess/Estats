using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Interface_e_sistema_em_C_
{
    public static class ApiKeyManager
    {
        private static readonly string AppDataCaminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Estats", "chave_api.enc");

        private static readonly byte[] Key = Encoding.UTF8.GetBytes("groq_32byte_key_1234567890123456");
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("groq_iv_12345678");

        public static void SalvarChaveAPI(string chaveAPI)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(AppDataCaminho));

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Key;
                    aes.IV = IV;

                    using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    using (var fs = new FileStream(AppDataCaminho, FileMode.Create))
                    using (var cs = new CryptoStream(fs, encryptor, CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(chaveAPI);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro o salvar a API key: " + ex.Message);
            }
        }

        public static string CarregarChaveAPI()
        {
            try
            {
                if (!File.Exists(AppDataCaminho))
                    return null;

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Key;
                    aes.IV = IV;

                    using (var fs = new FileStream(AppDataCaminho, FileMode.Open))
                    using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                    using (var cs = new CryptoStream(fs, decryptor, CryptoStreamMode.Read))
                    using (var sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch
            {
                return null; // Arquivo corrompido ou inválido
            }
        }

        public static void DeletarChaveAPI()
        {
            if (File.Exists(AppDataCaminho))
                File.Delete(AppDataCaminho);
        }
    }
}
