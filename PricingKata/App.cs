namespace Pricing_Kata
{
    public class App
    {
        //calcule le prix payé par l'utilisateur dans le restaurant, en fonction de type de 
        //repas qu'il prend (assiette ou sandwich), de la taille de la boisson (petit, moyen, grand), du dessert et
        //de son type (normal ou special) et si il prend un café ou pas (yes ou no).
        //les prix sont fixes pour chaque type de chose mais des réductions peuvent s'appliquer
        //si cela rentre dans une formule!
        public double Compute(string type, string name, string beverage, string drinkSize, string dessert, string dessertSize, string coffee)
        {
            FoodType foodType = new FoodType();
            int total = 0;
            //le type ne peut être vide car le client doit déclarer au moins un repas
            if(string.IsNullOrEmpty(type+name)) return -1;

            TypeFoodEnum foodTypeEnum = foodType.mapFoodType(type);
            SizeOfDrinkEnum drinkSizeEnum = foodType.mapDrinkSize(drinkSize);

            if (foodTypeEnum == FoodType.Assiette())
            {
                foodType = new FoodType(new Plate());
            }
            else
            {
                foodType = new FoodType(new Sandwich());
            }

            total += foodType.calculatePrice(drinkSizeEnum, dessertSize);
            total += foodType.withCoffee(drinkSizeEnum, dessertSize, coffee);
            
            return total;
        }
    }
}