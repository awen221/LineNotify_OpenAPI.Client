using RestSharp;

using LineNotify.Interface.Data;
using OpenAPI.Client;
using Newtonsoft.Json;

namespace LineNotify_OpenAPI.Client
{
    public class api : ClientBase
    {
        public Result notify(string api_url, string token, string message)
        {
            var request = new RestRequest("api/notify", Method.Post);
            request.AddQueryParameter("token", token);
            request.AddQueryParameter("message", message);

            return ExecuteJsonConvert(api_url, request);
        }

        Result ExecuteJsonConvert(string api_url, RestRequest request)
        {
            var json = Execute(api_url, request);
            var result = JsonConvert.DeserializeObject<Result>(json);

            return result;
        }
    }
}
