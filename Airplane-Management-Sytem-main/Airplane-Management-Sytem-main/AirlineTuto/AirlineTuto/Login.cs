﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTuto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter The User Id and Password");
            }
            else if(UidTb.Text == "Admin" && PassTb.Text == "Admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password");
            }
        }

        private void PassTb_OnValueChanged(object sender, EventArgs e)
        {
            PassTb.isPassword= true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
