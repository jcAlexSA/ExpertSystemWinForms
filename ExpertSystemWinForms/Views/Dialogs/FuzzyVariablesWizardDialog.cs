using ExpertSystemWinForms.Models;
using ExpertSystemWinForms.Models.MembershipFunction;
using ExpertSystemWinForms.Models.MembershipFunctions;
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
    public partial class FuzzyVariableWizardDialog : Form
    {
        /// <summary>
        /// The old fuzzy variable that store old data in current dialog.
        /// It should be updated before success editing.
        /// </summary>
        private FuzzyVariableModel oldFuzzyVariable = null;

        /// <summary>
        /// The fuzzy variable that creates in current dialog.
        /// </summary>
        private FuzzyVariableModel newFuzzyVariable;

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyVariableWizard"/> class.
        /// </summary>
        public FuzzyVariableWizardDialog()
        {
            InitializeComponent();

            this.newFuzzyVariable = new FuzzyVariableModel();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyVariableWizard"/> class.
        /// </summary>
        /// <param name="fuzzyVariable">The fuzzy variable.</param>
        public FuzzyVariableWizardDialog(FuzzyVariableModel fuzzyVariable)
        {
            InitializeComponent();

            this.oldFuzzyVariable = fuzzyVariable;
            this.newFuzzyVariable = new FuzzyVariableModel(
                this.oldFuzzyVariable.Name, 
                this.oldFuzzyVariable.Type, 
                this.oldFuzzyVariable.Terms.ToList(), 
                this.oldFuzzyVariable.Comment);

            // Update all fields in dialog according to old Fuzzy Variable.
            this.UpdateListBox();
            this.textBoxVariableName.Text = this.newFuzzyVariable.Name;
            this.textBoxVariableComment.Text = this.newFuzzyVariable.Comment;

            if (this.newFuzzyVariable.Type == VariableType.Input)
            {
                this.radioButtonInputType.Checked = true;
            }
            else if (this.newFuzzyVariable.Type == VariableType.Intermediate)
            {
                this.radioButtonIntermediateType.Checked = true;
            }
            else if (this.newFuzzyVariable.Type == VariableType.Output)
            {
                this.radioButtonOutputType.Checked = true;
            }
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
        /// Save variable as it is. Handles the Click event of the BtnEnd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            SendVariable();
        }

        /// <summary>
        /// Send the variable to main form.
        /// </summary>
        private void SendVariable()
        {
            this.newFuzzyVariable.Name = this.textBoxVariableName.Text;
            this.newFuzzyVariable.Comment = this.textBoxVariableComment.Text;

            if (this.radioButtonInputType.Checked)
            {
                this.newFuzzyVariable.Type = VariableType.Input;
            }
            else if (this.radioButtonIntermediateType.Checked)
            {
                this.newFuzzyVariable.Type = VariableType.Intermediate;
            }
            else if (this.radioButtonOutputType.Checked)
            {
                this.newFuzzyVariable.Type = VariableType.Output;
            }

            var ownerWindow = (MainForm)this.Owner;

            if (this.oldFuzzyVariable != null)
            {
                // update values in old variable.
                string oldName = this.oldFuzzyVariable.Name;
                VariableType oldType = this.oldFuzzyVariable.Type;

                this.oldFuzzyVariable.Name = this.newFuzzyVariable.Name;
                this.oldFuzzyVariable.Comment = this.newFuzzyVariable.Comment;
                this.oldFuzzyVariable.Type = this.newFuzzyVariable.Type;
                this.oldFuzzyVariable.Terms = this.newFuzzyVariable.Terms;

                ownerWindow.SetVariable(this.oldFuzzyVariable, oldName, oldType);
            }
            else
            {
                ownerWindow.AddVariable(this.newFuzzyVariable);
            }
            this.Close();
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
                    Left = Int32.Parse(this.textBoxTriangleLeft.Text),
                    Middle = Int32.Parse(this.textBoxTriangleMiddle.Text),
                    Right = Int32.Parse(this.textBoxTriangleRight.Text)
                };
                term.Function = triangleFunction;
            }
            else if (this.comboBoxVariableForm.SelectedItem.Equals("Gauss"))
            {
                // TODO: Make validation
                var gaussFunction = new GaussMembershipFunction
                {
                    B = Int32.Parse(this.textBoxGaussB.Text),
                    C = Int32.Parse(this.textBoxGaussC.Text)
                };
                term.Function = gaussFunction;
            }

            if (this.newFuzzyVariable.Terms.Any(t => t.Name.Equals(this.textBoxTermName.Text.ToString())))
            {
                int termIndex = this.newFuzzyVariable.Terms.FindIndex(t => t.Name.Equals(this.textBoxTermName.Text));
                this.newFuzzyVariable.Terms[termIndex] = term;
            }
            else
            {
                this.newFuzzyVariable.Terms.Add(term);
            }

            this.ClearTermField();

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
                && this.listBoxTerms.SelectedIndex >= 0)
            {
                this.newFuzzyVariable.Terms.RemoveAt(this.listBoxTerms.SelectedIndex);
                this.ClearTermField();
                this.UpdateListBox();
            }
        }

        /// <summary>
        /// Updates the ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            this.listBoxTerms.Items.Clear();
            this.listBoxTerms.Items.AddRange(this.newFuzzyVariable.Terms.Select(p => p.Name).ToArray());
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ComboBoxVariableForm control.
        /// Displays block depending on what term type selected.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ComboBoxVariableForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDisplayedBlockForTermType();
        }

        /// <summary>
        /// Changes the displayed block depending on term type.
        /// </summary>
        private void ChangeDisplayedBlockForTermType()
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
            else if (this.comboBoxVariableForm.SelectedItem as string == "Gauss")
            {
                this.panelGauss.Visible = true;
                this.panelTriangle.Visible = false;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ListBoxTerms control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ListBoxTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).SelectedIndex >= 0){
                TermModel term = this.newFuzzyVariable.Terms.ElementAt((sender as ListBox).SelectedIndex);

                this.comboBoxVariableForm.SelectedItem = term.Function.Name;
                this.textBoxTermName.Text = term.Name;

                this.UpdateDisplayedBlockFieldValues(term);
            }
        }

        /// <summary>
        /// Updates the fields for the term function.
        /// </summary>
        /// <param name="term">The term.</param>
        private void UpdateDisplayedBlockFieldValues(TermModel term)
        {
            if (term.Function.Name.Equals("Triangle"))
            {
                this.textBoxTriangleLeft.Text = (term.Function as TriangleMembershipFunction).Left.ToString();
                this.textBoxTriangleMiddle.Text = (term.Function as TriangleMembershipFunction).Middle.ToString();
                this.textBoxTriangleRight.Text = (term.Function as TriangleMembershipFunction).Right.ToString();
            }
            else if (term.Function.Name.Equals("Gauss"))
            {
                this.textBoxGaussB.Text = (term.Function as GaussMembershipFunction).B.ToString();
                this.textBoxGaussC.Text = (term.Function as GaussMembershipFunction).C.ToString();
            }
        }

        /// <summary>
        /// Clears the field with term name.
        /// </summary>
        private void ClearTermField()
        {
            this.textBoxTermName.Text = string.Empty;

            // triangle function field.
            this.textBoxTriangleLeft.Text = string.Empty;
            this.textBoxTriangleRight.Text = string.Empty;
            this.textBoxTriangleMiddle.Text = string.Empty;

            //gauss function field.
            this.textBoxGaussB.Text = string.Empty;
            this.textBoxGaussC.Text = string.Empty;
        }

        /// <summary>
        /// Handles the FormClosed event of the FuzzyVariableWizardDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        private void FuzzyVariableWizardDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
