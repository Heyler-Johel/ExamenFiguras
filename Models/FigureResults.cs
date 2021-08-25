using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFiguras.Models
{
    class FigureResults
    {
        public FigureResults()
        {

        }

        public FigureResults(float area, float perimeter, TypeOfFigure figure)
        {
            this.resultArea = area;
            this.resultPerimeter = perimeter;
            this.resultFigure = figure;
        }

        public float resultArea { get; set; }
        public float resultPerimeter { get; set; }
        public TypeOfFigure resultFigure { get; set; }

        public void print()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("El area es = " + this.resultArea);
            Console.WriteLine("El perimetro es = " + this.resultPerimeter);
            Console.WriteLine("La figura es = " + this.resultFigure);
            Console.WriteLine("*******************************************");
        }
    }
}
