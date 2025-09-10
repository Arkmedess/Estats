using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Estats.apis
{
    internal class Noticia
    {
        public string Titulo { get; set; }
        public string Link { get; set; }
        public string Data { get; set; }
        public string Descricao { get; set; }
    }

    internal class RssNoticiasService
    {
        private List<Noticia> noticias = new List<Noticia>();
        public List<string> FiltroPalavras { get; set; } = new List<string>();

        public async Task CarregarNoticiasAsync()
        {
            HttpClient client = new HttpClient();
            string urlRSS = "https://news.google.com/rss/search?q=estat%C3%ADstica&hl=pt-BR&gl=BR&ceid=BR:pt-419";
            
            string xmlFeed = await client.GetStringAsync(urlRSS);

            XDocument rssXML = XDocument.Parse(xmlFeed);
            var items = rssXML.Descendants("item");

            noticias.Clear();
            foreach (var item in items)
            {
                string titulo = item.Element("title")
                    ?.Value
                    ?? "";

                string link = item.Element("link")
                    ?.Value
                    ?? "";

                string pubDate = item.Element("pubDate")
                    ?.Value
                    ?? "";

                string description = item.Element("description")
                    ?.Value
                    ?? "";

                noticias.Add(new Noticia
                {
                    Titulo = titulo,
                    Link = link,
                    Data = pubDate,
                    Descricao = description
                });
            }
        }

        public List<Noticia> FiltroNoticias()
        {
            if (FiltroPalavras.Count == 0)
                return noticias;

            var noticiasFiltradas = new List<Noticia>();

            foreach (var noticia in noticias)
            {
                string TituloMinusculo = noticia.Titulo.ToLower();

                foreach (var palavra in FiltroPalavras)
                {
                    string PalavraMinuscula = palavra.ToLower();

                    if (TituloMinusculo.Contains(PalavraMinuscula))
                    {
                        noticiasFiltradas.Add(noticia);
                        break;
                    }
                }
            }
            return noticiasFiltradas;
        }

    }
}
