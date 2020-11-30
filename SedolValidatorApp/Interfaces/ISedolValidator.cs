
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SedolValidatorApp.Interfaces
{
   

    /// <summary>
    /// Interface representing SEDOL validator.
    /// </summary>
    public interface ISedolValidator
    {
        /// <summary>
        /// Validates the SEDOL.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>Instance of validation result.</returns>
        IValidationResult ValidateSedol(string input);
    }
}
