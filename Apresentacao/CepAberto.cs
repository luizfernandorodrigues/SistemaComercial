using System;
using System.Net;
using System.Web.Script.Serialization;

namespace Apresentacao
{
    public static class CepAberto
    {
        public static CEPAbertoResponse GetCepInfo(string cep)
        {
            try
            {
                var accessToken = "Token token=555044885812990e5c911ff42931ca98";
                var url = "http://www.cepaberto.com/api/v2/ceps.json?cep={0}";
                var client = new WebClient { Encoding = System.Text.Encoding.UTF8 };
                client.Headers.Add(HttpRequestHeader.Authorization, accessToken);
                var result = client.DownloadString(string.Format(url, cep));
                var jss = new JavaScriptSerializer();
                return jss.Deserialize<CEPAbertoResponse>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
