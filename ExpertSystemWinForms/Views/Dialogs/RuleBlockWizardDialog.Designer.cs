namespace ExpertSystemWinForms.Views.Dialogs
{
    partial class RuleBlockWizardDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleBlockWizardDialog));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxRuleBlockName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxVariablesCollection = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonToInput = new System.Windows.Forms.Button();
            this.buttonToOutput = new System.Windows.Forms.Button();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.listBoxOutputVariablesCollection = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxInputVariablesCollection = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonCriteriaMimMax = new System.Windows.Forms.RadioButton();
            this.radioButtonCriteriaProd = new System.Windows.Forms.RadioButton();
            this.radioButtonCriteriaMean = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(431, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Define Rule Block Configuration";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 59);
            this.label4.TabIndex = 0;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(32, 109);
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
            this.textBoxRuleBlockName.Location = new System.Drawing.Point(160, 106);
            this.textBoxRuleBlockName.Name = "textBoxRuleBlockName";
            this.textBoxRuleBlockName.Size = new System.Drawing.Size(279, 21);
            this.textBoxRuleBlockName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(14, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 196);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.30241F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.02062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxVariablesCollection, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.listBoxOutputVariablesCollection, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxInputVariablesCollection, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(425, 176);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(322, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxVariablesCollection
            // 
            this.listBoxVariablesCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxVariablesCollection.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxVariablesCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxVariablesCollection.FormattingEnabled = true;
            this.listBoxVariablesCollection.ItemHeight = 15;
            this.listBoxVariablesCollection.Location = new System.Drawing.Point(3, 18);
            this.listBoxVariablesCollection.Name = "listBoxVariablesCollection";
            this.listBoxVariablesCollection.Size = new System.Drawing.Size(96, 228);
            this.listBoxVariablesCollection.TabIndex = 5;
            this.listBoxVariablesCollection.Tag = "AllVariables";
            this.listBoxVariablesCollection.Click += new System.EventHandler(this.ListBoxVariablesCollection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(215, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonToInput);
            this.panel1.Controls.Add(this.buttonToOutput);
            this.panel1.Controls.Add(this.buttonRemoveSelected);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(105, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 228);
            this.panel1.TabIndex = 0;
            // 
            // buttonToInput
            // 
            this.buttonToInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonToInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(244)))), ((int)(((byte)(219)))));
            this.buttonToInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonToInput.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToInput.ForeColor = System.Drawing.Color.Green;
            this.buttonToInput.Location = new System.Drawing.Point(7, 110);
            this.buttonToInput.Name = "buttonToInput";
            this.buttonToInput.Size = new System.Drawing.Size(90, 26);
            this.buttonToInput.TabIndex = 11;
            this.buttonToInput.Text = "Input";
            this.buttonToInput.UseVisualStyleBackColor = false;
            this.buttonToInput.Click += new System.EventHandler(this.ButtonToInput_Click);
            // 
            // buttonToOutput
            // 
            this.buttonToOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonToOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.buttonToOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonToOutput.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToOutput.ForeColor = System.Drawing.Color.Teal;
            this.buttonToOutput.Location = new System.Drawing.Point(7, 38);
            this.buttonToOutput.Name = "buttonToOutput";
            this.buttonToOutput.Size = new System.Drawing.Size(90, 26);
            this.buttonToOutput.TabIndex = 10;
            this.buttonToOutput.Text = "Output";
            this.buttonToOutput.UseVisualStyleBackColor = false;
            this.buttonToOutput.Click += new System.EventHandler(this.ButtonToOutput_Click);
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.buttonRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveSelected.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveSelected.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRemoveSelected.Location = new System.Drawing.Point(7, 75);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(90, 26);
            this.buttonRemoveSelected.TabIndex = 9;
            this.buttonRemoveSelected.Text = "Remove";
            this.buttonRemoveSelected.UseVisualStyleBackColor = false;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.ButtonRemoveSelected_Click);
            // 
            // listBoxOutputVariablesCollection
            // 
            this.listBoxOutputVariablesCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOutputVariablesCollection.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOutputVariablesCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxOutputVariablesCollection.FormattingEnabled = true;
            this.listBoxOutputVariablesCollection.ItemHeight = 15;
            this.listBoxOutputVariablesCollection.Location = new System.Drawing.Point(322, 18);
            this.listBoxOutputVariablesCollection.Name = "listBoxOutputVariablesCollection";
            this.listBoxOutputVariablesCollection.Size = new System.Drawing.Size(100, 228);
            this.listBoxOutputVariablesCollection.TabIndex = 3;
            this.listBoxOutputVariablesCollection.Tag = "OutputVariables";
            this.listBoxOutputVariablesCollection.Click += new System.EventHandler(this.ListBoxVariablesCollection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Variables";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxInputVariablesCollection
            // 
            this.listBoxInputVariablesCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInputVariablesCollection.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxInputVariablesCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxInputVariablesCollection.FormattingEnabled = true;
            this.listBoxInputVariablesCollection.ItemHeight = 15;
            this.listBoxInputVariablesCollection.Location = new System.Drawing.Point(215, 18);
            this.listBoxInputVariablesCollection.Name = "listBoxInputVariablesCollection";
            this.listBoxInputVariablesCollection.Size = new System.Drawing.Size(101, 228);
            this.listBoxInputVariablesCollection.TabIndex = 4;
            this.listBoxInputVariablesCollection.Tag = "InputVariables";
            this.listBoxInputVariablesCollection.Click += new System.EventHandler(this.ListBoxVariablesCollection_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.26513F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.73487F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAccept, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 442);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 28);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.LightGray;
            this.buttonAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(186, 3);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(95, 22);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "OK";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightGray;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(287, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(169, 22);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(17, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 104);
            this.panel2.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonCriteriaMean);
            this.groupBox3.Controls.Add(this.radioButtonCriteriaProd);
            this.groupBox3.Controls.Add(this.radioButtonCriteriaMimMax);
            this.groupBox3.Location = new System.Drawing.Point(77, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 98);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Norms";
            // 
            // radioButtonCriteriaMimMax
            // 
            this.radioButtonCriteriaMimMax.AutoSize = true;
            this.radioButtonCriteriaMimMax.Checked = true;
            this.radioButtonCriteriaMimMax.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCriteriaMimMax.Location = new System.Drawing.Point(9, 20);
            this.radioButtonCriteriaMimMax.Name = "radioButtonCriteriaMimMax";
            this.radioButtonCriteriaMimMax.Size = new System.Drawing.Size(70, 18);
            this.radioButtonCriteriaMimMax.TabIndex = 0;
            this.radioButtonCriteriaMimMax.Text = "MINMAX";
            this.radioButtonCriteriaMimMax.UseVisualStyleBackColor = true;
            // 
            // radioButtonCriteriaProd
            // 
            this.radioButtonCriteriaProd.AutoSize = true;
            this.radioButtonCriteriaProd.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCriteriaProd.Location = new System.Drawing.Point(9, 44);
            this.radioButtonCriteriaProd.Name = "radioButtonCriteriaProd";
            this.radioButtonCriteriaProd.Size = new System.Drawing.Size(54, 18);
            this.radioButtonCriteriaProd.TabIndex = 0;
            this.radioButtonCriteriaProd.Text = "PROD";
            this.radioButtonCriteriaProd.UseVisualStyleBackColor = true;
            // 
            // radioButtonCriteriaMean
            // 
            this.radioButtonCriteriaMean.AutoSize = true;
            this.radioButtonCriteriaMean.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCriteriaMean.Location = new System.Drawing.Point(9, 68);
            this.radioButtonCriteriaMean.Name = "radioButtonCriteriaMean";
            this.radioButtonCriteriaMean.Size = new System.Drawing.Size(56, 18);
            this.radioButtonCriteriaMean.TabIndex = 0;
            this.radioButtonCriteriaMean.Text = "MEAN";
            this.radioButtonCriteriaMean.UseVisualStyleBackColor = true;
            // 
            // RuleBlockWizardDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxRuleBlockName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "RuleBlockWizardDialog";
            this.Text = "Rule Block Wizard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxRuleBlockName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxVariablesCollection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonToInput;
        private System.Windows.Forms.Button buttonToOutput;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.ListBox listBoxOutputVariablesCollection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxInputVariablesCollection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonCriteriaMimMax;
        private System.Windows.Forms.RadioButton radioButtonCriteriaMean;
        private System.Windows.Forms.RadioButton radioButtonCriteriaProd;
    }
}