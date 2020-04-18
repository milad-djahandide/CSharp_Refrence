using System.Drawing;

namespace Polymorphism_Exercise
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Position { get; set; }
        public abstract void Draw();

    }
}
