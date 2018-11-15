using ExpertSystemWinForms.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemWinForms.Models
{
    /// <summary>
    /// Describe the fuzzy variable.
    /// </summary>
    public class FuzzyVariableModel
    {
        /// <summary>
        /// Gets or sets the name of variable.
        /// </summary>
        /// <value>
        /// The name variable.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of variable.
        /// </summary>
        /// <value>
        /// The type of variable.
        /// </value>
        public VariableType Type { get; set; }

        /// <summary>
        /// Gets or sets the list of terms.
        /// </summary>
        /// <value>
        /// The list of terms.
        /// </value>
        public List<TermModel> Terms { get; set; } = new List<TermModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyVariableModel"/> class.
        /// </summary>
        public FuzzyVariableModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyVariableModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public FuzzyVariableModel(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyVariableModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="variableType">Type of the variable.</param>
        public FuzzyVariableModel(string name, VariableType variableType)
        {
            this.Name = name;
            this.Type = variableType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyVariableModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="variableType">Type of the variable.</param>
        /// <param name="terms">The terms.</param>
        public FuzzyVariableModel(string name, VariableType variableType, List<TermModel> terms)
        {
            this.Name = name;
            this.Type = variableType;
            this.Terms = terms;
        }
    }

    /// <summary>
    /// Variable types.
    /// </summary>
    public enum VariableType
    {
        input,
        output,
        intermediate
    }
}
