using System;

namespace Kumport.Common.Models
{
    public class PostModel
    {
        public string PostTitle { get; set; }        
        public string FileType { get; set; }
        public string PostOwner { get; set; }        
        public byte[] Image { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
