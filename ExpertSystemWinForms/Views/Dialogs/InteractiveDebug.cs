using ExpertSystemWinForms.Models;
using ExpertSystemWinForms.Models.MembershipFunction;
using ExpertSystemWinForms.Models.MembershipFunctions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystemWinForms.Views.Dialogs
{
    /// <summary>
    /// Represent a debug interactive dialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class InteractiveDebug : Form
    {
        /// <summary>
        /// The rule blocks.
        /// </summary>
        private ObservableCollection<RuleBlockModel> ruleBlocks;

        /// <summary>
        /// The input variables.
        /// </summary>
        private List<FuzzyVariableModel> inputVariables = new List<FuzzyVariableModel>();

        /// <summary>
        /// The output variables.
        /// </summary>
        private List<FuzzyVariableModel> outputVariables = new List<FuzzyVariableModel>();

        /// <summary>
        /// The input values for variables.
        /// </summary>
        private Dictionary<string, InputValueVariableModel> inputValues = new Dictionary<string, InputValueVariableModel>();

        /// <summary>
        /// The output values for variables.
        /// </summary>
        private Dictionary<string, float> outputValues = new Dictionary<string, float>(); 

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractiveDebug"/> class.
        /// </summary>
        /// <param name="ruleBlocks">The rule blocks.</param>
        public InteractiveDebug(ObservableCollection<RuleBlockModel> ruleBlocks)
        {
            InitializeComponent();

            this.ruleBlocks = ruleBlocks;

            foreach (var list in this.ruleBlocks.Select(rb => rb.InputFuzzyVariables))
            {
                this.inputVariables.AddRange(list.Where(v => v.Type == VariableType.Input).ToList());
            }
            this.inputVariables = this.inputVariables.Distinct().ToList();

            foreach (var list in this.ruleBlocks.Select(rb => rb.OutputFuzzyVariables))
            {
                this.outputVariables.AddRange(list.Where(v => v.Type == VariableType.Output).ToList());
            }
            this.outputVariables = this.outputVariables.Distinct().ToList();
            

            // Create dictionary with input values.
            foreach (var item in this.inputVariables)
            {
                this.inputValues.Add(item.Name, new InputValueVariableModel());
            }
            // Create dictionary with output values.
            foreach (var item in this.outputVariables)
            {
                this.outputValues.Add(item.Name, 0);
            }
            
            this.SetItemsToListBox(this.listBoxInputVariables, this.inputVariables);
            this.SetItemsToListBox(this.listBoxOutputVariables, this.outputVariables);
        }


        /// <summary>
        /// Sets the items to ListBox.
        /// </summary>
        /// <param name="listBox">The list box.</param>
        /// <param name="items">The items.</param>
        private void SetItemsToListBox(ListBox listBox, List<FuzzyVariableModel> items)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(items.Select(v => v.Name).ToArray());
        }

        /// <summary>
        /// Handles the click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxInputVariables_Click(object sender, EventArgs e)
        {
            if (this.listBoxInputVariables.SelectedIndex >= 0)
            {
                string selectedVariableName = this.listBoxInputVariables.SelectedItem.ToString();
                var variable = this.inputVariables.FirstOrDefault(v => v.Name.Equals(selectedVariableName));

                if (variable != null)
                {
                    if (!this.inputValues[variable.Name].IsSet())
                    {
                        InputValueVariableModel inputs = this.CalculateMinimumMaximunValuesForVariable(variable);
                        this.inputValues[variable.Name] = inputs;
                    }

                    this.numericUpDownInputValue.Minimum = (decimal)this.inputValues[variable.Name].Min;
                    this.numericUpDownInputValue.Maximum = (decimal)this.inputValues[variable.Name].Max;
                    this.numericUpDownInputValue.Value = (decimal)this.inputValues[variable.Name].Value;

                    this.UpdateMinMaxValue((int)this.numericUpDownInputValue.Minimum, (int)this.numericUpDownInputValue.Maximum);
                }
            }
        }


        private InputValueVariableModel CalculateMinimumMaximunValuesForVariable(FuzzyVariableModel variable)
        {
            var inputs = new InputValueVariableModel();

            int min = 0;
            int max = 0;
            foreach (var term in variable.Terms)
            {
                if (term.Function is TriangleMembershipFunction funcTriangle)
                {
                    min = funcTriangle.Left < min ? funcTriangle.Left : min;
                    max = funcTriangle.Right > max ? funcTriangle.Right : max;
                }
                else if (term.Function is GaussMembershipFunction funcGauss)
                {
                    min = (int)(Math.Floor((float)funcGauss.Min) < min ? Math.Floor((float)funcGauss.Min) : min);
                    max = (int)(Math.Round((float)funcGauss.Max, 0, MidpointRounding.AwayFromZero) > max ? Math.Round((float)funcGauss.Max, 0, MidpointRounding.AwayFromZero) : max);
                }
            }
            inputs.Min = inputs.Value = min;
            inputs.Max = max;

            return inputs;
        }

        /// <summary>
        /// Updates the min-max values for label.
        /// </summary>
        /// <param name="min">The minimun value.</param>
        /// <param name="max">The maximum value.</param>
        private void UpdateMinMaxValue(float min, float max)
        {
            this.labelMinMax.Text = string.Format($"x: [{min}; {max}]");
        }

        /// <summary>
        /// Handles on click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericUpDownInputValue_ValueChanged(object sender, EventArgs e)
        {
            if (this.listBoxInputVariables.SelectedIndex >= 0)
            {
                string selectedVariableName = this.listBoxInputVariables.SelectedItem.ToString();
                var variable = this.inputVariables.FirstOrDefault(v => v.Name.Equals(selectedVariableName));

                if (variable != null)
                {
                    this.inputValues[variable.Name].Value = (float)this.numericUpDownInputValue.Value;
                }
            }
        }
    }
}
