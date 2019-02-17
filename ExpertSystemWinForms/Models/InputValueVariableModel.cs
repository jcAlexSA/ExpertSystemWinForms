using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemWinForms.Models
{
    /// <summary>
    /// Represents a model to store the allowed values for current variable.
    /// </summary>
    public class InputValueVariableModel
    {
        /// <summary>
        /// Gets or sets the minimum value for current variable.
        /// </summary>
        /// <value>
        /// The minimum value.
        /// </value>
        public float? Min { get; set; } = null;

        /// <summary>
        /// Gets or sets the maximum of current variable.
        /// </summary>
        /// <value>
        /// The maximum value.
        /// </value>
        public float? Max { get; set; } = null;

        /// <summary>
        /// Gets or sets the input value for current variable.
        /// </summary>
        /// <value>
        /// The input value for current variable.
        /// </value>
        public float? Value { get; set; } = null;

        public InputValueVariableModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputValueVariableModel"/> class.
        /// </summary>
        /// <param name="value">The value of current variable.</param>
        /// <param name="min">The minimum value of current variable.</param>
        /// <param name="max">The maximum value of current variable.</param>
        public InputValueVariableModel(float value, float min, float max)
        {
            this.Value = value;
            this.Min = min;
            this.Max = max;

            this.Validate();
        }

        /// <summary>
        /// Determines whether any of values in instance is set.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if all values is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSet()
        {
            return !(this.Value == null || this.Min == null || this.Max == null);
        }

        /// <summary>
        /// Validates and fixes values if it wrong.
        /// </summary>
        private void Validate()
        {
            if(this.Min > this.Max)
            {
                this.Max = this.Min;
            }

            if(this.Min > this.Value)
            {
                this.Value = this.Min;
            }

            if(this.Value > this.Max)
            {
                this.Max = this.Value;
            }
        }
    }
}
