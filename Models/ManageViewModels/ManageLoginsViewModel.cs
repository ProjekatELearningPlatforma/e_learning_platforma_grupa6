using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Learning_Platforma.Models.ManageViewModels
{
  public class ManageLoginsViewModel
  {
    public IList<UserLoginInfo> CurrentLogins { get; set; }

    public IList<AuthenticationScheme> OtherLogins { get; set; }
  }
}
