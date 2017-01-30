using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_1004
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// THIS RADIO BUTTON WILL ALLOW THE USER TO CHANGE THE LANGUAGE
        ///
        /// </summary>
     
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.Text = "Nom de l'employé";
                label2.Text = "Employé namid";
                label3.Text = "Des heures travaillées";
                label4.Text = "Ventes mensuelles";
                label5.Text = "Bonus de vente";
            }
            else
            {
                label1.Text = "Employee's Name :";
                label2.Text = "Employee ID :";
                label3.Text = "Total Hours Worked :";
                label4.Text = "Total Monthly Sales :";
                label5.Text = "Sales Bonus :";
            }
        }

        /// <summary>
        /// USER CAN CALCULATE THE AMOUNT OF BOUNUS EACH EMPLOYEE RECIEVE
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int totalHoursWorked, totalMonthlySales;
            double perHourWorked, totalBonus;
            totalHoursWorked = Convert.ToInt32(hoursTextBox.Text);
            totalMonthlySales = Convert.ToInt32(salesTextBox.Text);
            perHourWorked = totalHoursWorked / 160;
            totalBonus = totalMonthlySales * 0.02;
            bonusTextBox.Text = "" + perHourWorked * totalBonus;
        }
        
        /// <summary>
        /// THIS WILL ALLOW THE USE TO PRINT THE DATA 
        /// </summary>
        
        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form is being sent to printer", "Print",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// THIS WILL CLEAR ALL THE FEILDS 
        /// </summary>

        private void clearButton_Click(object sender, EventArgs e)
        {
            salesTextBox.Text = "";
            EmpNameTextBox.Text = "";
            empIDTextBox.Text = "";
            hoursTextBox.Text = "";
            bonusTextBox.Text = "";
        }

    }
}
