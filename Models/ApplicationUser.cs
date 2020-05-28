using AspNetCore.Identity.MongoDbCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Learning_Platforma.Models
{
  public class ApplicationUser : MongoIdentityUser
  {
    public ApplicationUser() : base()
    {
    }

    public ApplicationUser(string userName, string email) : base(userName, email)
    {
    }
  }
}
