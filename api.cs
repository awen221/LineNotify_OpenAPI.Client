using RestSharp;

namespace LineNotify_OpenAPI.Client
{
    using LineNotify.Interface.Data;
    using LineNotify.Interface.Func;

    public class api : Func
        , Iapi<Result>
    {
        public Result notify(string token, string message)
        {
            RestRequest request = new RestRequest("api/notify", Method.Post);
            request.AddQueryParameter("token", token);
            request.AddQueryParameter("message", message);

            return ExecuteJsonConvert<Result>(request);
        }
    }
}
