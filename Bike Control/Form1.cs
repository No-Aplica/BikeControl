using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => panel1.Visible = true;

        private void label6_Click(object sender, EventArgs e)
        {

            string codigo = textBox1.Text;
            //Validación codigo
            codigo.Trim();
            bool valido = true;
            int i = 0;
            while (i < codigo.LongCount() && valido)
            {
                if (codigo[i] < 48 || codigo[i] > 57)
                {
                    valido = false;
                    textBox8.Text = "Fallo en código";
                }
                i++;
            }
            string marca = textBox2.Text;
            //Marca no necesita validación
            string aro = textBox3.Text;
            //Validación Aro
            aro.Trim();
            i = 0;
            while (i < aro.LongCount() && valido)
            {
                textBox8.Text = Convert.ToInt32(aro[i]).ToString();
                if (aro[i] < 48 || aro[i] > 57)
                {
                    valido = false;
                    textBox8.Text = "Fallo en aro";
                }
                i++;
            }
            string costo = textBox4.Text;
            //Validación costo
            costo.Trim();
            i = 0;
            while (i < costo.LongCount() && valido)
            {
                textBox8.Text = Convert.ToInt32(costo[i]).ToString();
                if (costo[i] < 48 || costo[i] > 57)
                {
                    valido = false;
                    textBox8.Text = "Fallo en costo";
                }
                i++;
            }
            costo= String.Concat("$ ",costo, " /hr");
            if (valido) dataGridView1.Rows.Add(codigo, marca, aro, "Disponible", costo);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            panel1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            panel1.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //El try es por si hacen click en los headers de el datagridview, ya que eso provoca una excepción no controlada
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string estado = row.Cells[3].Value.ToString();
                textBox8.Text = estado;
                if (estado == "Disponible")
                {
                    panel2.Visible = true;
                }
                else if (estado == "En Arriendo")
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = true;
                    panel4.Visible = true;
                }
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            panel2.Visible = false;

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel3.Visible = false;
        }
    }
}
