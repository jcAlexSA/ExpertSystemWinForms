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
        /// Gets or sets the fuzzy variables.
        /// </summary>
        /// <value>
        /// The fuzzy variables.
        /// </value>
        public ObservableCollection<FuzzyVariableModel> FuzzyVariables { get; set; } = new ObservableCollection<FuzzyVariableModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.FuzzyVariables.CollectionChanged += FuzzyVariables_CollectionChanged;
        }

        /// <summary>
        /// Handles the CollectionChanged event of the FuzzyVariables control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Collections.Specialized.NotifyCollectionChangedEventArgs"/> instance containing the event data.</param>
        /// <exception cref="NotImplementedException"></exception>
        private void FuzzyVariables_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
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

                // TODO: move this somewhere
                var variableUI = (new FuzzyVariableCreator()).CreateElement(variable.Name);
                this.pictureBox1.Controls.Add(variableUI);
                variableUI.ContextMenuStrip = this.contextMenuStripControl;

                this.treeView1.Nodes["Variables"].Nodes[variable.Type.ToString()].Nodes.Add(variable.Name);
            }
            else
            {
                var index = this.FuzzyVariables.IndexOf(variable);
                this.FuzzyVariables[index] = variable;
            }
        }

        /// <summary>
        /// Sets the updated variable.
        /// </summary>
        /// <param name="variable">The variable.</param>
        /// <param name="index">The index, on that variable exist.</param>
        public void SetVariable(FuzzyVariableModel variable, int index)
        {
            if (this.FuzzyVariables?.Count > index)
            {
                this.FuzzyVariables[index] = variable;
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

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label label = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as Label;

            OpenFuzzyVariableWizardDialog(this.FuzzyVariables.Where(v => v.Name.Equals(label.Text)).FirstOrDefault());
        }

        /// <summary>
        /// Handles the Click event of the newRuleBlockToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NewRuleBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ruleBlockDialog = new RuleBlockWizardDialog(this.FuzzyVariables);
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

        private void RuleBlockEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ruleBlock = new SpredsheetRuleBlockDialog();
            ruleBlock.ShowDialog();
        }
    }
}
