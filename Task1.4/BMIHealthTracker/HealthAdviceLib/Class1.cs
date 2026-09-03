using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAdviceLib
{
    public class HealthAdvisor
    {
        // 1. Determine Health Category
        public static string GetCategory(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            if (bmi < 25.0) return "Normal (Healthy Weight)";
            if (bmi < 30.0) return "Overweight";
            return "Obese";
        }

        // 2. Clinical Health Advice
        public static string GetAdvice(double bmi)
        {
            if (bmi < 18.5) return "Caloric and nutritional intake increase recommended.";
            if (bmi < 25.0) return "Maintain current balanced diet and regular physical activity.";
            if (bmi < 30.0) return "Cardiovascular exercise and caloric monitoring advised.";
            return "Consultation with a healthcare professional recommended.";
        }
    }
}
