﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Chat_Project
{

    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_LocationChanged(object sender, EventArgs e)
        {
            textBox1.Text = this.location_show() + "\n" + this.size_show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
            
        }
    }
}
