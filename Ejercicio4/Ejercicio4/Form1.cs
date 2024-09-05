using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Crear un programa donde el usuario ingrese una letra y diga si es una vocal.*/

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char letra = char.Parse(textBox1.Text);
            char letramin = char.ToLower(letra);

            if (letramin=='a'||letramin=='e'|| letramin=='i'||letramin=='o'|| letramin=='u')
            {
                label2.Text = "ES UNA VOCAL";
            }
            else
            {
                label2.Text = "NO ES UNA VOCAL";
            }

        }
    }
}
