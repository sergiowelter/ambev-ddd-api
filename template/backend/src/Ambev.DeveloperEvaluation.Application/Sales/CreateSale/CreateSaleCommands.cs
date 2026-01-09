using System;
using System.Collections.Generic;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleCommand
    {
        public string SaleNumber { get; set; }
        public DateTime SaleDate { get; set; }

        // Customer (External Identity)
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }

        // Branch (External Identity)
        public Guid BranchId { get; set; }
        public string BranchName { get; set; }

        public List<CreateSaleItemCommand> Items { get; set; }
    }

    public class CreateSaleItemCommand
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
