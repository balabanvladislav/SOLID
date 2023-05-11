using SRP;

var order = new Order();
order.AddItemToOrder(
    new Item {
        Price = 10,
        Id = 12
    });
    
order.AddItemToOrder(new Item 
{
    Price = 12,
    Id = 1 
});

Console.WriteLine(order.CalculateTotal());