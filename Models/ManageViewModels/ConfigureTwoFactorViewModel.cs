using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Learning_Platforma.Models.ManageViewModels
{
  public class ConfigureTwoFactorViewModel
  {
    public string SelectedProvider { get; set; }

    public ICollection<SelectListItem> Providers { get; set; }
  }
}
