﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float kisa, uzun, cevre,alan;
            kisa = Convert.ToSingle(txtKisa.Text);
            uzun = Convert.ToSingle(txtUzun.Text);
            cevre = (kisa + uzun) * 2;
            lblCevre.Text="Çevre: "+cevre.ToString();


            alan = kisa * uzun;
            lblAlan.Text = "Alan: "+alan.ToString();
        }
    }
}
