using ExpertSystemWinForms.Models;
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
    public partial class RuleBlockWizardDialog : Form
    {
        /// <summary>
        /// The fuzzy variables.
        /// </summary>
        /// TODO!!!! OBSERVABLE_COLLECTION????
        private ObservableCollection<FuzzyVariableModel> fuzzyVariables;

        /// <summary>
        /// The creating rule block.
        /// </summary>
        private RuleBlockModel newRuleBlock;

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleBlockWizardDialog"/> class.
        /// </summary>
        /// <param name="fuzzyVariables">The fuzzy variables.</param>
        public RuleBlockWizardDialog(ObservableCollection<FuzzyVariableModel> fuzzyVariables)
        {
            InitializeComponent();

            this.newRuleBlock = new RuleBlockModel();
            this.fuzzyVariables = new ObservableCollection<FuzzyVariableModel>(fuzzyVariables.ToList());

            this.listBoxVariablesCollection.Items.AddRange(this.fuzzyVariables.Select(p => p.Name).ToArray());
        }

        /// <summary>
        /// Closes dialog. Handles the Click event of the ButtonCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the ButtonAccept control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            this.SendRuleBlock();
        }

        /// <summary>
        /// Sends the rule block to main form.
        /// </summary>
        private void SendRuleBlock()
        {
            if (string.IsNullOrWhiteSpace(this.textBoxRuleBlockName.Text))
            {
                return;
            }

            this.newRuleBlock.Name = this.textBoxRuleBlockName.Text;

            var owner = (MainForm)this.Owner;
            owner.AddRuleBlock(this.newRuleBlock);
            this.Close();
        }

        private void ButtonToInput_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.listBoxVariablesCollection.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= this.fuzzyVariables.Count)
            {
                return;
            }            

            if (this.fuzzyVariables[selectedIndex].Type == VariableType.Input ||
                this.fuzzyVariables[selectedIndex].Type == VariableType.Intermediate)
            {
                var variable = this.fuzzyVariables
                    .FirstOrDefault(v => v.Name.Equals(this.listBoxVariablesCollection.Items[selectedIndex]));
                this.newRuleBlock.InputFuzzyVariables.Add(variable);
                this.fuzzyVariables.Remove(variable);

                this.listBoxInputVariablesCollection.Items.Add(variable.Name);
                this.listBoxVariablesCollection.Items.RemoveAt(selectedIndex);
                this.listBoxVariablesCollection.ClearSelected();
            }
        }

        private void ButtonToOutput_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.listBoxVariablesCollection.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= this.fuzzyVariables.Count)
            {
                return;
            }

            if (this.fuzzyVariables[selectedIndex].Type == VariableType.Output ||
                this.fuzzyVariables[selectedIndex].Type == VariableType.Intermediate)
            {
                var variable = this.fuzzyVariables
                    .FirstOrDefault(v => v.Name.Equals(this.listBoxVariablesCollection.Items[selectedIndex]));
                this.newRuleBlock.OutputFuzzyVariables.Add(variable);
                this.fuzzyVariables.Remove(variable);

                this.listBoxOutputVariablesCollection.Items.Add(variable.Name);
                this.listBoxVariablesCollection.Items.RemoveAt(selectedIndex);
                this.listBoxOutputVariablesCollection.Focus();
                //this.listBoxVariablesCollection.ClearSelected();
            }
        }

        private void ButtonRemoveSelected_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clear select all list Box except selected.
        /// Handles the SelectedIndexChanged event of the ListBoxOutputVariablesCollection control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ListBoxVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).Equals(this.listBoxVariablesCollection))
            {
                this.listBoxInputVariablesCollection.ClearSelected();
                this.listBoxOutputVariablesCollection.ClearSelected();
            }
            else if ((sender as ListBox).Equals(this.listBoxInputVariablesCollection))
            {
                this.listBoxOutputVariablesCollection.ClearSelected();
                this.listBoxVariablesCollection.ClearSelected();
            }
            else if ((sender as ListBox).Equals(this.listBoxOutputVariablesCollection))
            {
                this.listBoxVariablesCollection.ClearSelected();
                this.listBoxInputVariablesCollection.ClearSelected();
            }
        }
    }
}
