namespace Kumport.Common.ResponseModels
{
    public class LoginResponseModel
    {
        public string Username { get; set; }
        public string ReturnMessage { get; set; }
        public string Token { get; set; }
        public bool IsSuccessful { get; set; }
        public string TokenExpire { get; set; }
    }
}
