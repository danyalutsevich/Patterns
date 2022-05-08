using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Factory
{
    class FactoryMethod
    {
        public static void Show()
        {

            IDialog TheDialog = new DialogOne();

            IButton TheButton = TheDialog.MakeButton();
            Console.WriteLine(TheButton.Render());
            TheButton.Click();



            IDialog TheDialog2 = new DialogTwo();

            IButton TheButton2 = TheDialog2.MakeButton();
            Console.WriteLine(TheButton2.Render());
            TheButton2.Click();

        }
        

    }

    class DialogOne : IDialog
    {
        public IButton MakeButton()
        {
            return new ButtonOne(this);
        }

        public void Show()
        {
            Console.WriteLine("DialogOne");
        }
    }
    
    class DialogTwo : IDialog
    {
        public IButton MakeButton()
        {
            return new ButtonTwo(this);
        }
        
        public void Show()
        {
            Console.WriteLine("DialogTwo");
        }

    }

    class ButtonOne : IButton
    {
        DialogOne ParentDialog;
        
        public ButtonOne(DialogOne ParentDialog)
        {
            this.ParentDialog = ParentDialog;
        }
        
        public string Render()
        {
            return "<<ButtonOne>>";
        }

        public void Click()
        {
            ParentDialog.Show(); 
        }
    }

    class ButtonTwo : IButton
    {
        DialogTwo ParentDialog;

        public ButtonTwo(DialogTwo ParentDialog)
        {
            this.ParentDialog = ParentDialog;
        }

        public string Render()
        {
            return "[[ButtonTwo]]";
        }
        public void Click()
        {
            ParentDialog.Show();
        }
    }


    interface IDialog
    {
        IButton MakeButton();
        public void Show();
    }
    
    interface IButton
    {
        public string Render();
        public void Click();
        
    }
}
