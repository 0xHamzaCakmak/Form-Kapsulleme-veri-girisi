﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Kapsülleme_veri_girişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emlak evim = new Emlak();
            evim.Semt = textBox1.Text;
            evim.Odasayisi = Convert.ToInt32(textBox2.Text);
            evim.Katno= Convert.ToInt32(textBox3.Text);
            evim.Alan= Convert.ToInt32(textBox4.Text);
            ListViewItem kayit = new ListViewItem();
            kayit.Text = evim.Semt;
            kayit.SubItems.Add(evim.Odasayisi.ToString());
            kayit.SubItems.Add(evim.Katno.ToString());
            kayit.SubItems.Add(evim.Alan.ToString());

            listView1.Items.Add(kayit);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();

        }
    }
}
