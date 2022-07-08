using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clase16ejercicio.Figuras
{
    internal abstract class Cuadrilatero
    {
        private int[] _punto1 = new int[2];
        private int[] _punto2 = new int[2];
        private int[] _punto3 = new int[2];
        private int[] _punto4 = new int[2];

        public int puntox1
        {
            get
            {
                return _punto1[0];
            }
            set
            {
                _punto1[0] = value;
            }
        }
        public int puntoy1
        {
            get
            {
                return _punto1[1];
            }
            set
            {
                _punto1[1] = value;
            }
        }


        public int puntox2
        {
            get
            {
                return _punto2[0];
            }
            set
            {
                _punto2[0] = value;
            }
        }
        public int puntoy2
        {
            get
            {
                return _punto2[1];
            }
            set
            {
                _punto2[1] = value;
            }
        }


        public int puntox3
        {
            get
            {
                return _punto3[0];
            }
            set
            {
                _punto3[0] = value;
            }
        }
        public int puntoy3
        {
            get
            {
                return _punto3[1];
            }
            set
            {
                _punto3[1] = value;
            }
        }


        public int puntox4
        {
            get
            {
                return _punto4[0];
            }
            set
            {
                _punto4[0] = value;
            }
        }
        public int puntoy4
        {
            get
            {
                return _punto4[1];
            }
            set
            {
                _punto4[1] = value;
            }
        }

        public Cuadrilatero(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            puntox1 = x1;
            puntoy1 = y1;
            puntox2 = x2;
            puntoy2 = y2;
            puntox3 = x3;
            puntoy3 = y3;
            puntox4 = x4;
            puntoy4 = y4;
        }

        public Cuadrilatero(int x1, int y1, int x2, int y2)
        {
            puntox1 = x1;
            puntoy1 = y1;
            puntox2 = x2;
            puntoy2 = y2;
        }


        public Cuadrilatero(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            puntox1 = x1;
            puntoy1 = y1;
            puntox2 = x2;
            puntoy2 = y2;
            puntox3 = x3;
            puntoy3 = y3;
        }

        public void CalcularArea()
        {
            int largo, altura, corto, area;

            if (GetType() == typeof(Cuadrado))
            {
                largo = (int)Math.Pow(_punto1[0] - _punto2[0], 2);
                Console.WriteLine($"El area del cuadrado es : {largo}");
            }
            if (GetType() == typeof(Rectangulo))
            {
                largo = _punto2[0] - _punto1[0];
                altura = _punto3[1] - _punto2[1];
                area = largo * altura;
                Console.WriteLine($"El area del rectangulo es : {area}");
            }
            if (GetType() == typeof(Trapecio))
            {
                largo = _punto2[0] - _punto1[0];
                corto = _punto4[0] - _punto3[0];
                altura = _punto3[1] - _punto1[1];
                area = ((largo + corto) / 2) * altura;
                Console.WriteLine($"El area del trapecio es: {area}");
            }
        }


    }
}
