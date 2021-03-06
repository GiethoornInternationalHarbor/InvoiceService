﻿using InvoiceService.Core.Models;
using System;
using System.Threading.Tasks;

namespace InvoiceService.Core.Repositories
{
	public interface IShipRepository
	{
		/// <summary>
		/// Creates the ship.
		/// </summary>
		/// <param name="shipId">The ship identifier.</param>
		/// <param name="customerId">The customer identifier.</param>
		/// <param name="shipName">Name of the ship.</param>
		/// <returns></returns>
		Task CreateShip(string shipId, string customerId, string shipName);

		/// <summary>
		/// Gets the ship.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		Task<Ship> GetShip(string id);

		/// <summary>
		/// Deletes the ship.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		Task DeleteShip(string id);
	}
}
