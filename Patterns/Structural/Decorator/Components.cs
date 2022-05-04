using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    class Coffee : IComponent
    {
        public string Description;
        public float Price;

        public Coffee()
        {
            Description = "Coffee";
            Price = 36;
        }

        public string GetDescription() => Description;
        public float GetPrice() => Price;

    }

    class Water : IComponent
    {
        public string Description;
        public float Price;

        public Water()
        {
            Description = "Aqua";
            Price = 0;
        }

        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Sugar : IComponent
    {
        public string Description;
        public float Price;

        public Sugar()
        {
            Description = "Sugar";
            Price = 2;
        }

        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class CoconutOil : IComponent
    {
        public string Description;
        public float Price;
        public CoconutOil()
        {
            Description = "CoconutOil";
            Price = 8;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Butter : IComponent
    {
        public string Description;
        public float Price;
        public Butter()
        {
            Description = "Butter";
            Price = 0;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Salt : IComponent
    {
        public string Description;
        public float Price;
        public Salt()
        {
            Description = "Salt";
            Price = 7;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class FlavorExtracts : IComponent
    {
        public string Description;
        public float Price;
        public FlavorExtracts()
        {
            Description = "FlavorExtracts";
            Price = 15;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class CocoaPowder : IComponent
    {
        public string Description;
        public float Price;
        public CocoaPowder()
        {
            Description = "CocoaPowder";
            Price = 13;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class NonDairyMilk : IComponent
    {
        public string Description;
        public float Price;
        public NonDairyMilk()
        {
            Description = "NonDairyMilk";
            Price = 17;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Cardamom : IComponent
    {
        public string Description;
        public float Price;
        public Cardamom()
        {
            Description = "Cardamom";
            Price = 0;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class CinnamonGround : IComponent
    {
        public string Description;
        public float Price;
        public CinnamonGround()
        {
            Description = "CinnamonGround";
            Price = 11;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class CayennePepper : IComponent
    {
        public string Description;
        public float Price;
        public CayennePepper()
        {
            Description = "CayennePepper";
            Price = 7;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class MapleSyrup : IComponent
    {
        public string Description;
        public float Price;
        public MapleSyrup()
        {
            Description = "MapleSyrup";
            Price = 4;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Ginger : IComponent
    {
        public string Description;
        public float Price;
        public Ginger()
        {
            Description = "Ginger";
            Price = 20;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class HazelnutOil : IComponent
    {
        public string Description;
        public float Price;
        public HazelnutOil()
        {
            Description = "HazelnutOil";
            Price = 19;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class PeppermintOil : IComponent
    {
        public string Description;
        public float Price;
        public PeppermintOil()
        {
            Description = "PeppermintOil";
            Price = 17;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Stevia : IComponent
    {
        public string Description;
        public float Price;
        public Stevia()
        {
            Description = "Stevia";
            Price = 3;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Nutmeg : IComponent
    {
        public string Description;
        public float Price;
        public Nutmeg()
        {
            Description = "Nutmeg";
            Price = 0;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class CacaoNibs : IComponent
    {
        public string Description;
        public float Price;
        public CacaoNibs()
        {
            Description = "CacaoNibs";
            Price = 13;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class MeltedChocolate : IComponent
    {
        public string Description;
        public float Price;
        public MeltedChocolate()
        {
            Description = "MeltedChocolate";
            Price = 15;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Lavender : IComponent
    {
        public string Description;
        public float Price;
        public Lavender()
        {
            Description = "Lavender";
            Price = 19;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Rosewater : IComponent
    {
        public string Description;
        public float Price;
        public Rosewater()
        {
            Description = "Rosewater";
            Price = 15;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class StarAnise : IComponent
    {
        public string Description;
        public float Price;
        public StarAnise()
        {
            Description = "StarAnise";
            Price = 2;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Cloves : IComponent
    {
        public string Description;
        public float Price;
        public Cloves()
        {
            Description = "Cloves";
            Price = 16;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class HomemadeSyrup : IComponent
    {
        public string Description;
        public float Price;
        public HomemadeSyrup()
        {
            Description = "HomemadeSyrup";
            Price = 16;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class HomemadeCoffeeCreamer : IComponent
    {
        public string Description;
        public float Price;
        public HomemadeCoffeeCreamer()
        {
            Description = "HomemadeCoffeeCreamer";
            Price = 14;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class PumpkinPieSpice : IComponent
    {
        public string Description;
        public float Price;
        public PumpkinPieSpice()
        {
            Description = "PumpkinPieSpice";
            Price = 1;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Alcohol : IComponent
    {
        public string Description;
        public float Price;
        public Alcohol()
        {
            Description = "Alcohol";
            Price = 7;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class IceCream : IComponent
    {
        public string Description;
        public float Price;
        public IceCream()
        {
            Description = "IceCream";
            Price = 4;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class OrangeJuice : IComponent
    {
        public string Description;
        public float Price;
        public OrangeJuice()
        {
            Description = "OrangeJuice";
            Price = 12;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class LemonOrLime : IComponent
    {
        public string Description;
        public float Price;
        public LemonOrLime()
        {
            Description = "LemonOrLime";
            Price = 11;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Honey : IComponent
    {
        public string Description;
        public float Price;
        public Honey()
        {
            Description = "Honey";
            Price = 12;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class AgaveSyrup : IComponent
    {
        public string Description;
        public float Price;
        public AgaveSyrup()
        {
            Description = "AgaveSyrup";
            Price = 9;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class SweetenedCondensedMilk : IComponent
    {
        public string Description;
        public float Price;
        public SweetenedCondensedMilk()
        {
            Description = "SweetenedCondensedMilk";
            Price = 4;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class RawEgg : IComponent
    {
        public string Description;
        public float Price;
        public RawEgg()
        {
            Description = "RawEgg";
            Price = 6;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }

    class Cheese : IComponent
    {
        public string Description;
        public float Price;
        public Cheese()
        {
            Description = "Cheese";
            Price = 15;
        }
        public string GetDescription() => Description;
        public float GetPrice() => Price;
    }




}
