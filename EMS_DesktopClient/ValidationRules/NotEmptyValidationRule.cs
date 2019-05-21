using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EMS_DesktopClient.ValidationRules
{
    public class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is null)
                return new ValidationResult(false, "This field must be filled in.");
            if (value is System.Windows.Data.BindingExpression)
            {
                System.Windows.Data.BindingExpression binding = value as System.Windows.Data.BindingExpression;
                object dataItem = binding.DataItem;
                string propertyName = binding.ParentBinding.Path.Path;
                object propertyValue = dataItem.GetType().GetProperty(propertyName).GetValue(dataItem, null);
                value = propertyValue;
            }
            return string.IsNullOrWhiteSpace((value ?? "").ToString())
                ? new ValidationResult(false, "This field must be filled in.")
                : ValidationResult.ValidResult;
        }
    }
}
