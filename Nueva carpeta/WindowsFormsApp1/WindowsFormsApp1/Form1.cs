﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
            private void btnLogin_Click(object sender, EventArgs e)
            {
                if (txtUsername.Text == "kely" && txtPassword.Text == "123")
                {
                    Form2 preguntasForm = new Form2();
                    preguntasForm.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }

        
    }
}
