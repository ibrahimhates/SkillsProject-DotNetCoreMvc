using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;

namespace MvcFirstCodeEntity.Models.Classes
{
	public class YETENEKLER
	{
		[Key]
		public int ID { get; set; }
		public string ACIKLAMA { get; set; }
		public byte DEGER { get; set; }
	}
}