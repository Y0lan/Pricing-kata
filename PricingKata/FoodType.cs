namespace Pricing_Kata;

class FoodType
    {
        private ITypeFood _foodType;

        public FoodType(ITypeFood foodType)
        {
            _foodType = foodType;
        }

        //public FoodType(Sandwich foodType)
        //{
        //    throw new NotImplementedException();
        //}

        public int calculatePrice(SizeOfDrinkEnum drinkSize, string dessertSize)
        {
            return _foodType.calculatePrice(drinkSize, dessertSize);
            
        }
        
        public int withCoffee(SizeOfDrinkEnum drinkSize, string dessertSize, string coffee)
        {
            int total = 0;
            if (drinkSize == SizeOfDrinkEnum.Moyen && dessertSize == "normal" && coffee == "yes")
            {
                Console.Write(" avec café offert!");
            }
            else
            {
                total += 1;
            }

            return total;
        }

        public TypeFoodEnum mapFoodType(string type)
        {
            return type == "assiette" ? TypeFoodEnum.Assiette : TypeFoodEnum.Sandwich;
        }
        
        public SizeOfDrinkEnum mapDrinkSize(string drinkSize)
        {

            if (drinkSize == "moyen")
            {
                return SizeOfDrinkEnum.Moyen;
            }
            if (drinkSize == "grand")
            {
                return SizeOfDrinkEnum.Grand;
            }
                
            return SizeOfDrinkEnum.Petit;
            
        }
    }