﻿using InvoiceService.Core.EventSourcing.Ids;
using System;
using System.ComponentModel.DataAnnotations;

namespace InvoiceService.Core.Models
{
	public class InvoiceLine
	{


		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>											
		//[Required]
		//[Key]
		//public Guid Id { get; set; }

		public ShipServiceId ServiceId { get; set; }

		public ShipId ShipId { get; set;  }
		/// <summary>
		/// Gets or sets the type of the invoice.
		/// </summary>
		/// <value>
		/// The type of the invoice.
		/// </value>
		[Required]
		public InvoiceTypes InvoiceType { get; set; }
	}
}
