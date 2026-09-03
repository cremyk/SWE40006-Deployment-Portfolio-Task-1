using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BmiCalculatorLib;   // Custom DLL 1
using HealthAdviceLib;    // Custom DLL 2

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

                // 1. Validate Input
                if (!double.TryParse(txtHeight.Text.Trim(), out double heightCm) || heightCm <= 0)
                {
                    MessageBox.Show("Please enter a valid height in cm (e.g., 175).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeight.Focus();
                    return;
                }

                if (!double.TryParse(txtWeight.Text.Trim(), out double weightKg) || weightKg <= 0)
                {
                    MessageBox.Show("Please enter a valid weight in kg (e.g., 70).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWeight.Focus();
                    return;
                }

                // 2. CALL CUSTOM DLL 1 (BmiCalculatorLib.dll)
                double bmi = BmiCalculator.CalculateBmi(weightKg, heightCm);
                var idealRange = BmiCalculator.GetIdealWeightRange(heightCm);

                // 3. CALL CUSTOM DLL 2 (HealthAdviceLib.dll)
                string category = HealthAdvisor.GetCategory(bmi);
                string advice = HealthAdvisor.GetAdvice(bmi);

                // 4. Output results to the UI
                txtResults.Clear();
                txtResults.AppendText($"User Name           : {userName}\n");
                txtResults.AppendText($"Calculated BMI      : {bmi:N2} kg/m² (via BmiCalculatorLib.dll)\n");
                txtResults.AppendText($"Health Category     : {category} (via HealthAdviceLib.dll)\n");
                txtResults.AppendText($"Ideal Weight Range  : {idealRange.MinWeight:N1} kg - {idealRange.MaxWeight:N1} kg\n");
                txtResults.AppendText($"Clinical Advice     : {advice}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Execution Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}