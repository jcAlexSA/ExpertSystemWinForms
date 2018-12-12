using ExpertSystemWinForms.Models;
using ExpertSystemWinForms.Models.MembershipFunction;
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

        //private List<TermModel> Terms;

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
            this.fuzzyVariable.Comment = this.textBoxVariableComment.Text;

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

            var ownerWindow = (MainForm)this.Owner;
            ownerWindow.AddVariable(this.fuzzyVariable);
            this.Close();
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

        /// <summary>
        /// Handles the Click event of the ButtonAddTerm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonAddTerm_Click(object sender, EventArgs e)
        {
            var term = new TermModel(this.textBoxTermName.Text.ToString());

            // TODO here factory.

            if (this.comboBoxVariableForm.SelectedItem == null || string.IsNullOrEmpty(term.Name))
            {
                return;
            }

            if (this.comboBoxVariableForm.SelectedItem.Equals("Triangle"))
            {
                // TODO: Make validation for entered values.
                var triangleFunction = new TriangleMembershipFunction
                {
                    Min = Int32.Parse(this.textBoxTriangleLeft.Text),
                    Middle = Int32.Parse(this.textBoxTriangleMiddle.Text),
                    Right = Int32.Parse(this.textBoxTriangleRight.Text)
                };
                term.Function = triangleFunction;
            }
            this.fuzzyVariable.Terms.Add(term);

            this.UpdateListBox();
        }

        /// <summary>
        /// Handles the Click event of the ButtonRemoveTerm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonRemoveTerm_Click(object sender, EventArgs e)
        {
            if (this.listBoxTerms.SelectedIndex < this.listBoxTerms.Items.Count
                && this.fuzzyVariable.Terms.Count > this.listBoxTerms.SelectedIndex)
            {
                this.fuzzyVariable.Terms.RemoveAt(this.listBoxTerms.SelectedIndex);
            }

            this.UpdateListBox();
        }

        /// <summary>
        /// Updates the ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            this.listBoxTerms.Items.Clear();
            this.listBoxTerms.Items.AddRange(this.fuzzyVariable.Terms.Select(p => p.Name).ToArray());
        }

        private void ComboBoxVariableForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxVariableForm.SelectedIndex < 0)
            {
                return;
            }

            if (this.comboBoxVariableForm.SelectedItem as string == "Triangle")
            {
                this.panelTriangle.Visible = true;
                this.panelGauss.Visible = false;
            } 
            else if(this.comboBoxVariableForm.SelectedItem as string == "Gauss")
            {
                this.panelGauss.Visible = true;
                this.panelTriangle.Visible = false;
            }
        }
    }
}
