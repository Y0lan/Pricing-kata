namespace Pricing_Kata;

public abstract class ITypeFood
{
    public abstract int calculatePrice(SizeOfDrinkEnum drinkSize, string dessertSize);
}