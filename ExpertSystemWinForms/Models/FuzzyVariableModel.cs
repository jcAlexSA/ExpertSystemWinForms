using ExpertSystemWinForms.Models.Interfaces;
using ExpertSystemWinForms.Models.MembershipFunction;
using ExpertSystemWinForms.Models.MembershipFunctions;
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
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the list of terms.
        /// </summary>
        /// <value>
        /// The list of terms.
        /// </value>
        public List<TermModel> Terms { get; set; } = new List<TermModel>();

        /// <summary>
        /// Gets or sets the input value.
        /// </summary>
        /// <value>
        /// The input value.
        /// </value>
        public InputValueVariableModel InputValue { get; set; } = new InputValueVariableModel();

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

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyVariableModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="variableType">Type of the variable.</param>
        /// <param name="terms">The terms.</param>
        /// <param name="comment">The comment.</param>
        public FuzzyVariableModel(string name, VariableType variableType, List<TermModel> terms, string comment)
        {
            this.Name = name;
            this.Type = variableType;
            this.Terms = terms;
            this.Comment = comment;
        }

        /// <summary>
        /// Calculates the minimum maximun values for current variable.
        /// </summary>
        public void CalculateMinimumMaximunValuesForVariable()
        {
            int min = 0;
            int max = 0;
            foreach (var term in this.Terms)
            {
                if (term.Function is TriangleMembershipFunction funcTriangle)
                {
                    min = funcTriangle.Left < min ? funcTriangle.Left : min;
                    max = funcTriangle.Right > max ? funcTriangle.Right : max;
                }
                else if (term.Function is GaussMembershipFunction funcGauss)
                {
                    min = (int)(Math.Floor((float)funcGauss.Min) < min ? Math.Floor((float)funcGauss.Min) : min);
                    max = (int)(
                        Math.Round((float)funcGauss.Max, 0, MidpointRounding.AwayFromZero) > max ? 
                        Math.Round((float)funcGauss.Max, 0, MidpointRounding.AwayFromZero) : 
                        max);
                }
            }
            this.InputValue.Min = this.InputValue.Value = min;
            this.InputValue.Max = max;
        }
    }

    /// <summary>
    /// Variable types.
    /// </summary>
    public enum VariableType
    {
        Input,
        Output,
        Intermediate
    }
}
