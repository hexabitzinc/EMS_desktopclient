using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EMS_DesktopClient.ValidationRules
{
    public class ConfirmPasswordValidationRule : ValidationRule
    {
        public ConfirmPasswordValidationRuleWrapper ConfirmPasswordValidationRuleWrapper { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (this.ConfirmPasswordValidationRuleWrapper is null)
                return ValidationResult.ValidResult;

            if (string.IsNullOrWhiteSpace(this.ConfirmPasswordValidationRuleWrapper.Password))
                return ValidationResult.ValidResult;

            if (this.ConfirmPasswordValidationRuleWrapper.Password != this.ConfirmPasswordValidationRuleWrapper.ConfirmPassword)
                return new ValidationResult(false, "Password does not match.");

            return ValidationResult.ValidResult;
        }
    }
}
