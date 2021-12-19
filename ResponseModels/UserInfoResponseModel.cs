using Kumport.Common.Models;
using System.Collections.Generic;

namespace Kumport.Common.ResponseModels
{
    public class UserInfoResponseModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string ReturnMessage { get; set; }
        public bool IsSuccesfull { get; set; }
        public List<PostModel> Posts { get; set; }

    }
}
