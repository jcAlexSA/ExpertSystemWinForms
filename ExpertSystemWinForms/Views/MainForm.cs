﻿using ExpertSystemWinForms.Infrastructure;
using ExpertSystemWinForms.Models;
using ExpertSystemWinForms.Models.MembershipFunction;
using ExpertSystemWinForms.Views.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExpertSystemWinForms
{
    public partial class MainForm : Form
    {
        private Graphics graphics;

        /// <summary>
        /// Represent a collection of labels that correspond to variables.
        /// </summary>
        /// <value>
        /// The labels variables.
        /// </value>
        private List<Control> Labels { get; set; } = new List<Control>();

        /// <summary>
        /// Represent a collection of UI elements that correspond to rule blocks.
        /// Gets or sets the labels rule block.
        /// </summary>
        /// <value>
        /// The panels rule block.
        /// </value>
        private List<Control> PanelsRuleBlock { get; set; } = new List<Control>();

        /// <summary>
        /// Gets or sets the lines that connect UI elements.
        /// </summary>
        /// <value>
        /// The lines.
        /// </value>
        public LinesSet LinesSet { get; set; } = new LinesSet();

        /// <summary>
        /// Gets or sets the fuzzy variables.
        /// </summary>
        /// <value>
        /// The fuzzy variables.
        /// </value>
        public ObservableCollection<FuzzyVariableModel> FuzzyVariables { get; set; } = new ObservableCollection<FuzzyVariableModel>();

        /// <summary>
        /// Gets or sets the rule blocks.
        /// </summary>
        /// <value>
        /// The rule blocks.
        /// </value>
        public ObservableCollection<RuleBlockModel> RuleBlocks { get; set; } = new ObservableCollection<RuleBlockModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.graphics = this.pictureBoxInteractiveUI.CreateGraphics();

            this.FuzzyVariables.CollectionChanged += FuzzyVariables_CollectionChanged;
            this.RuleBlocks.CollectionChanged += RuleBlocks_CollectionChanged;

            this.FuzzyVariables.Add(new FuzzyVariableModel("i_var1", VariableType.Input, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction()),
                new TermModel("middle", new TriangleMembershipFunction() ),
                new TermModel("high", new TriangleMembershipFunction())
            }, "comment for input"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("i_var2", VariableType.Input, new List<TermModel>()
            {
                new TermModel("light", new TriangleMembershipFunction()),
                new TermModel("normal", new TriangleMembershipFunction()),
                new TermModel("hard", new TriangleMembershipFunction())
            }, "comment for input"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("mid_var3", VariableType.Intermediate, new List<TermModel>(), "cvx"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("mid_var4", VariableType.Intermediate, new List<TermModel>(), "cv"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("out_var5", VariableType.Output, new List<TermModel>(){
                new TermModel("positive", new TriangleMembershipFunction()),
                new TermModel("normal", new TriangleMembershipFunction()),
                new TermModel("negative", new TriangleMembershipFunction())
            }, "comment for output"));

            this.RuleBlocks.Add(new RuleBlockModel("rb1",
                new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Input)),
                new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Output))));
            this.RuleBlocks.Add(new RuleBlockModel("rb2",
                new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Input)),
                new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Output || v.Type == VariableType.Intermediate))));

            //temporary
            this.Labels.ForEach(lbl => lbl.Move += this.OnUIElementMove);
            this.PanelsRuleBlock.ForEach(p => p.Move += this.OnUIElementMove);
        }

        /// <summary>
        /// On UI control move event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnUIElementMove(object sender, EventArgs e)
        {
            Control control = (sender as Label);
            control = control ?? (sender as Panel);
            if (control != null)
            {
                this.LinesSet.UpdateLinesCoordinatesAccoringControl(control);   // update lines coordinates.
            }
        }

        /// <summary>
        /// Clears old drawn lines and draw new.
        /// Handles the Paint event of the PictureBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void PictureBoxInteractiveUI_Paint(object sender, PaintEventArgs e)
        {
            this.LinesSet.DrawLines(this.graphics);
        }

        /// <summary>
        /// Adds the lines between variables and rule block.
        /// </summary>
        /// <param name="ruleBlock">The rule block.</param>
        /// <param name="ruleBlockUI">The rule block UI control.</param>
        private void AddLinesBetweenVariablesAndRuleBlock(RuleBlockModel ruleBlock, Control ruleBlockUI)
        {
            foreach (var variable in ruleBlock.InputFuzzyVariables)
            {
                var variableUI = this.Labels.FirstOrDefault(lbl => lbl.Text.Equals(variable.Name));
                if (variableUI != null)
                {
                    this.LinesSet.Lines.Add(new Line(variableUI, ruleBlockUI));
                }
            }
            foreach (var variable in ruleBlock.OutputFuzzyVariables)
            {
                var variableUI = this.Labels.FirstOrDefault(lbl => lbl.Text.Equals(variable.Name));
                if (variableUI != null)
                {
                    this.LinesSet.Lines.Add(new Line(ruleBlockUI, variableUI));
                }
            }
            this.PictureBoxInteractiveUI_Paint(null, null);
        }

        /// <summary>
        /// Creates new pictureBox graphic to allow drawing on a new space.
        /// Handles the Resize event of the PictureBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PictureBoxInteractiveUI_Resize(object sender, EventArgs e)
        {
            this.graphics = pictureBoxInteractiveUI.CreateGraphics();
        }


        #region Rule Blocks
        /// <summary>
        /// Handles the collections event of the RuleBlock control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RuleBlocks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    var ruleBlock = (sender as ObservableCollection<RuleBlockModel>)[e.NewStartingIndex];
                    this.AddNewRuleBlockToTreeView(ruleBlock);

                    var ruleBlockUI = (new RuleBlockCreator(null, null)).CreateElement(ruleBlock.Name);
                    this.pictureBoxInteractiveUI.Controls.Add(ruleBlockUI);
                    this.PanelsRuleBlock.Add(ruleBlockUI);
                    ruleBlockUI.ContextMenuStrip = this.contextMenuStripControlRuleBlock;
                    ruleBlockUI.Move += this.OnUIElementMove;

                    this.AddLinesBetweenVariablesAndRuleBlock(ruleBlock, ruleBlockUI);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Adds the new rule block to collection.
        /// </summary>
        /// <param name="ruleBlock">The rule block.</param>
        public void AddRuleBlock(RuleBlockModel ruleBlock)
        {
            if (!this.RuleBlocks.Contains(ruleBlock))
            {
                this.RuleBlocks.Add(ruleBlock);
            }
        }

        /// <summary>
        /// Updates the rule block in collection.
        /// </summary>
        /// <param name="ruleBlock">The rule block.</param>
        /// <param name="oldName">The old name.</param>
        public void SetRuleBlock(RuleBlockModel ruleBlock, string oldName)
        {
            if (this.RuleBlocks.Contains(ruleBlock))
            {
                // set the ruleBlock in collection to old position.
                var index = this.RuleBlocks.IndexOf(ruleBlock);
                this.RuleBlocks[index] = ruleBlock;

                // update UI panel of ruleBlock.
                var panelToUpdate = this.PanelsRuleBlock.Where(p => (p as Panel).Tag.Equals(oldName)).FirstOrDefault();
                panelToUpdate.Tag = ruleBlock.Name;

                // update ruleBlock node in treeViewNode.
                this.RemoveOldRuleBlockFromTreeView(oldName);
                this.AddNewRuleBlockToTreeView(ruleBlock);

                // update lines for ruleBlock.
                this.LinesSet.RemoveLinesRelativeToElement(panelToUpdate);
                this.AddLinesBetweenVariablesAndRuleBlock(ruleBlock, panelToUpdate);
            }
        }

        /// <summary>
        /// Removes the rule block.
        /// </summary>
        /// <param name="ruleBlockName">Name of the rule block.</param>
        private void RemoveRuleBlock(string ruleBlockName)
        {
            var ruleBlock = this.RuleBlocks.Where(rb => rb.Name.Equals(ruleBlockName)).FirstOrDefault();
            if (ruleBlock != null)
            {
                this.RuleBlocks.Remove(ruleBlock);

                var panel = this.PanelsRuleBlock.Where(rb => (rb as Panel).Tag.Equals(ruleBlockName)).FirstOrDefault();

                this.PanelsRuleBlock.Remove(panel);
                this.pictureBoxInteractiveUI.Controls.Remove(panel);

                this.RemoveOldRuleBlockFromTreeView(ruleBlock.Name);
                this.LinesSet.RemoveLinesRelativeToElement(panel);
            }
        }

        /// <summary>
        /// Handles the CollectionChanged event of the FuzzyVariables control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Collections.Specialized.NotifyCollectionChangedEventArgs"/> instance containing the event data.</param>
        private void FuzzyVariables_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    var variable = (sender as ObservableCollection<FuzzyVariableModel>)[e.NewStartingIndex];
                    var variableUI = (new FuzzyVariableCreator()).CreateElement(variable.Name);
                    this.pictureBoxInteractiveUI.Controls.Add(variableUI);
                    this.Labels.Add(variableUI);
                    variableUI.ContextMenuStrip = this.contextMenuStripControlVariable;
                    variableUI.Move += OnUIElementMove;

                    this.AddNewVariableToTreeView(variable);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    // TODO !!!!
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    // TODO: !!!!
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }
        #endregion


        #region Variables
        /// <summary>
        /// Adds the variable.
        /// </summary>
        /// <param name="variable">The variable.</param>
        public void AddVariable(FuzzyVariableModel variable)
        {
            if (!this.FuzzyVariables.Contains(variable))
            {
                this.FuzzyVariables.Add(variable);
            }
        }

        /// <summary>
        /// Sets the updated variable to collection.
        /// </summary>
        /// <param name="variable">The variable to update.</param>
        /// <param name="oldName">Old name of the variable</param>
        /// <param name="oldType">Type old variable.</param>
        public void SetVariable(FuzzyVariableModel variable, string oldName, VariableType oldType)
        {
            if (this.FuzzyVariables.Contains(variable))
            {
                var index = this.FuzzyVariables.IndexOf(variable);
                this.FuzzyVariables[index] = variable;

                // TODO: move this block to changed_collection event
                var labelToUpdate = this.Labels.Where(lbl => (lbl as Label).Text.Equals(oldName)).FirstOrDefault();
                labelToUpdate.Text = variable.Name;

                this.RemoveOldVariableFromTreeView(oldType, oldName);
                this.AddNewVariableToTreeView(variable);
            }
        }

        /// <summary>
        /// Removes the variable from collection.
        /// </summary>
        /// <param name="variableName">Name of the variable.</param>
        public void RemoveVariable(string variableName)
        {
            var fuzzyVariable = this.FuzzyVariables.Where(v => v.Name.Equals(variableName)).FirstOrDefault();
            if (fuzzyVariable != null)
            {
                this.FuzzyVariables.Remove(fuzzyVariable);
                this.RuleBlocks.ToList().ForEach(rb => { rb.InputFuzzyVariables.Remove(fuzzyVariable); rb.OutputFuzzyVariables.Remove(fuzzyVariable); });

                // TODO: move this block to collection_changed event handler.
                var label = this.Labels.FirstOrDefault(v => v.Text.Equals(variableName));

                this.Labels.Remove(label);
                this.pictureBoxInteractiveUI.Controls.Remove(label);

                this.RemoveOldVariableFromTreeView(fuzzyVariable.Type, fuzzyVariable.Name);
                this.LinesSet.RemoveLinesRelativeToElement(label);
            }

        }
        #endregion


        #region Tree View methods
        /// <summary>
        /// Add node with variable to tree view.
        /// </summary>
        /// <param name="type">The type of variable and node name.</param>
        /// <param name="name">The name of variable.</param>
        private void AddNewVariableToTreeView(FuzzyVariableModel variable)
        {
            this.treeView1.Nodes["Variables"].Nodes[variable.Type.ToString()].Nodes.Add(variable.Name);
        }

        /// <summary>
        /// Remove node with old variable from tree view.
        /// </summary>
        /// <param name="type">The type of variable and node name.</param>
        /// <param name="name">The name of variable.</param>
        private void RemoveOldVariableFromTreeView(VariableType type, string name)
        {
            var node = this.treeView1.Nodes["Variables"].Nodes[type.ToString()].Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Text.Equals(name));
            if (node != null)
            {
                this.treeView1.Nodes.Remove(node);
            }
        }

        /// <summary>
        /// Adds the new rule block to TreeView.
        /// </summary>
        /// <param name="ruleBlock">The rule block.</param>
        private void AddNewRuleBlockToTreeView(RuleBlockModel ruleBlock)
        {
            this.treeView1.Nodes["RuleBlocks"].Nodes.Add(ruleBlock.Name);
        }

        /// <summary>
        /// Removes the old rule block from TreeView.
        /// </summary>
        /// <param name="name">The rule block old name.</param>
        private void RemoveOldRuleBlockFromTreeView(string name)
        {
            var node = this.treeView1.Nodes["RuleBlocks"].Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Text.Equals(name));
            if (node != null)
            {
                this.treeView1.Nodes.Remove(node);
            }
        }
        #endregion


        #region Tool Strip Menu Common
        /// <summary>
        /// Handles the Click event of the newVariableToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NewVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenFuzzyVariableWizardDialog();
        }

        /// <summary>
        /// Handles the Click event of the newRuleBlockToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NewRuleBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenRuleBlockWizardDialog(this.FuzzyVariables);
        }

        /// <summary>
        /// Determines which element was clicked and open corresponding dialog wizard.
        /// Handles the Click event of the EditorToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = ((TreeView)((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl).SelectedNode;

            if (this.FuzzyVariables.Any(v => v.Name.Equals(node.Text)))     // if clicked above variable
            {
                var variable = this.FuzzyVariables.FirstOrDefault(v => v.Name.Equals(node.Text));
                if (variable != null)   // open fuzzy variable wizard dialog on edit
                {
                    this.OpenFuzzyVariableWizardDialog(variable);
                }
            }
            else if (this.RuleBlocks.Any(rb => rb.Name.Equals(node.Text)))  // if clicked above rule block
            {
                var ruleBlock = this.RuleBlocks.FirstOrDefault(rb => rb.Name.Equals(node.Text));
                if (ruleBlock != null)
                {
                    this.OpenRuleBlockWizardDialog(this.FuzzyVariables, ruleBlock);
                }
            }
        }

        /// <summary>
        /// Determines which element was clicked and remove it.
        /// Handles the Click event of the removeToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = ((TreeView)((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl).SelectedNode;

            if (this.FuzzyVariables.Any(v => v.Name.Equals(node.Text)))     // if clicked above variable
            {
                var variable = this.FuzzyVariables.FirstOrDefault(v => v.Name.Equals(node.Text));
                if (variable != null)   // remove variable
                {
                    this.RemoveVariable(variable.Name);
                }
            }
            else if (this.RuleBlocks.Any(rb => rb.Name.Equals(node.Text)))  // if clicked above rule block
            {
                var ruleBlock = this.RuleBlocks.FirstOrDefault(rb => rb.Name.Equals(node.Text));
                if (ruleBlock != null)  // remove rule block
                {
                    this.RemoveRuleBlock(ruleBlock.Name);
                }
            }
        }

        /// <summary>
        /// Handles the MouseDown event of the TreeView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void TreeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Select the clicked node
                treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
            }
        }
        #endregion


        #region Tool Strip Menu Variable
        /// <summary>
        /// Handles the Click event of the EditToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EditVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label label = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as Label;

            this.OpenFuzzyVariableWizardDialog(this.FuzzyVariables.Where(v => v.Name.Equals(label.Text)).FirstOrDefault());
        }

        /// <summary>
        /// Handles the Click event of the RemoveToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RemoveVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label label = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as Label;

            this.RemoveVariable(label.Text);
        }
        #endregion


        #region Tool Strip Menu Rule Block
        /// <summary>
        /// Handles the Click event of the EditRuleBlockToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EditRuleBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as Panel;

            this.OpenRuleBlockWizardDialog(this.FuzzyVariables, this.RuleBlocks.Where(v => v.Name.Equals(panel.Tag)).FirstOrDefault());
        }

        /// <summary>
        /// Handles the Click event of the RemoveToolStripMenuItem control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveRuleBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as Panel;

            this.RemoveRuleBlock(panel.Tag.ToString());
        }


        /// <summary>
        /// Open Rules Wizard Dialog. 
        /// Handles the Click event of the rulesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as Panel;

            this.OpenRulesWizardDialog(this.RuleBlocks.FirstOrDefault(rb => rb.Name.Equals(panel.Tag)));
        }
        #endregion 


        #region Dialogs
        /// <summary>
        /// Opens the Rule Block wizard dialog.
        /// </summary>
        /// <param name="fuzzyVariables"></param>
        /// <param name="ruleBlock"></param>
        private void OpenRuleBlockWizardDialog(ObservableCollection<FuzzyVariableModel> fuzzyVariables, RuleBlockModel ruleBlock = null)
        {
            RuleBlockWizardDialog ruleBlockDialog = null;
            if (ruleBlock == null)  // opens to create
            {
                ruleBlockDialog = new RuleBlockWizardDialog(fuzzyVariables);
            }
            else  // opens to edit
            {
                ruleBlockDialog = new RuleBlockWizardDialog(fuzzyVariables, ruleBlock);
            }
            ruleBlockDialog.Owner = this;
            ruleBlockDialog.ShowDialog();
        }

        /// <summary>
        /// Opens the fuzzy variable wizard dialog.
        /// </summary>
        /// <param name="variable">The variable that need to update.</param>
        private void OpenFuzzyVariableWizardDialog(FuzzyVariableModel variable = null)
        {
            FuzzyVariableWizardDialog variableDialog = null;
            if (variable == null)   // open to create
            {
                variableDialog = new FuzzyVariableWizardDialog();
            }
            else // open to edit
            {
                variableDialog = new FuzzyVariableWizardDialog(variable);
            }
            variableDialog.Owner = this;
            variableDialog.ShowDialog();
        }

        /// <summary>
        /// Shows the saving offer dialog.
        /// </summary>
        /// <returns>Choosed value.</returns>
        private DialogResult ShowSavingOfferDialog(string text, string caption = "Expert System Dialog")
        {
            var res = MessageBox.Show(text, caption, MessageBoxButtons.YesNo);
            return res;
        }

        /// <summary>
        /// Opens the rules wizard dialog.
        /// </summary>
        private void OpenRulesWizardDialog(RuleBlockModel ruleBlock)
        {
            var rulesWizard = new RulesWizardDialog(ruleBlock);

            rulesWizard.Owner = this;
            rulesWizard.ShowDialog();
        }
        #endregion


        #region Actions with project (Invoke when something from FILE_menu choosed)

        /// <summary>
        /// Handles the Click event of the CloseToolStripMenuItem control.
        /// Close main form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Handles the FormClosing event of the MainForm control.
        /// Offers to user save data before closing.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this.ShowSavingOfferDialog("Do you want to exit without saving?") == DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    //TODO: open saving dialog
            //}
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.ShowSavingOfferDialog("Do you want to create new project without saving?") == DialogResult.Yes)
            //{

            //}
            //else
            //{
            //    //TODO: open saving dialog
            //}
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.ShowSavingOfferDialog("Open project without saving?") == DialogResult.Yes)
            //{

            //}
            //else
            //{
            //    //TODO: open saving dialog
            //}
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "JSON File|*.json",
                Title = "Save Project",
                InitialDirectory = Environment.CurrentDirectory,
                RestoreDirectory = true
            };
            saveFileDialog.ShowDialog();

            if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
            {
                var fileName = saveFileDialog.FileName;
                JsonSerializer serializer = new JsonSerializer();

                File.WriteAllText(fileName, JsonConvert.SerializeObject(this.FuzzyVariables));
                using (var file = File.CreateText(fileName))
                {
                    serializer.Serialize(file, this.FuzzyVariables);
                    serializer.Serialize(file, this.RuleBlocks);
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: saving to new file
        }

        #endregion
    }
}
