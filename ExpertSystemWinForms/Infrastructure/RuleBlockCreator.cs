using ExpertSystemWinForms.Infrastructure.Interfaces;
using ExpertSystemWinForms.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystemWinForms.Infrastructure
{
    /// <summary>
    /// Represent a Rule Block UI creator.
    /// </summary>
    /// <seealso cref="ExpertSystemWinForms.Infrastructure.Interfaces.IUserControlCreator" />
    public class RuleBlockCreator : IUserControlCreator
    {
        private string name;

        private List<FuzzyVariableModel> inputFuzzyVariables;

        private List<FuzzyVariableModel> outputFuzzyVariables;

        public RuleBlockCreator(string name, 
            List<FuzzyVariableModel> inputFuzzyVariables, 
            List<FuzzyVariableModel> outputFuzzyVariables)
        {
            this.name = name;
            this.inputFuzzyVariables = inputFuzzyVariables;
            this.outputFuzzyVariables = outputFuzzyVariables;
        }

        /// <summary>
        /// Creates the Rule Block element.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Control CreateElement(string name)
        {
            Label variable = new Label();

            variable.BackColor = Color.Gainsboro;
            variable.ForeColor = Color.DimGray;

            variable.BorderStyle = BorderStyle.FixedSingle;

            variable.Text = name;
            variable.Name = "lableRuleBlock" + name;

            variable.Width = 110;
            variable.Height = 30;

            variable.Font = new Font("Arial", 8, FontStyle.Bold);
            variable.Location = new Point(250, 10);

            ControlExtension.Draggable(variable, true);

            return variable;
        }
    }
}
