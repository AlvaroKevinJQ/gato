using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GATO
{
    public partial class Form1 : Form
    {
        public int contG = 2, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        void cargarX(PictureBox obj)
        {
            // You should replace the bold image   
            // in the sample below with an icon of your own choosing.  
            // Note the escape character used (@) when specifying the path.  
            obj.Image = Image.FromFile("C:\\Users\\altai\\source\\repos\\GATO\\GATO\\Recursos\\xd.png");
           
        }
      
        void ganador()
        {
            if ((c1 == 1) & (c2 == 1) & (c3 == 1)) {
                Console.WriteLine("GANO EL JUGADOR 1");
            }
            if ((c1 == 2) & (c2 == 2) & (c3 == 2))
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }
            if ((c1 == 1) & (c4 == 1) & (c7 == 1))
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }
            if ((c1 == 1) & (c4 == 1) & (c7 == 1))
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }
            if ((c1 == 1) & (c5 == 1) & (c9 == 1))
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }
            if ((c1 == 2) & (c5 == 2) & (c9 == 2))
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }
            if ((c4 == 1) & (c5 == 1) & (c6 == 1))
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }
            if ((c4 == 2) & (c5 == 2) & (c6 == 2))
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }
            if ((c7 == 1) & (c8 == 1) & (c9 == 1))
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }
            if ((c7 == 2) & (c8 == 2) & (c9 == 2))
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }
            if ((c2 == 1) & (c5 == 1) & (c8 == 1))
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }
            if ((c2 == 2) & (c5 == 2) & (c8 == 2))
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }
            if ((c3 == 1) & (c6 == 1) & (c9 == 1))
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }
            if ((c3 == 2) & (c6 == 2) & (c9 == 2))
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }
            if ((c3 == 1) & (c5 == 1) & (c7 == 1))
            {
                Console.WriteLine("GANO EL JUGADOR 1");
            }
            if ((c3 == 2) & (c5 == 2) & (c7 == 2))
            {
                Console.WriteLine("GANO EL JUGADOR 2");
            }
        }



        void cargarY(PictureBox obj)
        {

            obj.Image = Image.FromFile("C:\\Users\\altai\\source\\repos\\GATO\\GATO\\Recursos\\c.png");

        }

            private void PB1_Click(object sender, EventArgs e) //PRIMER BOTON
        {
            
            if (contG % 2 == 0)
            {
                cargarX(PB1);
                c1 = 1;

            }
            else
            {
                cargarY(PB1);
                c1 = 2;
            }
            contG++;
            ganador();


        }

        private void pictureBox1_Click(object sender, EventArgs e) //MAPA
        {

        }

       

        private void PB2_Click(object sender, EventArgs e)
        {
            if (contG % 2 == 0)
            {
                cargarX(PB2);
                c2 = 1;
            }
            else
            {
                cargarY(PB2);
                c2 = 2;
            }
            contG++;
            ganador();

        }

        private void PB3_Click(object sender, EventArgs e)
        {
            if (contG % 2 == 0)
            {
                cargarX(PB3);
                c3 = 1;
            }
            else
            {
                cargarY(PB3);
                c3 = 4;
            }
            contG++;
            ganador();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PB4_Click(object sender, EventArgs e)
        {
            if (contG % 2 == 0)
            {
                cargarX(PB4);
                c4 = 1;
            }
            else
            {
                cargarY(PB4);
                c4 = 2;
            }
            contG++;
            ganador();
        }

        private void PB5_Click(object sender, EventArgs e)
        {
            if (contG % 2 == 0)
            {
                cargarX(PB5);
                c5 = 1;
            }
            else
            {
                cargarY(PB5);
                c5 = 2;
            }
            contG++;
            ganador();
        }

        private void PB6_Click(object sender, EventArgs e)
        {
            if (contG % 2 == 0)
            {
                cargarX(PB6);
                c6 = 1;
            }
            else
            {
                cargarY(PB6);
                c6 = 2;
            }
            contG++;
            ganador();
        }

        private void PB7_Click(object sender, EventArgs e)
        {
            if (contG % 2 == 0)
            {
                cargarX(PB7);
                c7 = 1;
            }
            else
            {
                cargarY(PB7);
                c7 = 2;
            }
            contG++;
            ganador();
        }

        private void PB8_Click(object sender, EventArgs e)
        {
            if (contG % 2 == 0)
            {
                cargarX(PB8);
                c8 = 1;
            }
            else
            {
                cargarY(PB8);
                c8 = 2;
            }
            contG++;
            ganador();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (contG % 2 == 0)
            {
                cargarX(pictureBox2);
                c9 = 1;
            }
            else
            {
                cargarY(pictureBox2);
                c9 = 2;
            }
            contG++;
            ganador();
        }
    }
}
