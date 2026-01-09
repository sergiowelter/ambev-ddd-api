using System.Linq;
using Ambev.DeveloperEvaluation.Domain.Sales;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleHandler
    {
        public Sale Handle(CreateSaleCommand command)
        {
            var sale = new Sale(
                command.SaleNumber,
                command.SaleDate,
                command.CustomerId,
                command.CustomerName,
                command.BranchId,
                command.BranchName
            );

            foreach (var item in command.Items)
            {
                var saleItem = new SaleItem(
                    item.ProductId,
                    item.ProductName,
                    item.Quantity,
                    item.UnitPrice
                );

                sale.AddItem(saleItem);
            }

            return sale;
        }
    }
}
