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
    public partial class RulesWizardDialog : Form
    {
        private RuleBlockModel ruleBlock;

        public RulesWizardDialog(RuleBlockModel ruleBlock)
        {
            InitializeComponent();

            this.ruleBlock = ruleBlock;

            foreach (var variable in this.ruleBlock.InputFuzzyVariables)
            {
                Console.WriteLine(variable.Name);

                foreach (var term in variable.Terms)
                {
                    Console.WriteLine($"term {term.Name}, \\t {term.Function.Name}");
                }
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
