using CursoAbstratos.Entities.Enums;
namespace CursoAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
