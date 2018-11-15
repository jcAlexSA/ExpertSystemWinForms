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
        public FuzzyVariableWizard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnNext control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedIndex != this.tabControl.TabCount - 1)
            {
                this.tabControl.SelectedIndex++;
            } 
        }

        /// <summary>
        /// Handles the Click event of the btnPrevious control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedIndex != 0)
            {
                this.tabControl.SelectedIndex--;
            }
        }
    }
}
