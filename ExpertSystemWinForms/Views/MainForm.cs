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
        }

        /// <summary>
        /// Adds the variable.
        /// </summary>
        /// <param name="variable">The variable.</param>
        public void AddVariable(FuzzyVariableModel variable)
        {
            this.FuzzyVariables.Add(variable);
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
            OpenFuzzyVariableWizardDialog();
        }

        /// <summary>
        /// Handles the Click event of the newRuleBlockToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NewRuleBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ruleBlockDialog = new RuleBlockWizard();
            ruleBlockDialog.ShowDialog();
        }

        /// <summary>
        /// Opens the fuzzy variable wizard dialog.
        /// </summary>
        private static void OpenFuzzyVariableWizardDialog()
        {
            var variableDialog = new FuzzyVariableWizard();
            variableDialog.ShowDialog();
        }

        /// <summary>
        /// Opens the fuzzy variable wizard dialog.
        /// </summary>
        /// <param name="variable">The variable that need to update.</param>
        private static void OpenFuzzyVariableWizardDialog(FuzzyVariableModel variable)
        {
            var variableDialog = new FuzzyVariableWizard(variable);
            variableDialog.ShowDialog();
        }
    }
}
