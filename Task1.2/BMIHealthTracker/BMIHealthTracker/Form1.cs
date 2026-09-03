using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIHealthTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResults.Text = "Please enter user details above and click 'Calculate BMI'.";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtName.Text.Trim();
                if (string.IsNullOrWhiteSpace(userName))
                {
                    userName = "Anonymous User";
                }

                // 1. Validate Height & Weight
                if (!double.TryParse(txtHeight.Text.Trim(), out double heightCm) || heightCm <= 0)
                {
                    MessageBox.Show("Please enter a valid height in cm (e.g. 175).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeight.Focus();
                    return;
                }

                if (!double.TryParse(txtWeight.Text.Trim(), out double weightKg) || weightKg <= 0)
                {
                    MessageBox.Show("Please enter a valid weight in kg (e.g. 70).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWeight.Focus();
                    return;
                }

                // 2. BMI Calculation: Weight (kg) / [Height (m)]^2
                double heightM = heightCm / 100.0;
                double bmi = weightKg / (heightM * heightM);

                // 3. Category & Clinical Advice
                string category;
                string healthAdvice;

                if (bmi < 18.5)
                {
                    category = "Underweight";
                    healthAdvice = "Caloric and nutritional intake increase recommended.";
                }
                else if (bmi < 25.0)
                {
                    category = "Normal (Healthy Weight)";
                    healthAdvice = "Maintain current balanced diet and regular physical activity.";
                }
                else if (bmi < 30.0)
                {
                    category = "Overweight";
                    healthAdvice = "Cardiovascular exercise and caloric monitoring advised.";
                }
                else
                {
                    category = "Obese";
                    healthAdvice = "Consultation with a healthcare professional recommended.";
                }

                // 4. Ideal Weight Range (BMI 18.5 - 24.9)
                double minIdealWeight = 18.5 * (heightM * heightM);
                double maxIdealWeight = 24.9 * (heightM * heightM);

                // 5. Output Clean Results
                txtResults.Clear();
                txtResults.AppendText($"User Name           : {userName}\n");
                txtResults.AppendText($"Calculated BMI      : {bmi:N2} kg/m²\n");
                txtResults.AppendText($"Health Category     : {category}\n");
                txtResults.AppendText($"Ideal Weight Range  : {minIdealWeight:N1} kg - {maxIdealWeight:N1} kg\n");
                txtResults.AppendText($"Clinical Advice     : {healthAdvice}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {

        }
    }
}