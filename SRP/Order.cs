namespace SRP;

public class Order
{
    // from settings
    private decimal _bonusSum = 700;
    private decimal _deliveryPrice = 40;
    
    
    private readonly List<Item> _items = new List<Item>();
    
    public void AddItemToOrder(Item item)
    {
        // add item to order
        _items.Add(item);
    }
    
    public void RemoveItemFromOrder(Item itemToDelete)
    {
        // remove item from order
        var item = _items.FirstOrDefault(i => i.Id == itemToDelete.Id);
        if (item == null)
        {
            throw new Exception("Item not found");
        }
        _items.Remove(item);
    }

    public decimal CalculateTotal()
    {
        // calculate total of all items
        decimal totalPrice = _items.Select( x => x.Price).Sum();

        if (CanHaveBonus(totalPrice))
        {
            return totalPrice;

        }

        return totalPrice + _deliveryPrice;
    }

    public void SaveOrderToDatabase()
    {
        // save order to database
    }

    private bool CanHaveBonus(decimal price)
    {
        if (price >= _bonusSum)
        {
            return true;
        }

        return false;
    }
}