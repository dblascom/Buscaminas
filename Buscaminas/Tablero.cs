using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasConsola.Modelo
{
    class Tablero
    {
        private int fils;
        private int cols;
        private Casilla [,]casillas;

        public Tablero(int n, int m)
        {            
            // sumo 2 para tener un borde
            this.fils = n+2;
            this.cols = m+2;
            casillas = new Casilla[fils,cols];
            for (int f = 0; f < fils; f++)
                for (int c = 0; c < cols; c++)
                    casillas[f, c] = new Casilla();
            
            PonUnosEnElBorde();
            PonBombas();
        }

        private void PonUnosEnElBorde()
        {
            for (int c = 0; c < cols; c++)
            {
                casillas[0, c].SumarUno();
                casillas[fils - 1, c].SumarUno();
            }

            for(int f=0; f<fils; f++)
            {
                casillas[f, 0].SumarUno();
                casillas[f, cols - 1].SumarUno();
            }
        }

        private void PonBombas()
        {
            Random rnd = new Random();
            for (int f = 1; f < fils - 1; f++)            
                for (int c = 1; c < cols - 1; c++) {
                    if ( rnd.Next(100) < 5 ) 
                    {
                        casillas[f,c].PonBomba();
                        SumaUnosAlrededor(f, c);
                    }
                }
        }

        private void SumaUnosAlrededor(int f, int c)
        {
            for (int i = (f - 1); i <= (f + 1); i++)
                for (int j = (c - 1); j <= (c + 1); j++)
                    casillas[i, j].SumarUno();
        }

        public override string ToString()
        {
            string msg = "";

            for (int f = 1; f < fils - 1; f++)
            {
                for (int c = 1; c < cols - 1; c++)
                    msg += " " + casillas[f, c];
                msg += "\n";
            }
            return msg;
        }

        internal void LevantaCasilla(int fila, int colu)
        {
            casillas[fila, colu].Levanta();

            if ( !casillas[fila, colu].EsBomba() &&
                  casillas[fila, colu].EsVacia())
            {
                // levanta alrededor
                // si no estan levantadas
                for (int f = fila - 1; f <= (fila + 1); f++)
                    for (int c = colu - 1; c <= (colu + 1); c++)
                        if (!casillas[f, c].EstaLevantada())
                            LevantaCasilla(f, c);
            }
        }
        internal string valorCasilla(int fil, int col)
        {
            return casillas[fil, col].ToString();
        }
    }
}
