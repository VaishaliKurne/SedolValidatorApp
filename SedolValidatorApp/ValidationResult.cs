using SedolValidatorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SedolValidatorApp
{
  public class ValidationResult : IValidationResult
    {
        public string InputString { get; set; }
        public bool IsValidSedol { get; set; }
        public bool IsUserDefined { get; set; }
        public string ValidationDetails { get; set; }

        public ValidationResult(
          string inputString,
          bool isValidSedol,
          bool isUserDefined,
          string validationDetails)
        {
            InputString = inputString;
            IsValidSedol = isValidSedol;
            IsUserDefined = isUserDefined;
            ValidationDetails = validationDetails;
        }

        public ValidationResult()
        {
        }
    }
}
