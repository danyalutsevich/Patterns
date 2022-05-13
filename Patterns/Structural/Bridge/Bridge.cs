using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Bridge
{
    class BridgeDemo
    {

        public static void Show()
        {

            Figure figure = new Figure();

            figure.AddComponent(new Shape("Rectangle 4x4 px"))
                  .AddComponent(new Stroke("Red",10))
                  .AddComponent(new Fill("Blue (0,0,255)"));

            figure.Render();

            Console.WriteLine();
            
            figure = new Figure()
                .AddComponent(new Shape("Void"))
                .AddComponent(new Stroke("Void", 0))
                .AddComponent(new Fill("Void"));

            figure.Render();
            
            Console.WriteLine();

            figure = new Figure()
                .AddComponent(new Shape("Circle"))
                .AddComponent(new Stroke("White", 2))
                .AddComponent(new Fill("Void"))
                .AddComponent(new Shadow(4, 4, 10, "Red"));
            figure.Render();

        }
    }

    class Figure
    {

        List<IComponent> Components { get; set; }

        public Figure()
        {
            Components = new List<IComponent>();
        }

        public Figure AddComponent(IComponent component)
        {
            Components.Add(component);
            return this;
        }

        public void Render()
        {
            if (Components.Count == 0)
            {
                Console.WriteLine("👻");
            }
            else
            {
                foreach (var c in Components)
                {
                    c.Render();
                }
            }
        }

    }

    interface IComponent
    {
        public void Render();
    }

    class Shape : IComponent
    {
        private string shape;

        public Shape(string shape)
        {
            this.shape = shape;
        }

        public void Render()
        {
            Console.Write($" {shape}");
        }
    }

    class Stroke : IComponent
    {
        private string stroke;
        private int thickness;

        public Stroke(string stroke, int thickness=1)
        {
            this.stroke = stroke;
            this.thickness = thickness;
        }

        public void Render()
        {
            Console.Write($" {stroke} {thickness}px");
        }
    }

    class Fill : IComponent
    {
        private string fill;

        public Fill(string fill)
        {
            this.fill = fill;
        }

        public void Render()
        {
            Console.Write($" {fill}");
        }

    }
    
    class Shadow : IComponent
    {
        private string color;
        int XOffset;
        int YOffset;
        int blurRadius;

        public Shadow(int XOffset, int YOffset, int blurRadius, string color)
        {
            this.XOffset = XOffset;
            this.YOffset = YOffset;
            this.blurRadius = blurRadius;
            this.color = color;
        }

        public void Render()
        {
            Console.Write($" Shadow XOffset {XOffset} YOffset {YOffset} blurRadius {blurRadius} color {color}");
        }
    }

}
