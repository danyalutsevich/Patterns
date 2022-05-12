using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Builder
{
    class BuilderDemo
    {
        public static void Show()
        {
            DrinkBuilder db = new CoffeeBuilder();

            db.SetSugar()
              .SetChocko()
              .SetMilk();
            
            DrinkDirector drinkDirector = new DrinkDirector(db);
            Drink drink = drinkDirector.MakeAmericano();
            Console.WriteLine(drink.Description);


            db = new CocoaBuilder();
            db.SetSugar()
              .SetChocko()
              .SetMilk().SetSyrup();

            drinkDirector = new DrinkDirector(db);
            Drink drink2 = drinkDirector.MakeEspresso();
            Console.WriteLine(drink2.Description);

        }
    }

    class CoffeeBuilder : DrinkBuilder
    {
        public CoffeeBuilder() : base(new Coffee())
        {
        }
    }

    class CocoaBuilder : DrinkBuilder
    {
        public CocoaBuilder() : base(new Cocoa())
        {
        }
    }

    class Cocoa : Drink
    {
        public Cocoa() : base("Cocoa")
        {
            HasMilk = false;
            HasSugar = false;
            HasSyrup = false;
            HasCream = false;
            HasChocko = false;
            HasCinnamon = false;
            HasIce = false;
        }
    }

    class Coffee : Drink
    {
        public Coffee() : base("Coffee")
        {
            HasMilk = false;
            HasSugar = false;
            HasSyrup = false;
            HasCream = false;
            HasChocko = false;
            HasCinnamon = false;
            HasIce = false;
        }
    }

    class DrinkBuilder
    {
        public DrinkBuilder(Drink drink)
        {
            this.drink = drink;
        }

        private Drink drink;

        public DrinkBuilder SetMilk()
        {
            drink.HasMilk = true;
            return this;
        }
        public DrinkBuilder SetSugar()
        {
            drink.HasSugar = true;
            return this;
        }
        public DrinkBuilder SetSyrup()
        {
            drink.HasSyrup = true;
            return this;
        }
        public DrinkBuilder SetCream()
        {
            drink.HasCream = true;
            return this;
        }
        public DrinkBuilder SetChocko()
        {
            drink.HasChocko = true;
            return this;
        }
        public DrinkBuilder SetCinnamon()
        {
            drink.HasCinnamon = true;
            return this;
        }
        public DrinkBuilder SetIce()
        {
            drink.HasIce = true;
            return this;
        }

        public Drink Build()
        {
            return drink;
        }

    }

    abstract class Drink
    {
        public string Name { get; }
        public string Description
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append($"{Name} ");
                if (HasMilk) { sb.Append("with milk "); }
                if (HasSugar) { sb.Append("with sugar "); }
                if (HasSyrup) { sb.Append("with syrup "); }
                if (HasCream) { sb.Append("with cream "); }
                if (HasChocko) { sb.Append("with chocko "); }
                if (HasCinnamon) { sb.Append("with cinnamon "); }
                if (HasIce) { sb.Append("with ice "); }
                if (Feature != string.Empty) { sb.Append($"{Feature} "); }

                return sb.ToString();
            }
        }

        public bool HasMilk { get; set; }
        public bool HasSugar { get; set; }
        public bool HasSyrup { get; set; }
        public bool HasCream { get; set; }
        public bool HasChocko { get; set; }
        public bool HasCinnamon { get; set; }
        public bool HasIce { get; set; }

        public string Feature { get; set; }

        public Drink(string Name)
        {
            this.Name = Name;
            Feature = string.Empty;
        }
    }

    class DrinkDirector
    {
        DrinkBuilder drinkBuilder;

        public DrinkDirector(DrinkBuilder drinkBuilder)
        {
            this.drinkBuilder = drinkBuilder;
        }

        public Drink MakeEspresso()
        {
            Drink drink = drinkBuilder.Build();
            drink.Feature = "Espresso";
            return drink;
        }

        public Drink MakeAmericano()
        {
            Drink drink = drinkBuilder.Build();
            drink.Feature = "Americano";
            return drink;
        }
    }
}
