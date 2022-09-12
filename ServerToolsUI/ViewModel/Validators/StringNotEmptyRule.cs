using System.Windows.Controls;

namespace ServerToolsUI.ViewModel.Validators
{
    public class StringNotEmptyRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (string.IsNullOrEmpty(value.ToString()))
                return new ValidationResult(false, "The field cannot be empty");

            return new ValidationResult(true, null);
        }
    }
}
