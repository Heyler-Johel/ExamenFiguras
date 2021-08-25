using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFiguras.Models
{
    public enum TypeOfFigure
    {
        Triangulo,
        Cuadrado, 
        Rectangulo, 
        Rombo,
        No_definido
    }

    public class Figure : IFigure
    {
        public Figure()
        {
        }

        public Figure(Dictionary<int, float> sides, Dictionary<int, float> angles)
        {
            this._area = 1;
            this._perimeter = 0;;
            this._sides = sides;
            this._angles = angles;
            this._figure = TypeOfFigure.No_definido;

        }

        private Dictionary<int, float> _sides;
        private Dictionary<int, float> _angles;

        private float _area;
        private float _perimeter;
        private TypeOfFigure _figure;

        public void area()
        {
            if (_figure != TypeOfFigure.No_definido)
            {
                switch (_figure)
                {
                    case TypeOfFigure.Triangulo:
                        //usando Fórmula de Herón
                        float sp = this._perimeter / 2; //Semiperimetro
                        float m = 1; //multiplicador de s-cada lado
                        foreach (KeyValuePair<int, float> s in _sides.OrderBy(s => s.Value))
                        {
                            m *= sp - s.Value;
                        }
                        _area = (float)Math.Sqrt(sp * m);
                        break;

                    case TypeOfFigure.Cuadrado:
                        double side = _sides[1];
                        _area = (float)Math.Pow(side , 2);
                        break;

                    case TypeOfFigure.Rectangulo:
                        var sides = _sides.Values.Distinct().ToList();
                        foreach (float s in sides)
                        {
                            _area *= s;
                        }
                        break;
                    case TypeOfFigure.Rombo:
                        
                        break;
                    default:
                        break;
                }
            }
        }

        public void perimeter()
        {
            if (_figure != TypeOfFigure.No_definido)
            {
                foreach (KeyValuePair<int, float> side in _sides.OrderBy(side => side.Value))
                {
                    _perimeter += side.Value;
                }
            }
        }

        public void figure()
        {
            int cant_sides = this._sides.Count();
            int cant_angles = this._angles.Count();
            if (cant_sides == cant_angles)
            {
                if (cant_sides == 3) // Si tiene tres lados es un triangulo
                {
                    this._figure = TypeOfFigure.Triangulo;
                }
                else if (cant_sides == 4) //Puede ser Cuadrado, Rectangulo o Rombo
                {
                    int cant_d_sides = this._sides.Values.Distinct().Count();
                    int cant_d_angles = this._angles.Values.Distinct().Count();
                    if (cant_d_sides == 1 &&
                        cant_d_angles == 1) //Para cuadrado
                    {
                        this._figure = TypeOfFigure.Cuadrado;
                    }
                    else if (cant_d_sides == 2 &&
                             cant_d_angles == 1) //Para rectangulo
                    {
                        this._figure = TypeOfFigure.Rectangulo;
                    }

                    else if (cant_d_sides == 1 &&
                             cant_d_angles == 2) //Para rombo
                    {
                        this._figure = TypeOfFigure.Rombo;
                    }
                }

                //No apto para otras figuras
            }
            
        }

        public void calculate()
        {
            this.figure();
            this.perimeter();
            this.area();
            var result = new FigureResults(this._area, this._perimeter, this._figure);
            result.print();
        }
    }
}

