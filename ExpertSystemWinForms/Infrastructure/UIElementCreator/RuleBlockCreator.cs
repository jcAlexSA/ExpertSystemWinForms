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

        public RuleBlockCreator(List<FuzzyVariableModel> inputFuzzyVariables, List<FuzzyVariableModel> outputFuzzyVariables)
        {
            this.inputFuzzyVariables = inputFuzzyVariables;
            this.outputFuzzyVariables = outputFuzzyVariables;
        }

        /// <summary>
        /// Creates the Rule Block element.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Control CreateElement(string name, Point? location = null)
        {
            Panel panel = new Panel();
            panel.Width = 150;
            panel.Height = 50;
            panel.MinimumSize = new Size(150, 50);
            panel.Name = "panelRuleBlock" + name;

            panel.BackColor = Color.DarkGray;
            panel.ForeColor = Color.DimGray;

            panel.BorderStyle = BorderStyle.None;
            panel.Tag = name;

            panel.Font = new Font("Arial", 8, FontStyle.Bold);
            panel.Location = location ?? new Point(250, 10);

            ControlExtension.Draggable(panel, true);

            Label variable = new Label();

            //variable.BackColor = Color.Gainsboro;
            //variable.ForeColor = Color.DimGray;

            variable.BorderStyle = BorderStyle.FixedSingle;
            variable.Enabled = false;

            variable.Text = name;
            variable.TextAlign = ContentAlignment.TopCenter;
            //variable.Name = "labelRuleBlock" + name;

            //variable.Width = 110;
            //variable.Height = 30;

            //variable.Font = new Font("Arial", 8, FontStyle.Bold);
            //variable.Location = new Point(250, 10);

            variable.Dock = DockStyle.Fill;


            Label variableAggregation = new Label();

            variableAggregation.BorderStyle = BorderStyle.None;
            variableAggregation.Enabled = false;

            variableAggregation.Text = "Min/Max";
            variableAggregation.TextAlign = ContentAlignment.BottomRight;
            //variable.Name = "labelRuleBlock" + name;

            //variable.Width = 110;
            //variable.Height = 30;

            //variable.Font = new Font("Arial", 8, FontStyle.Bold);
            //variable.Location = new Point(250, 10);

            variableAggregation.Dock = DockStyle.Bottom;
            variable.Controls.Add(variableAggregation);

            panel.Controls.Add(variable);

            return panel;
        }
    }
}
