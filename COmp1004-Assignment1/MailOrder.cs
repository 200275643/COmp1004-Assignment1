using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COmp1004_Assignment1
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double percentageOfHoursWorked;
            double totalBonusAmount;
            double salesBonus;
            try
            {
                if (Convert.ToDouble(HoursWorkedTextBox.Text) > 0 && Convert.ToDouble(HoursWorkedTextBox.Text) <= 160)
                {

                    percentageOfHoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text) / 160;
                    totalBonusAmount = Convert.ToDouble(TotalSalesTextBox.Text) * 0.02;
                    salesBonus = percentageOfHoursWorked * totalBonusAmount;
                    SalesBonusTextBox.Text = salesBonus.ToString();
                    TotalSalesTextBox.Text = "$" + TotalSalesTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Hours Worked: Enter a value from 0 to 160");
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                clearAll();
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            EmployeesNameTextBox.Focus();
            EmployeesNameTextBox.Text = " ";
            EmployeeIDTextBox.Text = " ";
            HoursWorkedTextBox.Text = " ";
            TotalSalesTextBox.Text = " ";
            SalesBonusTextBox.Text = " ";
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if ((SalesBonusTextBox.Text) != "")
                MessageBox.Show("The form is being sent to the printer. Thank you!");

            else
                MessageBox.Show("Please fill the form");
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeesNameLabel.Text = "Employee's Name";
            EmployeeIDLabel.Text = "Employee ID";
            HoursWorkedLabel.Text = "Hours Worked";
            TotalSalesLabel.Text = "Total Sales";
            SalesBonusLabel.Text = "Sales Bonus";
            CalculateButton.Text = "Calculate";
            ClearButton.Text = "Clear";
            PrintButton.Text = "Print";
        }

        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeesNameLabel.Text = "Le nom de l'employé";
            EmployeeIDLabel.Text = "Employé ID";
            HoursWorkedLabel.Text = "Heures travaillées";
            TotalSalesLabel.Text = "Ventes totales";
            SalesBonusLabel.Text = "Bonus de vente";
            CalculateButton.Text = "Calculer";
            ClearButton.Text = "Prochain";
            PrintButton.Text = "Impression";
        }
    }
}
