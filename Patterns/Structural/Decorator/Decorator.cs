using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    class Decorator
    {
        public static void Show()
        {
            IComponent product = new CoffeeDecorator(null); ;
            product = new WaterDecorator(product);
            product = new SugarDecorator(product);
            product = new CoconutOilDecorator(product);
            product = new ButterDecorator(product);
            product = new SaltDecorator(product);
            product = new FlavorExtractsDecorator(product);
            product = new CocoaPowderDecorator(product);
            product = new NonDairyMilkDecorator(product);
            product = new CardamomDecorator(product);
            product = new CinnamonGroundDecorator(product);
            product = new CayennePepperDecorator(product);
            product = new MapleSyrupDecorator(product);
            product = new GingerDecorator(product);
            product = new HazelnutOilDecorator(product);
            product = new PeppermintOilDecorator(product);
            product = new SteviaDecorator(product);
            product = new NutmegDecorator(product);
            product = new CacaoNibsDecorator(product);
            product = new MeltedChocolateDecorator(product);
            product = new LavenderDecorator(product);
            product = new RosewaterDecorator(product);
            product = new StarAniseDecorator(product);
            product = new ClovesDecorator(product);
            product = new HomemadeSyrupDecorator(product);
            product = new HomemadeCoffeeCreamerDecorator(product);
            product = new PumpkinPieSpiceDecorator(product);
            product = new AlcoholDecorator(product);
            product = new IceCreamDecorator(product);
            product = new OrangeJuiceDecorator(product);
            product = new LemonOrLimeDecorator(product);
            product = new HoneyDecorator(product);
            product = new AgaveSyrupDecorator(product);
            product = new SweetenedCondensedMilkDecorator(product);
            product = new RawEggDecorator(product);
            product = new CheeseDecorator(product);

            Console.WriteLine(product);
        }
    }    
}
