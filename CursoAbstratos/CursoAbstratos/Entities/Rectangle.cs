using CursoAbstratos.Entities.Enums;

namespace CursoAbstratos.Entities.Enums
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Hight { get; set; }

        public Rectangle(double widht, double hight, Color color) : base(color)
        {
            Width = widht;
            Hight = hight;
        }
        public override double Area()
        {
            return Width * Hight;
            //throw new System.NotImplementedException();
        }
    }
}