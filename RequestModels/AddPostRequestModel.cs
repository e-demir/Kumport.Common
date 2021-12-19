using System;

namespace Kumport.Common.RequestModels
{
    public class  AddPostRequestModel
    {
        public string PostTitle { get; set; }

        public string PostOwner { get; set; }

        public string FileType { get; set; }

        public byte[] Image { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
