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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Input");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Output");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Intermediate");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Variables", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Rule Blocks");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRuleBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleBlockEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStripInteractivePanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRuleBlockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleBlockEditorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newVariableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStripInteractivePanel.SuspendLayout();
            this.contextMenuStripControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.newRuleBlockToolStripMenuItem,
            this.ruleBlockEditorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newVariableToolStripMenuItem
            // 
            this.newVariableToolStripMenuItem.Name = "newVariableToolStripMenuItem";
            this.newVariableToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newVariableToolStripMenuItem.Text = "New Variable";
            this.newVariableToolStripMenuItem.Click += new System.EventHandler(this.NewVariableToolStripMenuItem_Click);
            // 
            // newRuleBlockToolStripMenuItem
            // 
            this.newRuleBlockToolStripMenuItem.Name = "newRuleBlockToolStripMenuItem";
            this.newRuleBlockToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newRuleBlockToolStripMenuItem.Text = "New Rule Block";
            this.newRuleBlockToolStripMenuItem.Click += new System.EventHandler(this.NewRuleBlockToolStripMenuItem_Click);
            // 
            // ruleBlockEditorToolStripMenuItem
            // 
            this.ruleBlockEditorToolStripMenuItem.Name = "ruleBlockEditorToolStripMenuItem";
            this.ruleBlockEditorToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ruleBlockEditorToolStripMenuItem.Text = "Rule Block Editor";
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
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(631, 327);
            this.mainPanel.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.Location = new System.Drawing.Point(3, 0);
            this.treeView1.Name = "treeView1";
            treeNode6.Name = "Input";
            treeNode6.Text = "Input";
            treeNode7.Name = "Output";
            treeNode7.Text = "Output";
            treeNode8.Name = "Intermediate";
            treeNode8.Text = "Intermediate";
            treeNode9.Name = "Variables";
            treeNode9.Text = "Variables";
            treeNode10.Name = "RuleBlocks";
            treeNode10.Text = "Rule Blocks";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(158, 327);
            this.treeView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStripInteractivePanel;
            this.pictureBox1.Location = new System.Drawing.Point(164, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(467, 327);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStripInteractivePanel
            // 
            this.contextMenuStripInteractivePanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVariableToolStripMenuItem,
            this.newRuleBlockToolStripMenuItem1,
            this.ruleBlockEditorToolStripMenuItem1});
            this.contextMenuStripInteractivePanel.Name = "contextMenuStripInteractivePanel";
            this.contextMenuStripInteractivePanel.Size = new System.Drawing.Size(164, 70);
            // 
            // addVariableToolStripMenuItem
            // 
            this.addVariableToolStripMenuItem.Name = "addVariableToolStripMenuItem";
            this.addVariableToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addVariableToolStripMenuItem.Text = "New Variable";
            this.addVariableToolStripMenuItem.Click += new System.EventHandler(this.NewVariableToolStripMenuItem_Click);
            // 
            // newRuleBlockToolStripMenuItem1
            // 
            this.newRuleBlockToolStripMenuItem1.Name = "newRuleBlockToolStripMenuItem1";
            this.newRuleBlockToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.newRuleBlockToolStripMenuItem1.Text = "New Rule Block";
            this.newRuleBlockToolStripMenuItem1.Click += new System.EventHandler(this.NewRuleBlockToolStripMenuItem_Click);
            // 
            // ruleBlockEditorToolStripMenuItem1
            // 
            this.ruleBlockEditorToolStripMenuItem1.Name = "ruleBlockEditorToolStripMenuItem1";
            this.ruleBlockEditorToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.ruleBlockEditorToolStripMenuItem1.Text = "Rule Block Editor";
            // 
            // contextMenuStripControl
            // 
            this.contextMenuStripControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVariableToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem});
            this.contextMenuStripControl.Name = "contextMenuStripControl";
            this.contextMenuStripControl.Size = new System.Drawing.Size(162, 70);
            // 
            // newVariableToolStripMenuItem1
            // 
            this.newVariableToolStripMenuItem1.Name = "newVariableToolStripMenuItem1";
            this.newVariableToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.newVariableToolStripMenuItem1.Text = "New Variable";
            this.newVariableToolStripMenuItem1.Click += new System.EventHandler(this.NewVariableToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.editToolStripMenuItem1.Text = "Edit Variable";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.removeToolStripMenuItem.Text = "Remove Variable";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 356);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Expert System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStripInteractivePanel.ResumeLayout(false);
            this.contextMenuStripControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem newVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRuleBlockToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ruleBlockEditorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripInteractivePanel;
        private System.Windows.Forms.ToolStripMenuItem addVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRuleBlockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ruleBlockEditorToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripControl;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVariableToolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

