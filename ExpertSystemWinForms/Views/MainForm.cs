using ExpertSystemWinForms.Views.Dialogs;
using System;
using System.Collections.Generic;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void newVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var variableDialog = new FuzzyVariableWizard();
            variableDialog.ShowDialog();
        }

        private void newRuleBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ruleBlockDialog = new RuleBlockWizard();
            ruleBlockDialog.ShowDialog();
        }
    }
}
