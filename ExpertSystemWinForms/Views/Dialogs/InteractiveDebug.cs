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
        /// Initializes a new instance of the <see cref="InteractiveDebug"/> class.
        /// </summary>
        /// <param name="ruleBlocks">The rule blocks.</param>
        public InteractiveDebug(ObservableCollection<RuleBlockModel> ruleBlocks)
        {
            InitializeComponent();

            this.ruleBlocks = ruleBlocks;

            foreach (var variables in this.ruleBlocks.Select(rb => rb.InputFuzzyVariables))
            {
                this.inputVariables.AddRange(variables.Where(v => v.Type == VariableType.Input).ToList());
            }
            this.inputVariables = this.inputVariables.Distinct().ToList();

            foreach (var variables in this.ruleBlocks.Select(rb => rb.OutputFuzzyVariables))
            {
                this.outputVariables.AddRange(variables.Where(v => v.Type == VariableType.Output).ToList());
            }
            this.outputVariables = this.outputVariables.Distinct().ToList();
            
            foreach (var variable in this.inputVariables)
            {
                if (!variable.InputValue.IsSet())
                {
                    variable.CalculateMinimumMaximunValuesForVariable();
                }
            }
                        
            this.SetItemsToListBox(this.listBoxInputVariables, this.inputVariables);
            this.SetItemsToListBox(this.listBoxOutputVariables, this.outputVariables);

            this.CalculateResult();
        }


        /// <summary>
        /// Sets the items to ListBox.
        /// </summary>
        /// <param name="listBox">The list box.</param>
        /// <param name="items">The items.</param>
        private void SetItemsToListBox(ListBox listBox, List<FuzzyVariableModel> items)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(items.Select(v => this.FormatListBoxItem(v.Name, v.InputValue.Value)).ToArray());
        }

        private string FormatListBoxItem(string name, float? value)
        {
            return string.Format($"{name}\t\t{value}");
        }

        private void UpdateListBoxItem(ListBox listBox, int index, string value)
        {
            listBox.Items[index] = value;
        }

        /// <summary>
        /// Handles the click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxInputVariables_Click(object sender, EventArgs e)        // TODO: change this to valueChange
        {
            if (this.listBoxInputVariables.SelectedIndex >= 0)
            {
                string selectedVariableName = this.listBoxInputVariables.SelectedItem.ToString();
                var variable = this.inputVariables.FirstOrDefault(v => selectedVariableName.Contains(v.Name));

                if (variable != null)
                {
                    if (!variable.InputValue.IsSet())
                    {
                        variable.CalculateMinimumMaximunValuesForVariable();
                    }

                    this.numericUpDownInputValue.Minimum = (decimal)variable.InputValue.Min;
                    this.numericUpDownInputValue.Maximum = (decimal)variable.InputValue.Max;
                    this.numericUpDownInputValue.Value = (decimal)variable.InputValue.Value;

                    this.UpdateMinMaxValueLabel((int)this.numericUpDownInputValue.Minimum, (int)this.numericUpDownInputValue.Maximum);
                }
            }
        }
        
        /// <summary>
        /// Updates the min-max values for Label control.
        /// </summary>
        /// <param name="min">The minimun value.</param>
        /// <param name="max">The maximum value.</param>
        private void UpdateMinMaxValueLabel(float min, float max)
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
                var variable = this.inputVariables.FirstOrDefault(v => selectedVariableName.Contains(v.Name));

                if (variable != null)
                {
                    variable.InputValue.Value = (float)this.numericUpDownInputValue.Value;
                    this.UpdateListBoxItem(this.listBoxInputVariables,
                        this.listBoxInputVariables.SelectedIndex,
                        this.FormatListBoxItem(variable.Name, variable.InputValue.Value));

                    this.CalculateResult();
                }
            }
        }

        private void CalculateResult()
        {
            if (this.inputVariables.Any(v => !v.InputValue.IsSet()))
            {
                return;
            }

            foreach (var variable in this.inputVariables)
            {
                foreach (var term in variable.Terms)
                {
                    term.Function.Fuzzificate((float)variable.InputValue.Value);
                }
            }

            // get ordered rules.
            List<List<string>> rules = ruleBlocks[0].Rules.GetRulesAsRows();


            // mamdani || minmax
            Dictionary<string, List<float>> operatorMin = new Dictionary<string, List<float>>();
            foreach (var item in rules.Select(r => r.Last()).Distinct())
            {
                operatorMin.Add(item, new List<float>());
            }

            foreach (var rule in rules)
            {
                // rule 
                for (int i = 0; i < this.inputVariables.Count; i++)
                {
                    var variable = this.inputVariables[i];

                }
            }

        }
    }
}
