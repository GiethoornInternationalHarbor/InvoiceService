﻿using InvoiceService.Core.Models;
using System.Threading.Tasks;

namespace InvoiceService.Core.Repositories
{
	public interface IInvoiceRepository
	{
		/// <summary>
		/// Gets the invoice.
		/// </summary>
		/// <param name="email">The email.</param>
		/// <returns></returns>
		Task<Invoice> GetInvoice(string email);

		/// <summary>
		/// Updates the invoice asynchronous.
		/// </summary>
		/// <param name="customer">The customer.</param>
		/// <param name="ship">The ship.</param>
		/// <param name="shipService">The ship service.</param>
		/// <returns></returns>
		Task<Invoice> UpdateInvoiceAsync(Customer customer, Ship ship, ShipService shipService);

		/// <summary>
		/// Updates the invoice asynchronous.
		/// </summary>
		/// <param name="customer">The customer.</param>
		/// <param name="rental">The rental.</param>
		/// <returns></returns>
		Task<Invoice> UpdateInvoiceAsync(Customer customer, Rental rental);
	}
}
