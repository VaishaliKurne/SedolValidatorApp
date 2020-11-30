using System;
using System.Collections.Generic;
using System.Text;

namespace SedolValidatorApp.Constant
{
   public class SedolConstants
    {
        public const string INPUT_STRING_NOT_VALID_LENGTH = "Input string was not 7-characters long.";
        public const string INPUT_STRING_CONTAINS_VOWELS = "Input string contains vowels.";
        public const string INPUT_STRING_NOT_ALPHANUMERIC = "SEDOL contains invalid characters.";
        public const string CHECKSUM_NOT_VALID = "Checksum digit does not agree with the rest of the input.";

    }
}
