// See https://aka.ms/new-console-template for more information


using Liskov.AppliedPrinciple;

SaleWithTaxes sale = new LocalSale(10.0m, "Pep", 5.5m);
sale.CalculateTaxes();
sale.Generate();
sale = new InvoiceSale(10.0m, "Invoice", 5.5m);
sale.CalculateTaxes();
sale.Generate();

BaseSale baseSale = new ForeignSale(10.0m,   "Mat", 5.5m);
baseSale.Generate();


