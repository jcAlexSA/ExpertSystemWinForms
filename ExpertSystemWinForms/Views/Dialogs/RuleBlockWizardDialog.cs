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
        private RuleBlockModel oldRuleBlock;

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
        /// Initializes a new instance of the <see cref="RuleBlockWizardDialog"/> class.
        /// </summary>
        /// <param name="fuzzyVariables">The fuzzy variables.</param>
        /// <param name="ruleBlock">The rule block.</param>
        public RuleBlockWizardDialog(ObservableCollection<FuzzyVariableModel> fuzzyVariables, RuleBlockModel ruleBlock)
        {
            InitializeComponent();

            this.oldRuleBlock = ruleBlock;
            this.newRuleBlock = new RuleBlockModel(this.oldRuleBlock.Name, 
                new ObservableCollection<FuzzyVariableModel>(this.oldRuleBlock.InputFuzzyVariables), 
                new ObservableCollection<FuzzyVariableModel>(this.oldRuleBlock.OutputFuzzyVariables));

            this.textBoxRuleBlockName.Text = this.newRuleBlock.Name;

            this.fuzzyVariables = new ObservableCollection<FuzzyVariableModel>(
                fuzzyVariables.Where(v => !this.newRuleBlock.InputFuzzyVariables.Any(i => i.Name.Equals(v.Name)) 
                                        && !this.newRuleBlock.OutputFuzzyVariables.Any(i => i.Name.Equals(v.Name))));
            this.listBoxVariablesCollection.Items.AddRange(this.fuzzyVariables.Select(p => p.Name).ToArray());
            this.listBoxInputVariablesCollection.Items.AddRange(this.newRuleBlock.InputFuzzyVariables.Select(p => p.Name).ToArray());
            this.listBoxOutputVariablesCollection.Items.AddRange(this.newRuleBlock.OutputFuzzyVariables.Select(p => p.Name).ToArray());
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

            if (this.oldRuleBlock == null )
            {
                owner.AddRuleBlock(this.newRuleBlock);
            }
            else
            {
                string oldName = this.oldRuleBlock.Name;

                this.oldRuleBlock.Name = this.newRuleBlock.Name;
                this.oldRuleBlock.InputFuzzyVariables = this.newRuleBlock.InputFuzzyVariables;
                this.oldRuleBlock.OutputFuzzyVariables = this.newRuleBlock.OutputFuzzyVariables;

                owner.SetRuleBlock(this.oldRuleBlock, oldName);
            }
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the ButtonToInput control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

                this.MoveFuzzyVariableBetweenCollections(variable, this.fuzzyVariables, this.newRuleBlock.InputFuzzyVariables);
                this.MoveItemBetweenListBoxes(selectedIndex, this.listBoxVariablesCollection, this.listBoxInputVariablesCollection);
            }
        }

        /// <summary>
        /// Moves variable to output variables list. Handles the Click event of the ButtonToOutput control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

                this.MoveFuzzyVariableBetweenCollections(variable, this.fuzzyVariables, this.newRuleBlock.OutputFuzzyVariables);
                this.MoveItemBetweenListBoxes(selectedIndex, this.listBoxVariablesCollection, this.listBoxOutputVariablesCollection);
            }
        }

        /// <summary>
        /// Moves Variable AND ListBox Item from input|output to common collection. 
        /// Handles the Click event of the ButtonRemoveSelected control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (this.listBoxInputVariablesCollection.SelectedIndex >= 0)
            {
                var index = this.listBoxInputVariablesCollection.SelectedIndex;

                this.MoveFuzzyVariableBetweenCollections(this.newRuleBlock.InputFuzzyVariables
                    .Where(v => v.Name.Equals(this.listBoxInputVariablesCollection.Items[index])).FirstOrDefault(),
                    this.newRuleBlock.InputFuzzyVariables,
                    this.fuzzyVariables);
                this.MoveItemBetweenListBoxes(index, this.listBoxInputVariablesCollection, this.listBoxVariablesCollection);
            }
            else if (this.listBoxOutputVariablesCollection.SelectedIndex >= 0)
            {
                var index = this.listBoxOutputVariablesCollection.SelectedIndex;

                this.MoveFuzzyVariableBetweenCollections(this.newRuleBlock.OutputFuzzyVariables
                    .Where(v => v.Name.Equals(this.listBoxOutputVariablesCollection.Items[index])).FirstOrDefault(),
                    this.newRuleBlock.OutputFuzzyVariables,
                    this.fuzzyVariables);
                this.MoveItemBetweenListBoxes(index, this.listBoxOutputVariablesCollection, this.listBoxVariablesCollection);
            }
        }

        /// <summary>
        ///  Handles the Click event of the ListBoxVariablesCollection control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ListBoxVariablesCollection_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Moves the item between two list boxes.
        /// </summary>
        /// <param name="item">The item to move.</param>
        /// <param name="listBoxFrom">The listBox from which move.</param>
        /// <param name="listBoxTo">The listBox to which move.</param>
        private void MoveItemBetweenListBoxes(int itemIndex, ListBox listBoxFrom, ListBox listBoxTo)
        {
            listBoxTo.Items.Add(listBoxFrom.Items[itemIndex]);
            listBoxFrom.Items.RemoveAt(itemIndex);
        }

        /// <summary>
        /// Moves the fuzzy variable between two collections.
        /// </summary>
        /// <param name="variable">The variable to move.</param>
        /// <param name="collectionFrom">The collection from which move.</param>
        /// <param name="collectionTo">The collection to which move.</param>
        private void MoveFuzzyVariableBetweenCollections(FuzzyVariableModel variable, ObservableCollection<FuzzyVariableModel> collectionFrom,
            ObservableCollection<FuzzyVariableModel> collectionTo)
        {
            collectionFrom.Remove(variable);
            collectionTo.Add(variable);
        }
    }
}
