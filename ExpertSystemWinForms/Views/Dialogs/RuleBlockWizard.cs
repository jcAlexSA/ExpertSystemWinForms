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
    public partial class RuleBlockWizard : Form
    {
        private ObservableCollection<FuzzyVariableModel> fuzzyVariables;

        public RuleBlockWizard(ObservableCollection<FuzzyVariableModel> fuzzyVariables)
        {
            InitializeComponent();

            this.fuzzyVariables = fuzzyVariables;
            this.listBoxVariablesCollection.Items.AddRange(this.fuzzyVariables.Select(p => p.Name).ToArray());
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonToInput_Click(object sender, EventArgs e)
        {
            if (this.listBoxInputVariablesCollection.SelectedIndex < 0)
            {
                return;
            }

            
        }
    }
}
