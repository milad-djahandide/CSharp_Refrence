using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace Polymorphism_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Poorly designed
            var shapesPoor = new List<Shape_Poor>();
            shapesPoor.Add(new Shape_Poor() { Height = 12, Position = new Point(12, 5), Width = 3, Type = ShapeType.Circle });
            shapesPoor.Add(new Shape_Poor() { Height = 12, Position = new Point(12, 5), Width = 3, Type = ShapeType.Rectangle });
            shapesPoor.Add(new Shape_Poor() { Height = 12, Position = new Point(12, 5), Width = 3, Type = ShapeType.Triangle });

            var canvasPoor = new Canvas_Poor();
            canvasPoor.DrawShapes(shapesPoor);
            #endregion

            #region Optimized by polymorphism
            var shapes = new List<Shape>();
            //Normal Method
            //shapes.Add(new Circle);
            //shapes.Add(new Rectangle);
            //shapes.Add(new Triangle);

            //Professional Method : In this way every classes inherited from SHape class would be added to
            //the list automatically and after adding a new shape this code does not need to be recompiled
            foreach (Type type in
            Assembly.GetAssembly(typeof(Shape)).GetTypes()
            .Where(myType => myType.IsClass && myType.IsSubclassOf(typeof(Shape))))
            {
                shapes.Add((Shape)Activator.CreateInstance(type, null));
            }

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

            

            #endregion
        }
    }
}
