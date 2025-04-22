using System.Collections;

namespace Ucu.Poo.Restaurant;

public class Order
{
    private ArrayList order = new ArrayList();

    public void AddOrder(Dish dish)
    {
        this.order.Add(dish);
    }

    public bool HasOrder()
    {
        int contador = 0;
        for (int i = 0; i < order.Count; i++)
        {
            contador += 1;
        }
        return contador > 0;
    }
    public double GetTotal(Table table)
    {
        double TotalCost = 0;
        foreach (Dish dish in order)
        {
            TotalCost += dish.Price;
        }
        return TotalCost;
    }
}