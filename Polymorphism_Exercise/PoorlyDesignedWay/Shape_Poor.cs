using System;
using System.Drawing;

namespace Polymorphism_Exercise
{
    [Obsolete("Use Shape class instead")]
    public class Shape_Poor
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Position { get; set; }
        public ShapeType Type { get; set; }

    }
}
