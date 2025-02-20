using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engimeer_Abdul_Salams_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Go By");
            //this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // this.BackColor = Color.Blue;
            using(ColorDialog colorDialog = new ColorDialog())
            {
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Hello Mr :" + txtName.Text);
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Pleas enter a valid email address");
                return;
            }
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string gender = rbGender.Checked ? "Man" : rbGender.Checked ? "Woman" : "Other";
            string favoriteColor = btnColor.BackColor.Name;
            DateTime birthdate = dtpBirthdate.Value;
            string country = cmbCountry.SelectedItem.ToString();
            //عرض النص في اللابل
            lblResult.Text = $"{name}\n{email}\n{gender}\n Favorite Color:{favoriteColor}\n Birthdate:{birthdate.ToShortDateString()}\n Counter:{country}";


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go By");
            this.Close();
        }
    }
}
