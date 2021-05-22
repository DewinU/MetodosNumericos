using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos.Class
{
    class Gauss : Matriz
    {
        public event EventHandler<MatrizEventArgs> Cambio;

        // se produce cuando se completa el procedimiento
        public event EventHandler<MatrizEventArgs> Completo;

        public Gauss(int filas, int columnas)
            : base(filas, columnas) { }

        public void ApplyGaussMethod()
        {
            EliminacionAdelante();
        }

        // realiza sustitucion hacia atras 
        private string SustitucionAtras()
        {
            //matrix -> matriz que contiene nuestro sistema de ecuaciones
            //filas, columnas -> cantidad de filas y columnas respetivamente

            StringBuilder sb = new StringBuilder();
            List<double> res = new List<double>();

            double x = matrix[filas - 1, columnas - 1] / matrix[filas - 1, columnas - 2];
            sb.AppendFormat("\nX{0} = {1:G30}\n ", filas, x);
            res.Add(x);

            for (int f = filas - 2; f >= 0; f--)
            {
                double sum = 0;
                int max = 0;

                for (int c = columnas - 2; c >= f + 1; c--)
                {
                    sum += matrix[f, c] * res[max];
                    max++;
                }

                double r = (matrix[f, columnas - 1] - sum) / matrix[f, f];
                sb.AppendFormat("\nX{0} = {1:G30}\n ", f + 1, r);
                res.Add(r);
            }

            return sb.ToString();
        }

        // Algoritmo que realiza eliminacion hacia adelante
        private void EliminacionAdelante()
        {
            //matrix -> matriz que contiene nuestro sistema de ecuaciones
            //filas, columnas -> cantidad de filas y columnas respetivamente

            for (int fpivot = 0; fpivot < filas - 1; fpivot++)
            {
                for (int f = fpivot + 1; f < filas; f++)
                {
                    double k = matrix[f, fpivot] / matrix[fpivot, fpivot];

                    for (int c = fpivot; c < columnas; c++)
                    {
                        matrix[f, c] = matrix[f, c] - (k * matrix[fpivot, c]);
                    }
                }

                OnMatrizChange(new MatrizEventArgs(this.ToString()));
            }

            OnGuassCompleted(new MatrizEventArgs(SustitucionAtras()));
        }

        // se ejecuta cuando cambia la matriz
        protected virtual void OnMatrizChange(MatrizEventArgs e)
        {
            if (Cambio != null)
                Cambio(this, e);
        }

        // se ejecuta cuando se ha completado el proceso
        protected virtual void OnGuassCompleted(MatrizEventArgs e)
        {
            if (Completo != null)
                Completo(this, e);
        }
    }
}
