using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintManagement.Models
{
    public class Projects
    {
        public int Project_Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string Description { get; set; }
    }
}
