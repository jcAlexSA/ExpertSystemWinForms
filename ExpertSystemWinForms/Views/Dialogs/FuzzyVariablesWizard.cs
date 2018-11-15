using ExpertSystemWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystemWinForms.Views.Dialogs
{
    public partial class FuzzyVariableWizard : Form
    {
        private bool isNewVariableAdding;

        private FuzzyVariableModel fuzzyVariable;

        private List<TermModel> Terms;

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyVariableWizard"/> class.
        /// </summary>
        public FuzzyVariableWizard() : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyVariableWizard"/> class.
        /// </summary>
        /// <param name="fuzzyVariable">The fuzzy variable.</param>
        public FuzzyVariableWizard(FuzzyVariableModel fuzzyVariable)
        {
            InitializeComponent();

            this.fuzzyVariable = fuzzyVariable ?? new FuzzyVariableModel();

            this.isNewVariableAdding = fuzzyVariable == null;       // if null, then new variable creating.
        }

        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnNext control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            // move to next tab
            if (this.tabControl.SelectedIndex != this.tabControl.TabCount - 1)
            {
                this.tabControl.SelectedIndex++;
            }
            // save variable
            else if (this.tabControl.SelectedIndex == this.tabControl.TabCount - 1)
            {
                SendVariable();
            }
        }

        /// <summary>
        /// Send the variable to main form.
        /// </summary>
        private void SendVariable()
        {
            this.fuzzyVariable.Name = this.textBoxVariableName.Text;

            if (this.radioButtonInputType.Checked)
            {
                this.fuzzyVariable.Type = VariableType.input;
            }
            else if (this.radioButtonIntermediateType.Checked)
            {
                this.fuzzyVariable.Type = VariableType.intermediate;
            }
            else if (this.radioButtonOutputType.Checked)
            {
                this.fuzzyVariable.Type = VariableType.output;
            }

        }

        /// <summary>
        /// Handles the Click event of the btnPrevious control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedIndex != 0)
            {
                this.tabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the TabControl control. Change 'next button' name 
        /// and save fuzzy variable if user on the last column.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedIndex == this.tabControl.TabCount - 1)
            {
                this.btnNext.Text = "Save";
            }
            else
            {
                if (this.btnNext.Text.Equals("Save"))
                {
                    this.btnNext.Text = "Next";
                }
            }
        }
    }
}
