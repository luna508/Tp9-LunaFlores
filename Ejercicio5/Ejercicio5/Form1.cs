using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Crear un programa que calcule el número de CDs necesarios para hacer una copia de seguridad de la 
información almacenada en un disco rígido cuya capacidad se conoce. Considerar que el disco duro está 
lleno de información, además expresado en Gigabytes. Un CD virgen tiene 700 Megabytes de capacidad y 
un Gigabyte es igual a 1024 Megabytes*/

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gb = double.Parse(textBox1.Text);
            double mb = gb*1024;
            double cdmb = 700;

            int numero = (int)Math.Ceiling(mb/cdmb);

            label2.Text = "Numero de CDs necesario: "+numero;



        }
    }
}
