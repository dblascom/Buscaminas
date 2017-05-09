using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class NivelJuego
    {
        int MINAS = 10;
        int TAMAÑOX = 10;
        int TAMAÑOY = 10;

        int fils;
        int cols;
        int numminas;

        public NivelJuego(int nivel)
        {
            switch (nivel)
            {
                case (0): //Facil
                    System.Console.WriteLine("En niveljuego facil");
                    this.fils = TAMAÑOX - 5;
                    this.cols = TAMAÑOY - 5;
                    this.numminas = MINAS - 5;
                    break;

                case (1): //Intermedio

                    this.fils = TAMAÑOX;
                    this.cols = TAMAÑOY;
                    this.numminas = MINAS;
                    break;

                case (2): // Dificil

                    this.fils = TAMAÑOX + 5;
                    this.cols = TAMAÑOY + 5;
                    this.numminas = MINAS + 5;
                    break;
            }            
        }

        public int filas
        {
            get { return this.fils; }
            set { this.fils = value; }
        }

        public int columnas
        {
            get { return this.cols; }
            set { this.fils = value; }
        }

        public int minas
        {
            get { return this.numminas; }
            set { this.fils = value; }
        }

    }
}
