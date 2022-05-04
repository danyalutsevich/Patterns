using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    class CoffeeDecorator : IDecorator
    {
        public CoffeeDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Coffee();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }

    class WaterDecorator : IDecorator
    {
        public WaterDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Water();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }

    class SugarDecorator : IDecorator
    {
        public SugarDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Sugar();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }

    class CoconutOilDecorator : IDecorator
    {
        public CoconutOilDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new CoconutOil();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class ButterDecorator : IDecorator
    {
        public ButterDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Butter();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class SaltDecorator : IDecorator
    {
        public SaltDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Salt();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class FlavorExtractsDecorator : IDecorator
    {
        public FlavorExtractsDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new FlavorExtracts();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class CocoaPowderDecorator : IDecorator
    {
        public CocoaPowderDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new CocoaPowder();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class NonDairyMilkDecorator : IDecorator
    {
        public NonDairyMilkDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new NonDairyMilk();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class CardamomDecorator : IDecorator
    {
        public CardamomDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Cardamom();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class CinnamonGroundDecorator : IDecorator
    {
        public CinnamonGroundDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new CinnamonGround();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class CayennePepperDecorator : IDecorator
    {
        public CayennePepperDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new CayennePepper();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class MapleSyrupDecorator : IDecorator
    {
        public MapleSyrupDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new MapleSyrup();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class GingerDecorator : IDecorator
    {
        public GingerDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Ginger();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class HazelnutOilDecorator : IDecorator
    {
        public HazelnutOilDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new HazelnutOil();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class PeppermintOilDecorator : IDecorator
    {
        public PeppermintOilDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new PeppermintOil();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class SteviaDecorator : IDecorator
    {
        public SteviaDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Stevia();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class NutmegDecorator : IDecorator
    {
        public NutmegDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Nutmeg();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class CacaoNibsDecorator : IDecorator
    {
        public CacaoNibsDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new CacaoNibs();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class MeltedChocolateDecorator : IDecorator
    {
        public MeltedChocolateDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new MeltedChocolate();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class LavenderDecorator : IDecorator
    {
        public LavenderDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Lavender();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class RosewaterDecorator : IDecorator
    {
        public RosewaterDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Rosewater();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class StarAniseDecorator : IDecorator
    {
        public StarAniseDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new StarAnise();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class ClovesDecorator : IDecorator
    {
        public ClovesDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Cloves();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class HomemadeSyrupDecorator : IDecorator
    {
        public HomemadeSyrupDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new HomemadeSyrup();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class HomemadeCoffeeCreamerDecorator : IDecorator
    {
        public HomemadeCoffeeCreamerDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new HomemadeCoffeeCreamer();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class PumpkinPieSpiceDecorator : IDecorator
    {
        public PumpkinPieSpiceDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new PumpkinPieSpice();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class AlcoholDecorator : IDecorator
    {
        public AlcoholDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Alcohol();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class IceCreamDecorator : IDecorator
    {
        public IceCreamDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new IceCream();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class OrangeJuiceDecorator : IDecorator
    {
        public OrangeJuiceDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new OrangeJuice();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class LemonOrLimeDecorator : IDecorator
    {
        public LemonOrLimeDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new LemonOrLime();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class HoneyDecorator : IDecorator
    {
        public HoneyDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Honey();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class AgaveSyrupDecorator : IDecorator
    {
        public AgaveSyrupDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new AgaveSyrup();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class SweetenedCondensedMilkDecorator : IDecorator
    {
        public SweetenedCondensedMilkDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new SweetenedCondensedMilk();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class RawEggDecorator : IDecorator
    {
        public RawEggDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new RawEgg();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }
    class CheeseDecorator : IDecorator
    {
        public CheeseDecorator(IComponent wrappie) : base(wrappie)
        {
            IComponent component = new Cheese();
            description = component.GetDescription();
            price = component.GetPrice();
        }
    }



}
