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
                    Console.WriteLine($"term {term.Name}, \t {term.Function.Name}");
                }
                Console.WriteLine("-------------------------------");
            }

            this.BindingDataGridToSource(this.ruleBlock.InputFuzzyVariables.Select(v => new { Name = v.Terms.Select(t => t.Name) } ));
        }

        private void BindingDataGridToSource<T>(IList<T> collection)
        {
            BindingList<T> bindingList = new BindingList<T>(collection);
            var sourceCustomer = new BindingSource(bindingList, null);
            this.dataGridViewRules.DataSource = sourceCustomer;
            this.dataGridViewRules.Refresh();
        }

        private void BindingDataGridToSource(object obj)
        {
            var sourceCustomer = new BindingSource(obj, null);
            this.dataGridViewRules.DataSource = sourceCustomer;

            this.dataGridViewRules.Refresh();
        }
    }
}
