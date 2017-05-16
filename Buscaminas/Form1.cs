using BuscaminasConsola.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Prompt pr = new Prompt();
            bool dificultad = pr.CreateMyForm();

            InitializeComponent();
            Tablero tablero = new Tablero(5,5);
            Casilla casilla = new Casilla();
            PintaTablero();
            //MessageBox.Show(tablero.ToString());
                
        }

        private void PintaTablero()
        {
            tablero_layout.RowCount = 5; //sustituir por parámetro el tamaño para el buscaminas

            tablero_layout.ColumnCount = 5; //sustituir por parámetro el tamaño para el buscaminas

            Button[,] botones = new Button[5, 5]; //matriz de objetos botones
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    botones[i, j] = new Button();
                    //botones[i, j].Text = "F: " + i + ", C:" + j; //comprobar que se han puesto bien
                    
                    botones[i, j].Image = global::Buscaminas.Properties.Resources.icon_bomba;
                    botones[i, j].AutoSize = true;
                    botones[i, j].AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    botones[i, j].Click += new System.EventHandler(this.click_boton);
                    tablero_layout.Controls.Add(botones[i, j]);
                }
        }

        private void PintaTableroFacil()
        {
            
            tablero_layout.RowCount = 2; //sustituir por parámetro el tamaño para el buscaminas

            tablero_layout.ColumnCount = 2; //sustituir por parámetro el tamaño para el buscaminas

            Button[,] botones2 = new Button[2, 2]; //matriz de objetos botones
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    botones2[i, j] = new Button();
                    //botones[i, j].Text = "F: " + i + ", C:" + j; comprobar que se han puesto bien
                    botones2[i, j].Image = global::Buscaminas.Properties.Resources.icon_bomba;
                    botones2[i, j].AutoSize = true;
                    botones2[i, j].AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    botones2[i, j].Click += new System.EventHandler(this.click_boton);
                    tablero_layout.Controls.Add(botones2[i, j]);
                }
        }


        private void PintaTablero(int filas, int columnas, int minas)
        {

            tablero_layout.RowCount = filas; //sustituir por parámetro el tamaño para el buscaminas

            tablero_layout.ColumnCount = columnas; //sustituir por parámetro el tamaño para el buscaminas

            Button[,] botones2 = new Button[filas, columnas]; //matriz de objetos botones
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                {
                    botones2[i, j] = new Button();
                    //botones[i, j].Text = "F: " + i + ", C:" + j; comprobar que se han puesto bien
                    botones2[i, j].Image = global::Buscaminas.Properties.Resources.icon_bomba;
                    botones2[i, j].AutoSize = true;
                    botones2[i, j].AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    botones2[i, j].Click += new System.EventHandler(this.click_boton);
                    tablero_layout.Controls.Add(botones2[i, j]);
                }
        }

        private void click_boton(object sender, EventArgs e)
        {
            MessageBox.Show("Bomba");
        }


        private void mnuAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("David Blasco Marina - MIW");
        }

        private void click_btnFacil(object sender, EventArgs e)
        {

            MessageBox.Show("Facil");
            NivelJuego gamelevel = new NivelJuego(0);
            Console.WriteLine(gamelevel.filas);
            Console.WriteLine(gamelevel.columnas);
            Console.WriteLine(gamelevel.minas);

            PintaTablero(gamelevel.filas, gamelevel.columnas, gamelevel.minas);
        }


        private void click_btnDificil(object sender, EventArgs e)
        {
            MessageBox.Show("Dificil");
            NivelJuego gamelevel = new NivelJuego(2);

            PintaTablero(gamelevel.filas, gamelevel.columnas, gamelevel.minas);

        }

    }
}
