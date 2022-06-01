using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintManagement.Models
{
    public class Customers
    {
        public int Customer_Id { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Projects { get; set; }

        // Taging
        public string Project_Id { get; set; }
        public string ProjectName { get; set; }

        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Mobile_2 { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Email_2 { get; set; }
        public string Notes { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyOn { get; set; }
        public bool IsActive { get; set; }

        [NotMapped]
        public List<CustomerAttachments> ListCustomerAttachments { get; set; }

    }
}
