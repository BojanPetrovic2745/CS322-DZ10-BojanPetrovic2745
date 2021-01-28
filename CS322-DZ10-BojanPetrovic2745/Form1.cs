using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ10_BojanPetrovic2745
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList lista = new ArrayList();
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < 100; i++)
            {
                lista.Add(rnd.Next(i));
                listBox1.Items.Add(lista[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(int.Parse(tbBrisi.Text));
            listBox1.Items.RemoveAt(int.Parse(tbBrisi.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista.Add(int.Parse(tbDodaj.Text));
            listBox1.Items.Add(int.Parse(tbDodaj.Text));
        }
    }
}
