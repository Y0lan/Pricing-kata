namespace Pricing_Kata;

public class Plate
{
    private int total = 15;

    public int calculatePrice(SizeOfDrinkEnum drinkSize, string dessertSize)
    {
        if (drinkSize == SizeOfDrinkEnum.Moyen && dessertSize == "normal")
        {
            Console.Write("Prix Formule Standard appliquée");
            total = 18;
        }
        else if (drinkSize == SizeOfDrinkEnum.Grand && dessertSize != "normal")
        {
            Console.Write("Prix Formule Max appliquée");
            total = 21;
        }
        else
        {
            withDrink(drinkSize);
            withDessert(dessertSize);
        }

        return total;
    }

    public void withDrink(SizeOfDrinkEnum drinkSizeEnum)
    {
        if (drinkSizeEnum == SizeOfDrinkEnum.Petit)
        {
            total += 2;
        }
        else if (drinkSizeEnum == SizeOfDrinkEnum.Moyen)
        {
            total += 3;
        }
        
        
        else
        {
            total += 4;
        } 
    }
        
    public void withDessert(string dessertSize)
    {
        total += dessertSize == "normal" ? 2 : 4;
    }
                
}