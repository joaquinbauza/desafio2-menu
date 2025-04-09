namespace Ucu.Poo.Restaurant.Tests;

[TestFixture]
public class OrderTests
{
    [Test]
    public void Order_AddOrder_ShouldAddDishToOrder()
    {
        Order order = new Order();
        Dish dish = new Dish("Pasta", 12.99, true);
        
        order.AddOrder(dish);
        
        Assert.That(order.HasOrders(), Is.True);
    }

    [Test]
    public void Order_HasOrders_ShouldReturnTrueIfOrderIsNotEmpty()
    {
        Order order = new Order();
        Dish dish = new Dish("Pasta", 12.99, true);
        order.AddOrder(dish);
        
        bool hasOrders = order.HasOrders();
        
        Assert.That(hasOrders, Is.True);
    }

    [Test]
    public void Order_HasOrders_ShouldReturnFalseIfOrderIsEmpty()
    {
        Order order = new Order();
        
        bool hasOrders = order.HasOrders();
        
        Assert.That(hasOrders, Is.False);
    }

    [Test]
    public void Order_GetTotal_ShouldReturnCorrectTotalPrice()
    {
        Order order = new Order();
        Dish dish1 = new Dish("Pasta", 12.99, true);
        Dish dish2 = new Dish("Pizza", 15.99, false);
        order.AddOrder(dish1);
        order.AddOrder(dish2);
        double expectedTotal = 12.99 + 15.99;
        
        double total = order.GetTotal();
        
        Assert.That(expectedTotal, Is.EqualTo(total));
    }

    [Test]
    public void Order_GetTotal_ShouldReturnZeroIfOrderIsEmpty()
    {
        Order order = new Order();
        
        double total = order.GetTotal();
        
        Assert.That(total, Is.Zero);
    }
}
