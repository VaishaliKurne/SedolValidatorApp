using SedolValidatorApp.Constant;
using SedolValidatorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SedolValidatorApp
{
   public class SedolValidator : ISedolValidator
    {
        public IValidationResult ValidateSedol(string input)
        {
            var sedol = new SedolChecker(input);

            var result = new ValidationResult
            {
                InputString = input,
                IsUserDefined = false,
                IsValidSedol = false,
                ValidationDetails = null
            };

            if (!sedol.IsValidLength)
            {
                result.ValidationDetails = SedolConstants.INPUT_STRING_NOT_VALID_LENGTH;
                return result;
            }
            if (!sedol.IsAlphaNumeric)
            {
                result.ValidationDetails = SedolConstants.INPUT_STRING_NOT_ALPHANUMERIC;
                return result;
            }
            if (sedol.IsUserDefined)
            {
                result.IsUserDefined = true;
                if (sedol.HasValidCheckDigit)
                {
                    result.IsValidSedol = true;
                    return result;
                }
                result.ValidationDetails = SedolConstants.CHECKSUM_NOT_VALID;
                return result;
            }

            if (sedol.ContainsVowel)
            {
                result.ValidationDetails = SedolConstants.INPUT_STRING_CONTAINS_VOWELS;
                return result;
            }

            if (sedol.HasValidCheckDigit)
                result.IsValidSedol = true;
            else
                result.ValidationDetails = SedolConstants.CHECKSUM_NOT_VALID;

            return result;
        }
    }
}
