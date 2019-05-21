using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EMS_DesktopClient.ValidationRules
{
    public class OnlyFloatingPointNumbersValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is null)
                return ValidationResult.ValidResult;
            if (string.IsNullOrWhiteSpace(value.ToString()))
                return new ValidationResult(false, "Enter numbers only.");
            if (double.TryParse(value.ToString(), out double temp))
                return ValidationResult.ValidResult;
            return new ValidationResult(false, "Enter numbers only.");
        }
    }
}
