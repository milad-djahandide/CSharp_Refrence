using System;
using System.Collections.Generic;

namespace Polymorphism_Exercise
{
    [Obsolete]
    public class Canvas_Poor
    {
        public void DrawShapes(List<Shape_Poor> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a circle in poorly designed way");
                        break;
                    case ShapeType.Rectangle:
                        Console.WriteLine("draw a rectangle in poorly designed way");
                        break;
                    case ShapeType.Triangle:
                        Console.WriteLine("draw a triangle in poorly designed way");
                        break;
                }
            }
        }
    }
}
