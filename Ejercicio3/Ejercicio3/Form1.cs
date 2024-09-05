using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Crear un programa donde el usuario ingrese dos números (a y b), el mismo deberá mostrar el resultado 
de las operaciones (a+b)*(a-b) y el resultado de la operación a2-b2*/

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int operacion = (a + b) * (a-b);
            int operacion2 = (a * a) - (b*b);

            label2.Text = "La operacion es: " + operacion;
            label3.Text = "La operacion es: " + operacion2;

        }

        
    }
}
