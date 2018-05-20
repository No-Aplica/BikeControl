﻿using System;
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
            string marca = textBox2.Text;
            string aro = textBox3.Text;
            string costo=String.Concat("$ ",textBox4.Text," /hr");
            dataGridView1.Rows.Add(codigo,marca,aro,"Disponible",costo);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
