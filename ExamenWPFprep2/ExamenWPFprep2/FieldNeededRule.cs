using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ExamenWPFprep2
{
    class FieldNeededRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value.ToString().Length == 0)
                return new ValidationResult(false, "Champ obligatoire");
            else
                return ValidationResult.ValidResult;
        }
    }
}
