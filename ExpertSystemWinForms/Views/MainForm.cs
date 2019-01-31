using ExpertSystemWinForms.Infrastructure;
using ExpertSystemWinForms.Models;
using ExpertSystemWinForms.Views.Dialogs;
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


namespace ExpertSystemWinForms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Represent a collection of labels that correspond to variables.
        /// </summary>
        private List<Control> Labels { get; set; } = new List<Control>();

        /// <summary>
        /// Represent a collection of UI elements that correspond to rule blocks.
        /// Gets or sets the labels rule block.
        /// </summary>
        /// <value>
        /// The labels rule block.
        /// </value>
        private List<Control> LabelsRuleBlock { get; set; } = new List<Control>();

        /// <summary>
        /// Gets or sets the fuzzy variables.
        /// </summary>
        /// <value>
        /// The fuzzy variables.
        /// </value>
        public ObservableCollection<FuzzyVariableModel> FuzzyVariables { get; set; } = new ObservableCollection<FuzzyVariableModel>();
        
        /// <summary>
        /// Gets or sets the rule blocks.
        /// </summary>
        /// <value>
        /// The rule blocks.
        /// </value>
        public ObservableCollection<RuleBlockModel> RuleBlocks { get; set; } = new ObservableCollection<RuleBlockModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.FuzzyVariables.CollectionChanged += FuzzyVariables_CollectionChanged;
            this.RuleBlocks.CollectionChanged += RuleBlocks_CollectionChanged;

            this.FuzzyVariables.Add(new FuzzyVariableModel("i_var1", VariableType.Input, new List<TermModel>(), "asdfasdfasdf"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("i_var2", VariableType.Input, new List<TermModel>(), "adsf"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("mid_var3", VariableType.Intermediate, new List<TermModel>(), "cvx"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("mid_var4", VariableType.Intermediate, new List<TermModel>(), "cv"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("out_var5", VariableType.Output, new List<TermModel>(), "afgh"));
        }

        private void RuleBlocks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    var ruleBlock = (sender as ObservableCollection<RuleBlockModel>)[e.NewStartingIndex];
                    var ruleBlockUI = (new RuleBlockCreator(null, null)).CreateElement(ruleBlock.Name);
                    this.pictureBox1.Controls.Add(ruleBlockUI);
                    this.LabelsRuleBlock.Add(ruleBlockUI);
                    ruleBlockUI.ContextMenuStrip = this.contextMenuStripControl;

                    //this.AddNewVariableToTreeView(ruleBlock);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Adds the new rule block to collection.
        /// </summary>
        /// <param name="ruleBlock">The rule block.</param>
        public void AddRuleBlock(RuleBlockModel ruleBlock)
        {
            if (!this.RuleBlocks.Contains(ruleBlock))
            {
                this.RuleBlocks.Add(ruleBlock);
            }
        }

        /// <summary>
        /// Handles the CollectionChanged event of the FuzzyVariables control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Collections.Specialized.NotifyCollectionChangedEventArgs"/> instance containing the event data.</param>
        private void FuzzyVariables_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    var variable = (sender as ObservableCollection<FuzzyVariableModel>)[e.NewStartingIndex];
                    var variableUI = (new FuzzyVariableCreator()).CreateElement(variable.Name);
                    this.pictureBox1.Controls.Add(variableUI);
                    this.Labels.Add(variableUI);
                    variableUI.ContextMenuStrip = this.contextMenuStripControl;

                    this.AddNewVariableToTreeView(variable);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    // TODO !!!!
                    //var fv = (e.OldItems as List<FuzzyVariableModel>)[0];
                    //var label = this.Labels.FirstOrDefault(v => v.Text.Equals(fv.Name));
                    //this.Labels.Remove(label);
                    //this.pictureBox1.Controls.Remove(label);
                    //this.RemoveOldVariableFromTreeView(fv.Type, fv.Name);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    // TODO: !!!!
                    //variable = (e.NewItems as FuzzyVariableModel);
                    //var labelToUpdate = this.Labels.Where(lbl => (lbl as Label).Text.Equals(oldName)).FirstOrDefault();
                    //labelToUpdate.Text = variable.Name;
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Adds the variable.
        /// </summary>
        /// <param name="variable">The variable.</param>
        public void AddVariable(FuzzyVariableModel variable)
        {
            if (!this.FuzzyVariables.Contains(variable))
            {
                this.FuzzyVariables.Add(variable);
            }
        }

        /// <summary>
        /// Sets the updated variable to collection.
        /// </summary>
        /// <param name="variable">The variable to update.</param>
        /// <param name="oldName">Old name of the variable</param>
        /// <param name="oldType">Type old variable.</param>
        public void SetVariable(FuzzyVariableModel variable, string oldName, VariableType oldType)
        {
            if (this.FuzzyVariables.Contains(variable))
            {
                var index = this.FuzzyVariables.IndexOf(variable);
                this.FuzzyVariables[index] = variable;

                // TODO: move this block to changed_collection event
                var labelToUpdate = this.Labels.Where(lbl => (lbl as Label).Text.Equals(oldName)).FirstOrDefault();
                labelToUpdate.Text = variable.Name;

                this.RemoveOldVariableFromTreeView(oldType, oldName);
                this.AddNewVariableToTreeView(variable);
            }
        }

        /// <summary>
        /// Removes the variable from collection.
        /// </summary>
        /// <param name="variableName">Name of the variable.</param>
        public void RemoveVariable(string variableName)
        {
            var fuzzyVariable = this.FuzzyVariables.Where(v => v.Name.Equals(variableName)).FirstOrDefault();
            if (fuzzyVariable != null)
            {
                this.FuzzyVariables.Remove(fuzzyVariable);
            }

            // TODO: move this block to collection_changed event handler.
            var label = this.Labels.FirstOrDefault(v => v.Text.Equals(variableName));
            this.Labels.Remove(label);
            this.pictureBox1.Controls.Remove(label);

            this.RemoveOldVariableFromTreeView(fuzzyVariable.Type, fuzzyVariable.Name);
        }

        /// <summary>
        /// Add node with variable to tree view.
        /// </summary>
        /// <param name="type">The type of variable and node name.</param>
        /// <param name="name">The name of variable.</param>
        private void AddNewVariableToTreeView(FuzzyVariableModel variable)
        {
            this.treeView1.Nodes["Variables"].Nodes[variable.Type.ToString()].Nodes.Add(variable.Name);
        }

        /// <summary>
        /// Remove node with old variable from tree view.
        /// </summary>
        /// <param name="type">The type of variable and node name.</param>
        /// <param name="name">The name of variable.</param>
        private void RemoveOldVariableFromTreeView(VariableType type, string name)
        {
            var node = this.treeView1.Nodes["Variables"].Nodes[type.ToString()].Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Text.Equals(name));
            if (node != null)
            {
                this.treeView1.Nodes.Remove(node);
            }
        }

        /// <summary>
        /// Handles the Click event of the newVariableToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NewVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool b = sender is ToolStripMenuItem;

            OpenFuzzyVariableWizardDialog();
        }

        /// <summary>
        /// Handles the Click event of the EditToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label label = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as Label;

            OpenFuzzyVariableWizardDialog(this.FuzzyVariables.Where(v => v.Name.Equals(label.Text)).FirstOrDefault());
        }

        /// <summary>
        /// Handles the Click event of the RemoveToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label label = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as Label;

            this.RemoveVariable(label.Text);
        }

        /// <summary>
        /// Handles the Click event of the newRuleBlockToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NewRuleBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ruleBlockDialog = new RuleBlockWizardDialog(this.FuzzyVariables);
            ruleBlockDialog.Owner = this;
            ruleBlockDialog.ShowDialog();
        }

        /// <summary>
        /// Opens the fuzzy variable wizard dialog.
        /// </summary>
        private void OpenFuzzyVariableWizardDialog()
        {
            var variableDialog = new FuzzyVariableWizardDialog();
            variableDialog.Owner = this;
            variableDialog.ShowDialog();
        }

        /// <summary>
        /// Opens the fuzzy variable wizard dialog.
        /// </summary>
        /// <param name="variable">The variable that need to update.</param>
        private void OpenFuzzyVariableWizardDialog(FuzzyVariableModel variable)
        {
            var variableDialog = new FuzzyVariableWizardDialog(variable);
            variableDialog.Owner = this;
            variableDialog.ShowDialog();
        }        

        /// <summary>
        /// Shows the saving offer dialog.
        /// </summary>
        /// <returns>Choosed value.</returns>
        private DialogResult ShowSavingOfferDialog(string text, string caption = "Expert System Dialog")
        {
            var res = MessageBox.Show(text, caption, MessageBoxButtons.YesNo);
            return res;
        }

        #region Actions with project (Invoke when something from FILE_menu choosed)

        /// <summary>
        /// Handles the Click event of the CloseToolStripMenuItem control.
        /// Close main form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Handles the FormClosing event of the MainForm control.
        /// Offers to user save data before closing.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this.ShowSavingOfferDialog("Do you want to exit without saving?") == DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    //TODO: open saving dialog
            //}
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.ShowSavingOfferDialog("Do you want to create new project without saving?") == DialogResult.Yes)
            //{
                
            //}
            //else
            //{
            //    //TODO: open saving dialog
            //}
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.ShowSavingOfferDialog("Open project without saving?") == DialogResult.Yes)
            //{

            //}
            //else
            //{
            //    //TODO: open saving dialog
            //}
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: saving
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: saving to new file
        }

        #endregion
    }
}
