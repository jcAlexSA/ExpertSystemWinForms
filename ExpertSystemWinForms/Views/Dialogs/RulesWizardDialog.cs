using ExpertSystemWinForms.Models;
using ExpertSystemWinForms.Models.RulesModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            this.AddColumnsAndCreateItsCellTemplatesIntoDataGrid(this.rules, this.ruleBlock.InputFuzzyVariables, this.ruleBlock.OutputFuzzyVariables);

            this.SetRulesToDataGrid(this.rules);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            // Check on validity.
            if (this.IsRulesInvalideInDataGrid())
            {
                var dialogResult = MessageBox.Show("You must fill the rows completely.\nUnfilled rules will not be saved!\nContinue to fill rules?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                {
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.RemoveInvalidRulesFromDataGrid();
                }
            }

            this.GetRulesFromDataGrid(this.rules);
            // save rules into ruleBlock
            this.ruleBlock.Rules = rules;
            this.Close();
        }

        #region Data grid logic
        /// <summary>
        /// Add columns and create templates for them using variable's term.
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="inputVariables"></param>
        /// <param name="ourputVariables"></param>
        private void AddColumnsAndCreateItsCellTemplatesIntoDataGrid(RulesModel rules, ICollection<FuzzyVariableModel> inputVariables, ICollection<FuzzyVariableModel> ourputVariables)
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

        private bool IsRulesInvalideInDataGrid()
        {
            for (int i = 0; i < this.dataGridViewRules.ColumnCount; i++)
            {
                for (int j = 0; j < this.dataGridViewRules.RowCount - 1; j++)
                {
                    if (this.dataGridViewRules[i, j].Value == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void RemoveInvalidRulesFromDataGrid()
        {
            var invalideIndexes = new List<int>();

            for (int i = 0; i < this.dataGridViewRules.ColumnCount; i++)
            {
                for (int j = 0; j < this.dataGridViewRules.RowCount - 1; j++)
                {
                    if (this.dataGridViewRules[i,j].Value == null && !invalideIndexes.Contains(j))
                    {
                        invalideIndexes.Add(j);
                    }
                }
            }
            foreach (var index in invalideIndexes)
            {
                this.dataGridViewRules.Rows.RemoveAt(index);
            }
        }

        private void SetRulesToDataGrid(RulesModel rules)
        {
            if (rules.Rules.Any(r => r.Value.Count > this.dataGridViewRules.RowCount))
            {
                this.dataGridViewRules.Rows.Add(rules.Rules.Select(r => r.Value.Count).FirstOrDefault());
            }

            foreach (var ruleItem in rules.Rules) // dictionary <string, List<string>>
            {
                for (int i = 0; i < ruleItem.Value.Count; i++)
                {
                    this.dataGridViewRules[ruleItem.Key, i].Value = ruleItem.Value[i];
                }
            }
        }

        private void GetRulesFromDataGrid(RulesModel rules)
        {
            List<string> values = null;
            for (int i = 0; i < this.dataGridViewRules.ColumnCount; i++)
            {
                values = new List<string>();
                for (int j = 0; j < this.dataGridViewRules.RowCount - 1; j++)
                {
                    values.Add(this.dataGridViewRules[i, j].Value?.ToString());
                }
                // rewrites values or creates new one.
                if (this.rules.Rules.ContainsKey(this.dataGridViewRules.Columns[i].Name))
                {
                    rules.Rules[this.dataGridViewRules.Columns[i].Name] = values;
                }
                else
                {
                    rules.Rules.Add(this.dataGridViewRules.Columns[i].Name.ToString(), values);
                }
            }
        }

        #endregion
    }
}
