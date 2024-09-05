using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Crear un programa donde se muestre la suma, resta, división y multiplicación entre dos números que 
deberá ingresar el usuario.*/
namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int suma = numero1 + numero2;

            label1.Text= "La suma es: "+suma;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int resta = numero1 - numero2;

            label1.Text = "La resta es: "+ resta;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int multi = numero1 * numero2;


            label1.Text = "La multiplicacion es: "+ multi;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int div = numero1 / numero2;
        

            label1.Text = "La division es: " + div;
        }

       
    }
}
