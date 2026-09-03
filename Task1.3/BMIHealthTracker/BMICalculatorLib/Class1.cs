using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculatorLib
{
    public class BmiCalculator
    {
        // 1. Calculate BMI: weight (kg) / [height (m)]^2
        public static double CalculateBmi(double weightKg, double heightCm)
        {
            double heightM = heightCm / 100.0;
            return weightKg / (heightM * heightM);
        }

        // 2. Calculate Ideal Weight Range (BMI 18.5 to 24.9)
        public static (double MinWeight, double MaxWeight) GetIdealWeightRange(double heightCm)
        {
            double heightM = heightCm / 100.0;
            double min = 18.5 * (heightM * heightM);
            double max = 24.9 * (heightM * heightM);
            return (min, max);
        }
    }
}
