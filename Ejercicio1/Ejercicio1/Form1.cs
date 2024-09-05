using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Escribí un programa que solicite al usuario que ingrese su nombre. El nombre se debe almacenar en una
variable llamada nombre.A continuación, se debe mostrar en pantalla el texto “Ahora estás en la matrix,
[usuario]”, donde “[usuario]” se reemplazará por el nombre que el usuario haya ingresado.*/

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            label2.Text = "Ahora esta en la matrix  " + nombre;

        }

        
    }
}
