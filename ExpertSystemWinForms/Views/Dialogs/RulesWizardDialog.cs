using ExpertSystemWinForms.Models;
using ExpertSystemWinForms.Models.MembershipFunction;
using ExpertSystemWinForms.Models.RulesModels;
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

        private RulesModel rules;

        public RulesWizardDialog(RuleBlockModel ruleBlock)
        {
            InitializeComponent();

            this.ruleBlock = ruleBlock;

            if (this.ruleBlock.Rules == null)
            {
                rules = new RulesModel();
            }
            else
            {
                rules = this.ruleBlock.Rules;
            }

            this.AddColumnsAndCreateCellTemplates(this.rules, this.ruleBlock.InputFuzzyVariables, this.ruleBlock.OutputFuzzyVariables);

            this.SetRulesToDataGrid(this.rules);
        }
        
        private void AddColumnsAndCreateCellTemplates(RulesModel rules, ICollection<FuzzyVariableModel> inputVariables, ICollection<FuzzyVariableModel> ourputVariables)
        {
            foreach (var variable in inputVariables.Concat(ourputVariables))
            {
                var col = new DataGridViewComboBoxColumn        // TODO: here could be call an interface method
                {
                    Name = variable.Name,
                    DataSource = variable.Terms.Select(t => t.Name).ToList(),
                    ValueType = typeof(string)
                };
                this.dataGridViewRules.Columns.Add(col);
            }
            this.dataGridViewRules.Columns[inputVariables.Count - 1].DividerWidth = 3;  // width = 3px
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.UpdateRulesFromDataGrid(this.rules);

            this.Close();
        }

        private void SetRulesToDataGrid(RulesModel rules)
        {

            //int index = 0;
            foreach (var rule in rules.Rules)
            {
                for (int i = 0; i < rule.Value.Count; i++)
                {
                    if (this.dataGridViewRules.Rows.Count == rule.Value.Count)
                        this.dataGridViewRules.Rows.Add();

                    this.dataGridViewRules[rule.Key, i].Value = rule.Value[i];
                    //++index;
                }
            }
        }

        private void UpdateRulesFromDataGrid(RulesModel rules)
        {
            List<string> values = null;
            for (int i = 0; i < this.dataGridViewRules.ColumnCount; i++)
            {
                values = new List<string>();
                for (int j = 0; j < this.dataGridViewRules.RowCount - 1; j++)
                {
                    values.Add(this.dataGridViewRules[i, j].Value.ToString());
                }
                this.rules.Rules.Add(this.dataGridViewRules.Columns[i].Name.ToString(), values);
            }
            this.ruleBlock.Rules = this.rules;
        }
    }
}
