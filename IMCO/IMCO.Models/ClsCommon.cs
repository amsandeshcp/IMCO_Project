using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCO.Models
{
    public class ClsCommon
    {
        [Display(Name = "Created User ID")]
        public int? CreatedUserID { get; set; }

        [Display(Name = "Created DateTime")]
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;

        [Display(Name = "Update User ID")]
        public int? UpdatedUserID { get; set; }

        [Display(Name = "Updated DateTime")]
        public DateTime? UpdatedDateTime { get; set; } = DateTime.Now;
    }
}
