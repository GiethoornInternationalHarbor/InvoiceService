﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceService.App.Structs
{
	public struct CustomerMessageEvent
	{
		public string Id { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string PostalCode { get; set; }
		public string Residence { get; set; }
	}
}
