using ExpertSystemWinForms.Infrastructure;
using ExpertSystemWinForms.Models;
using ExpertSystemWinForms.Models.Interfaces;
using ExpertSystemWinForms.Models.MembershipFunction;
using ExpertSystemWinForms.Views.Dialogs;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        /// <summary>
        /// The project name.
        /// </summary>
        private string fileName = null;

        /// <summary>
        /// The graphics to drawing.
        /// </summary>
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

            // temporary
            InitDefaultProjectStructure();
            // InitDefaultProjectOneIerarchStructure();

            // temporary
            this.Labels.ForEach(lbl => lbl.Move += this.OnUIElementMove);
            this.PanelsRuleBlock.ForEach(p => p.Move += this.OnUIElementMove);
        }

        private void InitDefaultProjectOneIerarchStructure()
        {
            this.FuzzyVariables.Add(new FuzzyVariableModel("i_var1", VariableType.Input, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 5 }),
                new TermModel("medium", new TriangleMembershipFunction() { Left = 0, Middle = 5, Right = 10 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 5, Middle = 10, Right = 10 })
            }, "comment for input 1"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("i_var2", VariableType.Input, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 25 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 0, Middle = 25, Right = 50 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 25, Middle = 50, Right = 50 })
            }, "comment for input 2"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("i_var3", VariableType.Input, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 25 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 0, Middle = 25, Right = 50 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 25, Middle = 50, Right = 50 })
            }, "comment for input 3"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("out_var", VariableType.Output, new List<TermModel>(){
                new TermModel("A1", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 35 }),
                new TermModel("A2", new TriangleMembershipFunction(){ Left = 0, Middle = 35, Right = 70 }),
                new TermModel("B", new TriangleMembershipFunction(){ Left = 35, Middle = 70, Right = 100 }),
                new TermModel("C", new TriangleMembershipFunction(){ Left = 70, Middle = 100, Right = 100 })
            }, "comment for output 1"));

            this.RuleBlocks.Add(new RuleBlockModel("Main_Rule_Block",
                new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Input)),
                new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Output)),
                new Models.RulesModels.RulesModel()));

            this.RuleBlocks.Last().Rules.Rules.Add("i_var1", new List<string> { "low", "low", "low", "low", "low", "low", "low", "low", "low", "medium", "medium", "medium", "medium", "medium", "medium", "medium", "medium", "medium", "high", "high", "high", "high", "high", "high", "high", "high", "high" });
            this.RuleBlocks.Last().Rules.Rules.Add("i_var2", new List<string> { "low", "low", "low", "medium", "medium", "medium", "high", "high", "high", "low", "low", "low", "medium", "medium", "medium", "high", "high", "high", "low", "low", "low", "medium", "medium", "medium", "high", "high", "high" });
            this.RuleBlocks.Last().Rules.Rules.Add("i_var3", new List<string> { "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high" });
            this.RuleBlocks.Last().Rules.Rules.Add("out_var", new List<string> { "A1", "A1", "A2", "A1", "A2", "A2", "A2", "B", "B", "A1", "A2", "A2", "A1", "A2", "B", "B", "B", "C", "A1", "A2", "C", "B", "B", "C", "B", "C", "C" });

        }

        private void InitDefaultProjectStructure()
        {
            // variables set for first ruleBlock.
            this.FuzzyVariables.Add(new FuzzyVariableModel("var1", VariableType.Input, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 50 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 0, Middle = 50, Right = 100 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 50, Middle = 100, Right = 100 })
            }, "comment for input 1"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("var2", VariableType.Input, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 25 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 0, Middle = 25, Right = 50 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 25, Middle = 50, Right = 50 })
            }, "comment for input 2"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("var3", VariableType.Input, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 50 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 0, Middle = 50, Right = 100 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 50, Middle = 100, Right = 100 })
            }, "comment for input 3"));

            // variables set for second ruleBlock.
            this.FuzzyVariables.Add(new FuzzyVariableModel("var4", VariableType.Input, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 40 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 0, Middle = 40, Right = 80 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 40, Middle = 80, Right = 80 })
            }, "comment for input 4"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("var5", VariableType.Input, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 50 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 0, Middle = 50, Right = 100 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 50, Middle = 100, Right = 100 })
            }, "comment for input 5"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("var6", VariableType.Input, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 50 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 0, Middle = 50, Right = 100 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 50, Middle = 100, Right = 100 })
            }, "comment for input 6"));

            // variables set for second ruleBlock.
            this.FuzzyVariables.Add(new FuzzyVariableModel("intermediate_7", VariableType.Intermediate, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 50 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 0, Middle = 50, Right = 100 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 50, Middle = 100, Right = 100 })
            }, "comment for intermediate 7"));
            this.FuzzyVariables.Add(new FuzzyVariableModel("intermediate_8", VariableType.Intermediate, new List<TermModel>()
            {
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 50 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 0, Middle = 50, Right = 100 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 50, Middle = 100, Right = 100 })
            }, "comment for intermediate 8"));

            this.FuzzyVariables.Add(new FuzzyVariableModel("out", VariableType.Output, new List<TermModel>(){
                new TermModel("very_low", new TriangleMembershipFunction(){ Left = 0, Middle = 0, Right = 25 }),
                new TermModel("low", new TriangleMembershipFunction(){ Left = 0, Middle = 25, Right = 50 }),
                new TermModel("medium", new TriangleMembershipFunction(){ Left = 25, Middle = 50, Right = 75 }),
                new TermModel("high", new TriangleMembershipFunction(){ Left = 50, Middle = 75, Right = 100 }),
                new TermModel("very_high", new TriangleMembershipFunction(){ Left = 75, Middle = 100, Right = 100 }),
            }, "comment for output 1"));

            // first rule block
            this.RuleBlocks.Add(new RuleBlockModel("RB_COOPERATION",
                new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Input).Take(3)),
                new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Intermediate).Take(1)),
                new Models.RulesModels.RulesModel()));

            this.RuleBlocks.Last().Rules.Rules.Add("var1", new List<string> { "low", "low", "low", "low", "low", "low", "low", "low", "low", "medium", "medium", "medium", "medium", "medium", "medium", "medium", "medium", "medium", "high", "high", "high", "high", "high", "high", "high", "high", "high" });
            this.RuleBlocks.Last().Rules.Rules.Add("var2", new List<string> { "low", "low", "low", "medium", "medium", "medium", "high", "high", "high", "low", "low", "low", "medium", "medium", "medium", "high", "high", "high", "low", "low", "low", "medium", "medium", "medium", "high", "high", "high", });
            this.RuleBlocks.Last().Rules.Rules.Add("var3", new List<string> { "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", });
            this.RuleBlocks.Last().Rules.Rules.Add("intermediate_7", new List<string> { "low", "low", "medium", "low", "medium", "medium", "medium", "medium", "high", "low", "medium", "medium", "medium", "medium", "high", "medium", "high", "high", "medium", "medium", "high", "medium", "high", "high", "high", "high", "high" });

            // second rule block
            this.RuleBlocks.Add(new RuleBlockModel("RB_CONFESSION",
                new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Input).Skip(3)),
                new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Intermediate).Skip(1)),
                new Models.RulesModels.RulesModel()));

            this.RuleBlocks.Last().Rules.Rules.Add("var4", new List<string> { "low", "low", "low", "low", "low", "low", "low", "low", "low", "medium", "medium", "medium", "medium", "medium", "medium", "medium", "medium", "medium", "high", "high", "high", "high", "high", "high", "high", "high", "high" });
            this.RuleBlocks.Last().Rules.Rules.Add("var5", new List<string> { "low", "low", "low", "medium", "medium", "medium", "high", "high", "high", "low", "low", "low", "medium", "medium", "medium", "high", "high", "high", "low", "low", "low", "medium", "medium", "medium", "high", "high", "high", });
            this.RuleBlocks.Last().Rules.Rules.Add("var6", new List<string> { "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", "low", "medium", "high", });
            this.RuleBlocks.Last().Rules.Rules.Add("intermediate_8", new List<string> { "low", "medium", "medium", "low", "medium", "high", "medium", "medium", "high", "low", "medium", "high", "medium", "medium", "high", "medium", "medium", "high", "low", "medium", "high", "medium", "medium", "high", "medium", "high", "high" });

            // main rule block
            this.RuleBlocks.Add(new RuleBlockModel("RB_RATING",
                 new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Intermediate)),
                 new ObservableCollection<FuzzyVariableModel>(this.FuzzyVariables.Where(v => v.Type == VariableType.Output)),
                 new Models.RulesModels.RulesModel()));

            this.RuleBlocks.Last().Rules.Rules.Add("intermediate_7", new List<string> { "low", "low", "low", "medium", "medium", "medium", "high", "high", "high" });
            this.RuleBlocks.Last().Rules.Rules.Add("intermediate_8", new List<string> { "low", "medium", "high", "low", "medium", "high", "low", "medium", "high" });
            this.RuleBlocks.Last().Rules.Rules.Add("out", new List<string> { "very_low", "low", "medium", "low", "medium", "high", "medium", "high", "very_high" });
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

        /// <summary>
        /// Called when [variable removed]. Removes from rules variable.
        /// </summary>
        /// <param name="fuzzyVariable">The fuzzy variable.</param>
        private void RemoveVariableFromRules(FuzzyVariableModel fuzzyVariable)
        {
            foreach (var rule in this.RuleBlocks.Select(rb => rb.Rules.Rules))
            {
                rule.Remove(fuzzyVariable.Name);
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

                this.RemoveVariableFromRules(fuzzyVariable);
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

        public void OpenInteractiveDebugDialog()
        {
            var debugDialog = new InteractiveDebug(this.RuleBlocks);

            debugDialog.Owner = this;
            debugDialog.ShowDialog();
        }
        #endregion


        #region Actions with project (Invoke when something from FILE_menu choosed)


        private void InteractiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenInteractiveDebugDialog();
        }

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
            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            //    openFileDialog.Filter = "JSON File|*.json";
            //    openFileDialog.RestoreDirectory = true;

            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        //Get the path of specified file
            //        this.fileName = openFileDialog.FileName;

            //        var obj = JsonConvert.DeserializeObject<ObservableCollection<FuzzyVariableModel>>(File.ReadAllText(this.fileName));

            //        // deserialize JSON directly from a file
            //        using (StreamReader file = File.OpenText(this.fileName))
            //        {
            //            JsonSerializer serializer = new JsonSerializer();
            //            var variables = (ObservableCollection<FuzzyVariableModel>)serializer.Deserialize(file, typeof(ObservableCollection<FuzzyVariableModel>));
            //        }
            //    }
            //}
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveProjectToFile(string.IsNullOrEmpty(this.fileName));
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveProjectToFile(true);
        }


        private void SaveProjectToFile(bool saveToNewFile)
        {
            if (saveToNewFile || !(File.Exists(this.fileName)))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Filter = "JSON File|*.json",
                    Title = "Save Project",
                    InitialDirectory = Environment.CurrentDirectory,
                    RestoreDirectory = true
                };
                saveFileDialog.ShowDialog();

                this.fileName = saveFileDialog.FileName;
            }

            JsonSerializer serializer = new JsonSerializer();

            File.WriteAllText(this.fileName, JsonConvert.SerializeObject(this.FuzzyVariables, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto
            }));

            using (var file = File.CreateText(this.fileName))
            {
                serializer.Serialize(file, this.FuzzyVariables);
                serializer.Serialize(file, this.RuleBlocks);

                file.Close();
            }

            this.Text = string.Format($"Expert System - {Path.GetFileName(this.fileName)}");
        }
        public abstract class JsonCreationConverter<T> : JsonConverter
        {
            protected abstract T Create(Type objectType, JObject jObject);

            public override bool CanConvert(Type objectType)
            {
                return typeof(T) == objectType;
            }

            public override object ReadJson(JsonReader reader, Type objectType,
                object existingValue, JsonSerializer serializer)
            {
                try
                {
                    var jObject = JObject.Load(reader);
                    var target = Create(objectType, jObject);
                    serializer.Populate(jObject.CreateReader(), target);
                    return target;
                }
                catch (JsonReaderException)
                {
                    return null;
                }
            }

            public override void WriteJson(JsonWriter writer, object value,
                JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }
        public class AnimalConverter : JsonCreationConverter<IMembershipFunction>
        {
            protected override IMembershipFunction Create(Type objectType, JObject jObject)
            {
                var v = jObject["Type"].Value<IMembershipFunction>();

                //switch ((Constants.AnimalType)jObject["Type"].Value<int>())
                //{
                //    case Constants.AnimalType.Cat:
                //        return new Cat();
                //    case Constants.AnimalType.Dog:
                //        return new Dog();
                //    case Constants.AnimalType.Pig:
                //        return new Pig();
                //}
                return null;
            }
        }
        #endregion
    }
}
