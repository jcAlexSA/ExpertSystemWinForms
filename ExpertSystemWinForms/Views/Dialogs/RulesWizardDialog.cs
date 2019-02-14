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
        private string[][] row = new string[6][];

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

            this.dataGridViewRules.ColumnCount = 3;
            this.dataGridViewRules.Columns[0].Name = "ID";
            this.dataGridViewRules.Columns[1].Name = "Name";
            this.dataGridViewRules.Columns[2].Name = "City";

            row[0] = new string[] { "1", "DEvesh omar", "NOIDA" };
            this.dataGridViewRules.Rows.Add(row[0]);

            row[1] = new string[] { "2", "ROLI", "KANPUR" };
            this.dataGridViewRules.Rows.Add(row[1]);

            row[2] = new string[] { "3", "DEVESH", "NOIDA!22" };
            this.dataGridViewRules.Rows.Add(row[2]);

            row[3] = new string[] { "4", "ROLI", "MAINPURI" };
            this.dataGridViewRules.Rows.Add(row[3]);

            //this.BindingDataGridToSource(this.ruleBlock.InputFuzzyVariables.Select(v => new { Name = v.Name, Comm = v.Comment }));
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
            sourceCustomer.AllowNew = true;

            this.dataGridViewRules.DataSource = sourceCustomer;

            this.dataGridViewRules.Refresh();
        }

        private void dataGridViewRules_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(row != null)
            foreach (var r in row)
            {
                Console.WriteLine(r); 
            }
        }
    }
}
