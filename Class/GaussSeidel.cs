using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos.Class
{
    class GaussSeidel : Matriz
    {
        // se produce cuando cambia la matriz
        public event EventHandler<MatrizEventArgs> Cambio;

        // se produce cuando se completa el procedimiento
        public event EventHandler<MatrizEventArgs> Completo;

        public GaussSeidel(int filas, int columnas)
            : base(filas, columnas) { }

        public void ApplyMethod()
        {
            double[] sol = new double[filas];
            StringBuilder sb = new StringBuilder();

            for (int iteraciones = 0; iteraciones < 5; iteraciones++)
            {
                for (int i = 0; i < filas; i++)
                {
                    double suma = 0;
                    for (int j = 0; j < columnas - 1; j++)
                    {
                        if (j == i) continue;
                        suma += matrix[i, j] * sol[j];
                    }
                    sol[i] = (matrix[i, columnas - 1] - suma) / matrix[i, i];
                }

                sb.Clear();
                sb.AppendLine("Iteracion" + (iteraciones + 1) + "\n");

                for (int i = 0; i < filas; i++)
                {
                    sb.AppendLine("X" + (i + 1) + " = " + sol[i]);
                }

                sb.AppendLine();

                OnMatrizChange(new MatrizEventArgs(sb.ToString()));

            }

            OnGuassCompleted(new MatrizEventArgs(sb.ToString()));
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
