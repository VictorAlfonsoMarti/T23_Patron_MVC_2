﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T22_Patrón_MVC_2.View
{
    public partial class RegistroVideo : Form
    {
        public RegistroVideo()
        {
            InitializeComponent();
        }
        private void boton_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
