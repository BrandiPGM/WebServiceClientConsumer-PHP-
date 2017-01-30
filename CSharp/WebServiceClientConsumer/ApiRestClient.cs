using System;
using System.IO;
using System.Net;
using System.Text;
/*
http://www.codeproject.com/Tips/497123/How-to-make-REST-requests-with-Csharp
/*
    Basic call
    ===========
    string endPoint = @"http:\\myRestService.com\api\";
    var client = new RestClient(endPoint);
    var json = client.MakeRequest();

    append parameters
    =================
    var json = client.MakeRequest("?param=0");

    To set the HttpVerb (i.e. GET, POST, PUT, or DELETE)
    ====================================================
    imply use the provided HttpVerb enumeration. Here is an expample of making a POST request:
    
        var client = new RestClient(endpoint: endPoint, 
                     method: HttpVerb.POST, 
                     postData: "{'someValueToPost': 'The Value being Posted'}");

    You can also just assign the values in line if you want:
        var client = new RestClient();
        client.EndPoint = @"http:\\myRestService.com\api\"; ;
        client.Method = HttpVerb.POST;
        client.PostData = "{postData: value}";
        var json = client.MakeRequest();

*/
public enum HttpVerb
{
    GET,
    POST,
    PUT,
    DELETE
}

namespace HttpUtils
{
    public class RestClient
    {
        public string EndPoint { get; set; }
        public HttpVerb Method { get; set; }
        public string ContentType { get; set; }
        public string PostData { get; set; }

        public RestClient()
        {
            EndPoint = "";
            Method = HttpVerb.GET;
            //ContentType = "text/xml";
            ContentType = "application/json;charset=utf-8";
            PostData = "";
        }
        public RestClient(string endpoint)
        {
            EndPoint = endpoint;
            Method = HttpVerb.GET;
            //ContentType = "text/xml";
            ContentType = "application/json;charset=utf-8";
            PostData = "";
        }
        public RestClient(string endpoint, HttpVerb method)
        {
            EndPoint = endpoint;
            Method = method;
            //ContentType = "text/xml";
            ContentType = "application/json;charset=utf-8";
            PostData = "";
        }

        public RestClient(string endpoint, HttpVerb method, string postData)
        {
            EndPoint = endpoint;
            Method = method;
            //ContentType = "text/xml";
            ContentType = "application/json;charset=utf-8";
            PostData = postData;
        }


        public string MakeRequest()
        {
            return MakeRequest("");
        }

        public string MakeRequest(string parameters)
        {
            var request = (HttpWebRequest)WebRequest.Create(EndPoint + parameters);

            request.Method = Method.ToString();
            request.ContentLength = 0;
            request.ContentType = ContentType;

            if (!string.IsNullOrEmpty(PostData) && Method == HttpVerb.POST)
            {
                var encoding = new UTF8Encoding();
                var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(PostData);
                request.ContentLength = bytes.Length;

                using (var writeStream = request.GetRequestStream())
                {
                    writeStream.Write(bytes, 0, bytes.Length);
                }
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var responseValue = string.Empty;

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                // grab the response
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                }

                return responseValue;
            }
        }

    } // class

}