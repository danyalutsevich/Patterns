using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Composite
{
    class CompositeDemo
    {

        public static void Show()
        {

            Firm firm = new Firm();

            firm.Members.Add(new FinDirector());
            firm.Members.Add(new ExeDirector());
            

            firm.MakeResolution("Bake a cookie");

            Console.WriteLine("With pattern");
            Console.WriteLine();

            LabourUnion labourUnion = new LabourUnion();
            labourUnion.TakeResolution("Remove all taxies");

            Console.WriteLine();

            Italy italy = new Italy();
            italy.TakeResolution("dispose all taxies comanies");

            Console.WriteLine();

            DivisionsDelegate divisionsDelegate = new DivisionsDelegate();
            divisionsDelegate.TakeResolution("Bake a cookies");


        }


    }

    interface IMember
    {
        void TakeResolution(string resolution);
    }

    class FinDirector : IMember
    {
        public void TakeResolution(string resolution)
        {
            Console.WriteLine($"FinDirector take {resolution}");
        }
    }

    class ExeDirector : IMember
    {
        public void TakeResolution(string resolution)
        {
            Console.WriteLine($"ExeDirector take {resolution}");
        }
    }

    class Firm
    {
        public List<IMember> Members { get; set; }

        public Firm()
        {
            Members = new List<IMember>();
        }

        public void MakeResolution(string resolution)
        {
            Console.WriteLine($"Firm make resolution {resolution}");
            foreach (var member in Members)
            {
                if(member is CompositeMember)
                {
                    Console.Write($" [{(member as CompositeMember).Members.Count}] ");
                }
                
                member.TakeResolution(resolution);
            }
        }
    }

    // ============================================ With pattern ============================================

    class LabourUnion : CompositeMember
    {
        public LabourUnion()
        {
            Members = new List<IMember>();
            Members.Add(new BakersDelegate());
            Members.Add(new CleaningsDelegate());
            Members.Add(new LoadersDelegate());

        }

        public override void TakeResolution(string resolution)
        {
            Console.WriteLine($"LabourUnion take {resolution}");

            foreach (var member in Members)
            {
                Console.Write("✅");
                member.TakeResolution(resolution);
            }
        }
    }

    abstract class CompositeMember : IMember
    {
        public List<IMember> Members { get; set; }

        public CompositeMember()
        {
            Members = new List<IMember>();
        }

        public abstract void TakeResolution(string resolution);
    }

    class BakersDelegate : IMember
    {
        public void TakeResolution(string resolution)
        {
            Console.WriteLine($"BakersDelegate take {resolution}");
        }
    }

    class CleaningsDelegate : IMember
    {
        public void TakeResolution(string resolution)
        {
            Console.WriteLine($"CleaningDelegate take {resolution}");
        }
    }

    class LoadersDelegate : IMember
    {
        public void TakeResolution(string resolution)
        {
            Console.WriteLine($"LoadersDelegate take {resolution}");
        }
    }

    class TaxiCompany : CompositeMember, IDisposable
    {
        public override void TakeResolution(string resolution)
        {
            Console.WriteLine($"TaxiCompany take {resolution}");
        }

        public void Dispose()
        {
            Console.WriteLine("TaxiCompany is disposed from Italy");
        }

    }

    class Italy : CompositeMember
    {
        public Italy()
        {
            Members = new List<IMember>();
            Members.Add(new TaxiCompany());
        }
        
        public override void TakeResolution(string resolution)
        {
            Console.WriteLine($"Italy  {resolution}");
        }
    }

    class KhersonDelegate : IMember
    {
        public void TakeResolution(string resolution)
        {
            Console.WriteLine($"KhersonDelegate take {resolution}");
        }
    }

    class MykolaivDelegate : IMember
    {
        public void TakeResolution(string resolution)
        {
            Console.WriteLine($"MykolaivDelegate take {resolution}");
        }
    }

    class DivisionsDelegate : CompositeMember
    {

        public DivisionsDelegate()
        {
            Members = new List<IMember>();
            Members.Add(new KhersonDelegate());
            Members.Add(new MykolaivDelegate());
            Members.Add(new OdessaDelegate());
            
        }

        public override void TakeResolution(string resolution)
        {
            Console.WriteLine($"DivisionsDelegate take {resolution}");
            foreach (var member in Members)
            {
                Console.Write("✅");

                if (member is CompositeMember)
                {
                    Console.Write($" [{(member as CompositeMember).Members.Count}] ");
                }

                    member.TakeResolution(resolution);
            }
        }

    }

    class OdessaDelegate : CompositeMember
    {
        public OdessaDelegate()
        {
            Members = new List<IMember>();
            Members.Add(new IzmailDelegate());
            Members.Add(new YuzhneDelegate());
            Members.Add(new ZatokaDelegate());
        }

        public override void TakeResolution(string resolution)
        {
            Console.WriteLine($"Odessa take {resolution}");
            foreach (var member in Members)
            {
                Console.Write(" ✅");
                member.TakeResolution(resolution);
            }
        }
    }

    class IzmailDelegate : CompositeMember
    {
        public IzmailDelegate()
        {
            Members = new List<IMember>();
        }

        public override void TakeResolution(string resolution)
        {
            Console.WriteLine($"Izmail take {resolution}");
            foreach (var member in Members)
            {
                Console.Write("✅");
                member.TakeResolution(resolution);
            }
        }
    }

    class YuzhneDelegate : CompositeMember
    {
        public YuzhneDelegate()
        {
            Members = new List<IMember>();
        }

        public override void TakeResolution(string resolution)
        {
            Console.WriteLine($"Yuzhne take {resolution}");
            foreach (var member in Members)
            {
                Console.Write("✅");
                member.TakeResolution(resolution);
            }
        }
    }

    class ZatokaDelegate : CompositeMember
    {
        public ZatokaDelegate()
        {
            Members = new List<IMember>();
        }

        public override void TakeResolution(string resolution)
        {
            Console.WriteLine($"Zatoka take {resolution}");
            foreach (var member in Members)
            {
                Console.Write("✅");
                member.TakeResolution(resolution);
            }
        }
    }

    


}
