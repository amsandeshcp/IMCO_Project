using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCO.Models.Admin
{
    public class ClsGroups : ClsCommon
    {
        [Display(Name = "Group ID")]
        public int GrpID_PK { get; set; }

        [Display(Name = "Group Type")]
        public int? GroupType { get; set; }

        [Display(Name = "Group Name")]
        public string GrpName { get; set; }

        [Display(Name = "Group Desc")]
        public string GrpDesc { get; set; }

        [Display(Name = "IS Active")]
        public bool? IsActive { get; set; }

    }
}
