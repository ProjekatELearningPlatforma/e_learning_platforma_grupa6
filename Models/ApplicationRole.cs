using AspNetCore.Identity.MongoDbCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Learning_Platforma.Models
{
	public class ApplicationRole : MongoIdentityRole
	{
		public ApplicationRole() : base()
		{
		}

		public ApplicationRole(string roleName) : base(roleName)
		{
		}
	}
}
