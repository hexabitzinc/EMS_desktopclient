using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EMS_DesktopClient.ValidationRules
{
    public class ConfirmPasswordValidationRuleWrapper : DependencyObject
    {
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string),
            typeof(ConfirmPasswordValidationRuleWrapper), new FrameworkPropertyMetadata(""));

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }
        public static readonly DependencyProperty ConfirmPasswordProperty =
            DependencyProperty.Register("ConfirmPassword", typeof(string),
            typeof(ConfirmPasswordValidationRuleWrapper), new FrameworkPropertyMetadata(""));

        public string ConfirmPassword
        {
            get { return (string)GetValue(ConfirmPasswordProperty); }
            set { SetValue(ConfirmPasswordProperty, value); }
        }
    }
}
