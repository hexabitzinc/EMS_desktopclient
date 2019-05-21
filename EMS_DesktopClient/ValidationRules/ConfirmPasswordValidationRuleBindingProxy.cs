using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EMS_DesktopClient.ValidationRules
{
    public class ConfirmPasswordValidationRuleBindingProxy : Freezable
    {
        protected override Freezable CreateInstanceCore()
        {
            return new ConfirmPasswordValidationRuleBindingProxy();
        }

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(ConfirmPasswordValidationRuleBindingProxy), new PropertyMetadata(null));
        public string ConfirmPassword
        {
            get { return (string)GetValue(ConfirmPasswordProperty); }
            set { SetValue(ConfirmPasswordProperty, value); }
        }

        public static readonly DependencyProperty ConfirmPasswordProperty =
            DependencyProperty.Register("ConfirmPassword", typeof(string), typeof(ConfirmPasswordValidationRuleBindingProxy), new PropertyMetadata(null));
    }
}
