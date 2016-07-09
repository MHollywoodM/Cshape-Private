using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.HttpService
{
    public class HttpServiceLogic
    {
        public static string Post2(Uri url,string jsonRequestString)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            request.Accept = "application/json";
            byte[] bytes = null;
            if (string.IsNullOrEmpty(jsonRequestString))
            {
                request.ContentLength = 0;
            }
            else
            {
                bytes = Encoding.UTF8.GetBytes(jsonRequestString);
                request.ContentLength = bytes.Length;
            }

            if (bytes!=null&&bytes.Length>0)
            {
                System.IO.Stream postStream = request.GetRequestStream();
                postStream.Write(bytes, 0, bytes.Length);
                postStream.Close();
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());
                string jsonResponseString = reader.ReadToEnd();
                reader.Close();
                response.Close();
                if (response.StatusCode== HttpStatusCode.OK)
                {
                    return jsonResponseString;
                }
                return string.Empty;
            }
            catch (WebException ex)
            {

                throw new WebException(ex.HResult + ex.Status + ex.Message);
            }
        }

        public static TData Post<TPatameter,TData>(Uri url,TPatameter patameter)
        {
            TData result = default(TData);
            string jsonRequestString = Newtonsoft.Json.JsonConvert.SerializeObject(patameter);
            if (!String.IsNullOrEmpty(jsonRequestString))
            {
                string jsonResponseString = Post2(url, jsonRequestString);
                if (!string.IsNullOrEmpty(jsonResponseString))
                {
                    try
                    {
                        result = Newtonsoft.Json.JsonConvert.DeserializeObject<TData>(jsonResponseString);
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
            return result;
        }

    }
}
