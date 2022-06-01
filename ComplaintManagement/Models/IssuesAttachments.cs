using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintManagement.Models
{
    public class IssuesAttachments
    {
        [Key]
        public int Attachment_Id { get; set; }
        public string AttachmentPath { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentExt { get; set; }
        public string AttachmentType { get; set; }
        public string AttachmentFlag { get; set; }
        public string Documentation { get; set; }
        [NotMapped]
        public byte[] FileBytes { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedOn { get; set; }

        [NotMapped]
        public List<IssuesAttachments> ListAttachments { get; set; }
    }
}
