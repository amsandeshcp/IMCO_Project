using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCO.Models.Admin
{
    public class ClsSaveModuleRequest
    {
        public ClsModule Model { get; set; }
        public int UserId { get; set; }
    }

    public class ClsSaveModuleResponse
    {
        public bool IsSuccess { get; set; }
    }
    public class ClsModule
    {
        [Display(Name = "Module ID")]
        public int Module_ID_PK { get; set; }

        [Display(Name = "Module Name")]
        public string Module_Name { get; set; }
    }
}
