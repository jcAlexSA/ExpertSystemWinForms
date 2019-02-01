﻿namespace ExpertSystemWinForms.Views.Dialogs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(468, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Define Rule Block Configuration";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(10, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 61);
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
            this.textBoxRuleBlockName.Size = new System.Drawing.Size(338, 21);
            this.textBoxRuleBlockName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 274);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.9201F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.40436F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxVariablesCollection, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.listBoxOutputVariablesCollection, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxInputVariablesCollection, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 255);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(358, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
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
            this.listBoxVariablesCollection.Size = new System.Drawing.Size(122, 234);
            this.listBoxVariablesCollection.TabIndex = 5;
            this.listBoxVariablesCollection.Tag = "AllVariables";
            this.listBoxVariablesCollection.Click += new System.EventHandler(this.ListBoxVariablesCollection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(253, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
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
            this.panel1.Location = new System.Drawing.Point(131, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 234);
            this.panel1.TabIndex = 0;
            // 
            // buttonToInput
            // 
            this.buttonToInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonToInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(244)))), ((int)(((byte)(219)))));
            this.buttonToInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonToInput.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToInput.ForeColor = System.Drawing.Color.Green;
            this.buttonToInput.Location = new System.Drawing.Point(9, 137);
            this.buttonToInput.Name = "buttonToInput";
            this.buttonToInput.Size = new System.Drawing.Size(100, 25);
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
            this.buttonToOutput.Location = new System.Drawing.Point(9, 75);
            this.buttonToOutput.Name = "buttonToOutput";
            this.buttonToOutput.Size = new System.Drawing.Size(100, 25);
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
            this.buttonRemoveSelected.Location = new System.Drawing.Point(9, 106);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(100, 25);
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
            this.listBoxOutputVariablesCollection.Location = new System.Drawing.Point(358, 18);
            this.listBoxOutputVariablesCollection.Name = "listBoxOutputVariablesCollection";
            this.listBoxOutputVariablesCollection.Size = new System.Drawing.Size(101, 234);
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
            this.label1.Size = new System.Drawing.Size(122, 15);
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
            this.listBoxInputVariablesCollection.Location = new System.Drawing.Point(253, 18);
            this.listBoxInputVariablesCollection.Name = "listBoxInputVariablesCollection";
            this.listBoxInputVariablesCollection.Size = new System.Drawing.Size(99, 234);
            this.listBoxInputVariablesCollection.TabIndex = 4;
            this.listBoxInputVariablesCollection.Tag = "InputVariables";
            this.listBoxInputVariablesCollection.Click += new System.EventHandler(this.ListBoxVariablesCollection_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.26513F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.73487F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAccept, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 424);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 29);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.LightGray;
            this.buttonAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(225, 3);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(117, 23);
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
            this.buttonCancel.Location = new System.Drawing.Point(348, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(141, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // RuleBlockWizardDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxRuleBlockName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "RuleBlockWizardDialog";
            this.Text = "Rule Block Wizard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}