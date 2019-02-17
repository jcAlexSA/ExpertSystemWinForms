namespace ExpertSystemWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Input");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Output");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Intermediate");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Variables", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Rule Blocks");
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRuleBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRuleBlockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxInteractiveUI = new System.Windows.Forms.PictureBox();
            this.contextMenuStripInteractivePanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newVariableToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newRuleBlockToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripControlVariable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newVariableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripControlRuleBlock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newRuleBlockToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editRuleBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRuleBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.contextMenuStripTreeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInteractiveUI)).BeginInit();
            this.contextMenuStripInteractivePanel.SuspendLayout();
            this.contextMenuStripControlVariable.SuspendLayout();
            this.contextMenuStripControlRuleBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Window;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(651, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVariableToolStripMenuItem,
            this.newRuleBlockToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newVariableToolStripMenuItem
            // 
            this.newVariableToolStripMenuItem.Name = "newVariableToolStripMenuItem";
            this.newVariableToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newVariableToolStripMenuItem.Text = "New Variable";
            this.newVariableToolStripMenuItem.Click += new System.EventHandler(this.NewVariableToolStripMenuItem_Click);
            // 
            // newRuleBlockToolStripMenuItem
            // 
            this.newRuleBlockToolStripMenuItem.Name = "newRuleBlockToolStripMenuItem";
            this.newRuleBlockToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newRuleBlockToolStripMenuItem.Text = "New Rule Block";
            this.newRuleBlockToolStripMenuItem.Click += new System.EventHandler(this.NewRuleBlockToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interactiveToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // interactiveToolStripMenuItem
            // 
            this.interactiveToolStripMenuItem.Name = "interactiveToolStripMenuItem";
            this.interactiveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.interactiveToolStripMenuItem.Text = "Interactive";
            this.interactiveToolStripMenuItem.Click += new System.EventHandler(this.InteractiveToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viewsToolStripMenuItem.Text = "Views";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainPanel.Controls.Add(this.treeView1);
            this.mainPanel.Controls.Add(this.pictureBoxInteractiveUI);
            this.mainPanel.Location = new System.Drawing.Point(0, 26);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(651, 349);
            this.mainPanel.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.ContextMenuStrip = this.contextMenuStripTreeView;
            this.treeView1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.Location = new System.Drawing.Point(2, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Input";
            treeNode1.Text = "Input";
            treeNode2.Name = "Output";
            treeNode2.Text = "Output";
            treeNode3.Name = "Intermediate";
            treeNode3.Text = "Intermediate";
            treeNode4.Name = "Variables";
            treeNode4.Text = "Variables";
            treeNode5.Name = "RuleBlocks";
            treeNode5.Text = "Rule Blocks";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(158, 348);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView1_MouseDown);
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVariableToolStripMenuItem,
            this.newRuleBlockToolStripMenuItem1,
            this.editorToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStripTreeView.Name = "contextMenuStripInteractivePanel";
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(157, 92);
            // 
            // addVariableToolStripMenuItem
            // 
            this.addVariableToolStripMenuItem.Name = "addVariableToolStripMenuItem";
            this.addVariableToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addVariableToolStripMenuItem.Text = "New Variable";
            this.addVariableToolStripMenuItem.Click += new System.EventHandler(this.NewVariableToolStripMenuItem_Click);
            // 
            // newRuleBlockToolStripMenuItem1
            // 
            this.newRuleBlockToolStripMenuItem1.Name = "newRuleBlockToolStripMenuItem1";
            this.newRuleBlockToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.newRuleBlockToolStripMenuItem1.Text = "New Rule Block";
            this.newRuleBlockToolStripMenuItem1.Click += new System.EventHandler(this.NewRuleBlockToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editorToolStripMenuItem.Text = "Edit";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.EditorToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // pictureBoxInteractiveUI
            // 
            this.pictureBoxInteractiveUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxInteractiveUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInteractiveUI.ContextMenuStrip = this.contextMenuStripInteractivePanel;
            this.pictureBoxInteractiveUI.Location = new System.Drawing.Point(164, 0);
            this.pictureBoxInteractiveUI.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxInteractiveUI.Name = "pictureBoxInteractiveUI";
            this.pictureBoxInteractiveUI.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxInteractiveUI.Size = new System.Drawing.Size(486, 348);
            this.pictureBoxInteractiveUI.TabIndex = 1;
            this.pictureBoxInteractiveUI.TabStop = false;
            this.pictureBoxInteractiveUI.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxInteractiveUI_Paint);
            this.pictureBoxInteractiveUI.Resize += new System.EventHandler(this.PictureBoxInteractiveUI_Resize);
            // 
            // contextMenuStripInteractivePanel
            // 
            this.contextMenuStripInteractivePanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStripInteractivePanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVariableToolStripMenuItem2,
            this.newRuleBlockToolStripMenuItem3});
            this.contextMenuStripInteractivePanel.Name = "contextMenuStripInteractivePanel";
            this.contextMenuStripInteractivePanel.Size = new System.Drawing.Size(157, 48);
            // 
            // newVariableToolStripMenuItem2
            // 
            this.newVariableToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newVariableToolStripMenuItem2.Name = "newVariableToolStripMenuItem2";
            this.newVariableToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.newVariableToolStripMenuItem2.Text = "New Variable";
            this.newVariableToolStripMenuItem2.Click += new System.EventHandler(this.NewVariableToolStripMenuItem_Click);
            // 
            // newRuleBlockToolStripMenuItem3
            // 
            this.newRuleBlockToolStripMenuItem3.Name = "newRuleBlockToolStripMenuItem3";
            this.newRuleBlockToolStripMenuItem3.Size = new System.Drawing.Size(156, 22);
            this.newRuleBlockToolStripMenuItem3.Text = "New Rule Block";
            this.newRuleBlockToolStripMenuItem3.Click += new System.EventHandler(this.NewRuleBlockToolStripMenuItem_Click);
            // 
            // contextMenuStripControlVariable
            // 
            this.contextMenuStripControlVariable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVariableToolStripMenuItem1,
            this.editVariableToolStripMenuItem,
            this.removeVariableToolStripMenuItem});
            this.contextMenuStripControlVariable.Name = "contextMenuStripControl";
            this.contextMenuStripControlVariable.Size = new System.Drawing.Size(162, 70);
            // 
            // newVariableToolStripMenuItem1
            // 
            this.newVariableToolStripMenuItem1.Name = "newVariableToolStripMenuItem1";
            this.newVariableToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.newVariableToolStripMenuItem1.Text = "New Variable";
            this.newVariableToolStripMenuItem1.Click += new System.EventHandler(this.NewVariableToolStripMenuItem_Click);
            // 
            // editVariableToolStripMenuItem
            // 
            this.editVariableToolStripMenuItem.Name = "editVariableToolStripMenuItem";
            this.editVariableToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editVariableToolStripMenuItem.Text = "Edit Variable";
            this.editVariableToolStripMenuItem.Click += new System.EventHandler(this.EditVariableToolStripMenuItem_Click);
            // 
            // removeVariableToolStripMenuItem
            // 
            this.removeVariableToolStripMenuItem.Name = "removeVariableToolStripMenuItem";
            this.removeVariableToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.removeVariableToolStripMenuItem.Text = "Remove Variable";
            this.removeVariableToolStripMenuItem.Click += new System.EventHandler(this.RemoveVariableToolStripMenuItem_Click);
            // 
            // contextMenuStripControlRuleBlock
            // 
            this.contextMenuStripControlRuleBlock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRuleBlockToolStripMenuItem2,
            this.editRuleBlockToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.removeRuleBlockToolStripMenuItem});
            this.contextMenuStripControlRuleBlock.Name = "contextMenuStripControlRuleBlock";
            this.contextMenuStripControlRuleBlock.Size = new System.Drawing.Size(176, 92);
            // 
            // newRuleBlockToolStripMenuItem2
            // 
            this.newRuleBlockToolStripMenuItem2.Name = "newRuleBlockToolStripMenuItem2";
            this.newRuleBlockToolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
            this.newRuleBlockToolStripMenuItem2.Text = "New Rule Block";
            this.newRuleBlockToolStripMenuItem2.Click += new System.EventHandler(this.NewRuleBlockToolStripMenuItem_Click);
            // 
            // editRuleBlockToolStripMenuItem
            // 
            this.editRuleBlockToolStripMenuItem.Name = "editRuleBlockToolStripMenuItem";
            this.editRuleBlockToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.editRuleBlockToolStripMenuItem.Text = "Edit Rule Block";
            this.editRuleBlockToolStripMenuItem.Click += new System.EventHandler(this.EditRuleBlockToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.RulesToolStripMenuItem_Click);
            // 
            // removeRuleBlockToolStripMenuItem
            // 
            this.removeRuleBlockToolStripMenuItem.Name = "removeRuleBlockToolStripMenuItem";
            this.removeRuleBlockToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.removeRuleBlockToolStripMenuItem.Text = "Remove Rule Block";
            this.removeRuleBlockToolStripMenuItem.Click += new System.EventHandler(this.RemoveRuleBlockToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 380);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Expert System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.contextMenuStripTreeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInteractiveUI)).EndInit();
            this.contextMenuStripInteractivePanel.ResumeLayout(false);
            this.contextMenuStripControlVariable.ResumeLayout(false);
            this.contextMenuStripControlRuleBlock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem newVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRuleBlockToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxInteractiveUI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem addVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRuleBlockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripControlVariable;
        private System.Windows.Forms.ToolStripMenuItem editVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVariableToolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripControlRuleBlock;
        private System.Windows.Forms.ToolStripMenuItem newRuleBlockToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editRuleBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRuleBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripInteractivePanel;
        private System.Windows.Forms.ToolStripMenuItem newVariableToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newRuleBlockToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interactiveToolStripMenuItem;
    }
}

