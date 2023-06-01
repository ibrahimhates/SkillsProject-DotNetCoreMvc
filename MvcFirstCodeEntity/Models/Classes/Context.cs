using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcFirstCodeEntity.Models.Classes
{
	public class Context : DbContext
	{
		public DbSet <YETENEKLER> YETENEKLERS { get; set; }
	}
}