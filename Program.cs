using System;
using System.Collections.Generic;
using System.Linq;
using ExamenFiguras.Models;

namespace ExamenFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<int, float> ladost = new Dictionary<int, float>()
            {
                { 1, 42 },
                { 2, 38 },
                { 3, 12 },
            };
            Dictionary<int, float> angulost = new Dictionary<int, float>()
            {
                { 1, 30 },
                { 2, 30 },
                { 3, 30 },
            };
            var figureT = new Figure(ladost, angulost);
            figureT.calculate();

            Dictionary<int, float> ladosc = new Dictionary<int, float>()
            {
                { 1, 40 },
                { 2, 40 },
                { 3, 40 },
                { 4, 40 },
                { 5, 40 }
            };
            Dictionary<int, float> angulosc = new Dictionary<int, float>()
            {
                { 1, 90 },
                { 2, 90 },
                { 3, 90 },
                { 4, 90 },
                { 5, 90 }
            };
            var figureC = new Figure(ladosc, angulosc);
            figureC.calculate();

            Dictionary<int, float> ladosrt = new Dictionary<int, float>()
            {
                { 1, 40 },
                { 2, 60 },
                { 3, 40 },
                { 4, 60 },
            };
            Dictionary<int, float> angulosrt = new Dictionary<int, float>()
            {
                { 1, 90 },
                { 2, 90 },
                { 3, 90 },
                { 4, 90 },
            };
            var figureRT = new Figure(ladosrt, angulosrt);
            figureRT.calculate();

            Dictionary<int, float> ladosrb = new Dictionary<int, float>()
            {
                { 1, 40 },
                { 2, 40 },
                { 3, 40 },
                { 4, 40 },
            };
            Dictionary<int, float> angulosrb = new Dictionary<int, float>()
            {
                { 1, 120 },
                { 2, 40 },
                { 3, 120 },
                { 4, 40 },
            };
            var figureRB = new Figure(ladosrb, angulosrb);
            figureRB.calculate();
        }
    }
}
