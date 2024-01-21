using OpenClose.AppliedPrinciple;

var list = new List<IDrink>() {
new Alcohol (){ Name = "Beer", Invoice = 1.4m, Price = 10m, Promo = 2m },
new Juice() { Name = "Juice", Invoice = 0.8m, Price = 4m, SuggarCost = 1m }
};

var invoce = new Invoice();
decimal total = invoce.GetTotal(list);

Console.WriteLine("--------------- Refactor of 'Dirty Code Class' ---------------");
Console.WriteLine($"Total Price: {total}");
