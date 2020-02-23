using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCO.Models.Admin
{
    public class ClsLoginRequest
    {
        public ClsLogin Model { get; set; }
        public int UserId { get; set; }
    }

    public class ClsLoginResponse
    {
        public bool IsSuccess { get; set; }
    }
    public class ClsLogin : ClsCommon
    {
        [Display(Name = "LoginID")]
        public int Login_id { get; set; }

        [Display(Name = "PeopleID")]
        public int PeopleID_FK { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Login IS Active")]
        public bool Login_Active { get; set; }
        [Display(Name = "Login Visible")]
        public bool? Login_Visible { get; set; }

    }
}
