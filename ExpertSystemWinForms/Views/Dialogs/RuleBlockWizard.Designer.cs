namespace ExpertSystemWinForms.Views.Dialogs
{
    partial class RuleBlockWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleBlockWizard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxRuleBlockName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonToOutput = new System.Windows.Forms.Button();
            this.buttonToInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxOurputVariablesCollection = new System.Windows.Forms.ListBox();
            this.listBoxInputVariablesCollection = new System.Windows.Forms.ListBox();
            this.listBoxVariablesCollection = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(447, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Define Rule Block Configuration";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(10, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 61);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(22, 120);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(103, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Rule Block Name";
            // 
            // textBoxRuleBlockName
            // 
            this.textBoxRuleBlockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRuleBlockName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRuleBlockName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxRuleBlockName.Location = new System.Drawing.Point(132, 117);
            this.textBoxRuleBlockName.Name = "textBoxRuleBlockName";
            this.textBoxRuleBlockName.Size = new System.Drawing.Size(317, 21);
            this.textBoxRuleBlockName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonRemoveSelected);
            this.groupBox2.Controls.Add(this.buttonToOutput);
            this.groupBox2.Controls.Add(this.buttonToInput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBoxOurputVariablesCollection);
            this.groupBox2.Controls.Add(this.listBoxInputVariablesCollection);
            this.groupBox2.Controls.Add(this.listBoxVariablesCollection);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 173);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.buttonRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveSelected.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveSelected.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRemoveSelected.Location = new System.Drawing.Point(139, 107);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveSelected.TabIndex = 2;
            this.buttonRemoveSelected.Text = "Remove";
            this.buttonRemoveSelected.UseVisualStyleBackColor = false;
            // 
            // buttonToOutput
            // 
            this.buttonToOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.buttonToOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonToOutput.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToOutput.ForeColor = System.Drawing.Color.Teal;
            this.buttonToOutput.Location = new System.Drawing.Point(139, 78);
            this.buttonToOutput.Name = "buttonToOutput";
            this.buttonToOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonToOutput.TabIndex = 2;
            this.buttonToOutput.Text = "Output";
            this.buttonToOutput.UseVisualStyleBackColor = false;
            // 
            // buttonToInput
            // 
            this.buttonToInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(244)))), ((int)(((byte)(219)))));
            this.buttonToInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonToInput.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToInput.ForeColor = System.Drawing.Color.Green;
            this.buttonToInput.Location = new System.Drawing.Point(139, 49);
            this.buttonToInput.Name = "buttonToInput";
            this.buttonToInput.Size = new System.Drawing.Size(75, 23);
            this.buttonToInput.TabIndex = 2;
            this.buttonToInput.Text = "Input";
            this.buttonToInput.UseVisualStyleBackColor = false;
            this.buttonToInput.Click += new System.EventHandler(this.ButtonToInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(367, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(266, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Variables";
            // 
            // listBoxOurputVariablesCollection
            // 
            this.listBoxOurputVariablesCollection.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOurputVariablesCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxOurputVariablesCollection.FormattingEnabled = true;
            this.listBoxOurputVariablesCollection.ItemHeight = 15;
            this.listBoxOurputVariablesCollection.Location = new System.Drawing.Point(338, 33);
            this.listBoxOurputVariablesCollection.Name = "listBoxOurputVariablesCollection";
            this.listBoxOurputVariablesCollection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxOurputVariablesCollection.Size = new System.Drawing.Size(100, 124);
            this.listBoxOurputVariablesCollection.TabIndex = 0;
            // 
            // listBoxInputVariablesCollection
            // 
            this.listBoxInputVariablesCollection.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxInputVariablesCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxInputVariablesCollection.FormattingEnabled = true;
            this.listBoxInputVariablesCollection.ItemHeight = 15;
            this.listBoxInputVariablesCollection.Location = new System.Drawing.Point(232, 33);
            this.listBoxInputVariablesCollection.Name = "listBoxInputVariablesCollection";
            this.listBoxInputVariablesCollection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxInputVariablesCollection.Size = new System.Drawing.Size(100, 124);
            this.listBoxInputVariablesCollection.TabIndex = 0;
            // 
            // listBoxVariablesCollection
            // 
            this.listBoxVariablesCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxVariablesCollection.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxVariablesCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxVariablesCollection.FormattingEnabled = true;
            this.listBoxVariablesCollection.ItemHeight = 15;
            this.listBoxVariablesCollection.Location = new System.Drawing.Point(13, 33);
            this.listBoxVariablesCollection.Name = "listBoxVariablesCollection";
            this.listBoxVariablesCollection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxVariablesCollection.Size = new System.Drawing.Size(100, 124);
            this.listBoxVariablesCollection.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.26513F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.73487F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAccept, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 333);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 29);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.LightGray;
            this.buttonAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(222, 3);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(116, 23);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "OK";
            this.buttonAccept.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightGray;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(344, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // RuleBlockWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxRuleBlockName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "RuleBlockWizard";
            this.Text = "Rule Block Wizard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxRuleBlockName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonToOutput;
        private System.Windows.Forms.Button buttonToInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOurputVariablesCollection;
        private System.Windows.Forms.ListBox listBoxInputVariablesCollection;
        private System.Windows.Forms.ListBox listBoxVariablesCollection;
    }
}