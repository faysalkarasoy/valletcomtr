using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ValletComTR_Ornek
{
    public class ValletRequest
    {
        const string Api_URL = "https://www.vallet.com.tr/api/v1/create-payment-link";

        private ValletConfig _valletConfig;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valletConfig"></param>
        public ValletRequest(ValletConfig valletConfig)
        {
           _valletConfig = valletConfig;
        }

        private string Hash_generate(string text)
        {
            string source = text;
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(_valletConfig.userName + _valletConfig.password + _valletConfig.shopCode + text + _valletConfig.hash);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                source = Convert.ToBase64String(Encoding.UTF8.GetBytes(hash));
            }
            return source;
        }

        public object Create_payment_link(PostData post_data)
        {
            post_data.userName = _valletConfig.userName;
            post_data.password = _valletConfig.password;
            post_data.shopCode = _valletConfig.shopCode;

            post_data.hash = Hash_generate(post_data.orderId + post_data.currency + post_data.orderPrice + post_data.productsTotalPrice + post_data.productType + post_data.callbackOkUrl + post_data.callbackFailUrl);

            var Response = Send_post(post_data);

            return Response;
        }

        private object Send_post(PostData post_data)
        {

            object Result;
            object StatusCode;

            var string_data = JsonConvert.SerializeObject(post_data);

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(Api_URL);
                request.Accept = "application/json";
                request.ContentType = "application/json";
                request.Method = "POST";

                using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
                {
                    sw.Write(string_data);
                }

                var response = (HttpWebResponse)request.GetResponse();
                StatusCode = response.StatusCode;
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    Result = sr.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                using (WebResponse response = ex.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    StatusCode = httpResponse.StatusCode;

                    using (Stream data = response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(data))
                        {
                            Result = reader.ReadToEnd();
                        }
                    }
                }
            }
            return Result;
        }
    }

}