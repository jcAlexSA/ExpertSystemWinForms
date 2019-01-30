namespace ExpertSystemWinForms.Views.Dialogs
{
    partial class FuzzyVariableWizardDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.firstStep = new System.Windows.Forms.TabPage();
            this.textBoxVariableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxVariableType = new System.Windows.Forms.GroupBox();
            this.radioButtonOutputType = new System.Windows.Forms.RadioButton();
            this.radioButtonIntermediateType = new System.Windows.Forms.RadioButton();
            this.radioButtonInputType = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.secondStep = new System.Windows.Forms.TabPage();
            this.groupBoxAddingTerms = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGauss = new System.Windows.Forms.Panel();
            this.textBoxGaussC = new System.Windows.Forms.TextBox();
            this.textBoxGaussB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTriangle = new System.Windows.Forms.Panel();
            this.textBoxTriangleLeft = new System.Windows.Forms.TextBox();
            this.textBoxTriangleRight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTriangleMiddle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxTerms = new System.Windows.Forms.ListBox();
            this.buttonRemoveTerm = new System.Windows.Forms.Button();
            this.buttonAddTerm = new System.Windows.Forms.Button();
            this.comboBoxVariableForm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxTermName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMBFDescription = new System.Windows.Forms.TextBox();
            this.thirdStep = new System.Windows.Forms.TabPage();
            this.textBoxVariableComment = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.firstStep.SuspendLayout();
            this.groupBoxVariableType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.secondStep.SuspendLayout();
            this.groupBoxAddingTerms.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGauss.SuspendLayout();
            this.panelTriangle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.thirdStep.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 407);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrevious, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEnd, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 379);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 28);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.Location = new System.Drawing.Point(167, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 22);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevious.Location = new System.Drawing.Point(81, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(80, 22);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(339, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEnd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnd.Location = new System.Drawing.Point(253, 3);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(80, 22);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.firstStep);
            this.tabControl.Controls.Add(this.secondStep);
            this.tabControl.Controls.Add(this.thirdStep);
            this.tabControl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(411, 369);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // firstStep
            // 
            this.firstStep.Controls.Add(this.textBoxVariableName);
            this.firstStep.Controls.Add(this.label1);
            this.firstStep.Controls.Add(this.groupBoxVariableType);
            this.firstStep.Controls.Add(this.groupBox1);
            this.firstStep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstStep.Location = new System.Drawing.Point(4, 23);
            this.firstStep.Name = "firstStep";
            this.firstStep.Padding = new System.Windows.Forms.Padding(3);
            this.firstStep.Size = new System.Drawing.Size(403, 342);
            this.firstStep.TabIndex = 0;
            this.firstStep.Text = " First Step";
            this.firstStep.UseVisualStyleBackColor = true;
            // 
            // textBoxVariableName
            // 
            this.textBoxVariableName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVariableName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVariableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxVariableName.Location = new System.Drawing.Point(74, 118);
            this.textBoxVariableName.MaxLength = 50;
            this.textBoxVariableName.Name = "textBoxVariableName";
            this.textBoxVariableName.Size = new System.Drawing.Size(321, 21);
            this.textBoxVariableName.TabIndex = 0;
            this.textBoxVariableName.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // groupBoxVariableType
            // 
            this.groupBoxVariableType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVariableType.Controls.Add(this.radioButtonOutputType);
            this.groupBoxVariableType.Controls.Add(this.radioButtonIntermediateType);
            this.groupBoxVariableType.Controls.Add(this.radioButtonInputType);
            this.groupBoxVariableType.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxVariableType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxVariableType.Location = new System.Drawing.Point(3, 153);
            this.groupBoxVariableType.Name = "groupBoxVariableType";
            this.groupBoxVariableType.Size = new System.Drawing.Size(392, 126);
            this.groupBoxVariableType.TabIndex = 1;
            this.groupBoxVariableType.TabStop = false;
            this.groupBoxVariableType.Text = "Type";
            // 
            // radioButtonOutputType
            // 
            this.radioButtonOutputType.AutoSize = true;
            this.radioButtonOutputType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOutputType.Location = new System.Drawing.Point(20, 87);
            this.radioButtonOutputType.Name = "radioButtonOutputType";
            this.radioButtonOutputType.Size = new System.Drawing.Size(63, 19);
            this.radioButtonOutputType.TabIndex = 3;
            this.radioButtonOutputType.Text = "Output";
            this.radioButtonOutputType.UseVisualStyleBackColor = true;
            // 
            // radioButtonIntermediateType
            // 
            this.radioButtonIntermediateType.AutoSize = true;
            this.radioButtonIntermediateType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonIntermediateType.Location = new System.Drawing.Point(20, 59);
            this.radioButtonIntermediateType.Name = "radioButtonIntermediateType";
            this.radioButtonIntermediateType.Size = new System.Drawing.Size(97, 19);
            this.radioButtonIntermediateType.TabIndex = 2;
            this.radioButtonIntermediateType.Text = "Intermediate";
            this.radioButtonIntermediateType.UseVisualStyleBackColor = true;
            // 
            // radioButtonInputType
            // 
            this.radioButtonInputType.AutoSize = true;
            this.radioButtonInputType.Checked = true;
            this.radioButtonInputType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonInputType.Location = new System.Drawing.Point(20, 31);
            this.radioButtonInputType.Name = "radioButtonInputType";
            this.radioButtonInputType.Size = new System.Drawing.Size(53, 19);
            this.radioButtonInputType.TabIndex = 1;
            this.radioButtonInputType.TabStop = true;
            this.radioButtonInputType.Text = "Input";
            this.radioButtonInputType.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.groupBox1.Size = new System.Drawing.Size(389, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Define Linguistic Variable";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDescription.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDescription.Location = new System.Drawing.Point(10, 28);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(369, 51);
            this.textBoxDescription.TabIndex = 1;
            this.textBoxDescription.Text = "The Linguistic Variables Wizard will help you to create a linguistic variable wit" +
    "h an initial set of terms and membership functions. In this step you specify nam" +
    "e, color and type of the variable.";
            // 
            // secondStep
            // 
            this.secondStep.Controls.Add(this.groupBoxAddingTerms);
            this.secondStep.Controls.Add(this.groupBox2);
            this.secondStep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.secondStep.Location = new System.Drawing.Point(4, 23);
            this.secondStep.Name = "secondStep";
            this.secondStep.Padding = new System.Windows.Forms.Padding(3);
            this.secondStep.Size = new System.Drawing.Size(408, 337);
            this.secondStep.TabIndex = 1;
            this.secondStep.Text = "Second Step";
            this.secondStep.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddingTerms
            // 
            this.groupBoxAddingTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddingTerms.Controls.Add(this.panel2);
            this.groupBoxAddingTerms.Controls.Add(this.listBoxTerms);
            this.groupBoxAddingTerms.Controls.Add(this.buttonRemoveTerm);
            this.groupBoxAddingTerms.Controls.Add(this.buttonAddTerm);
            this.groupBoxAddingTerms.Controls.Add(this.comboBoxVariableForm);
            this.groupBoxAddingTerms.Controls.Add(this.label2);
            this.groupBoxAddingTerms.Controls.Add(this.labelName);
            this.groupBoxAddingTerms.Controls.Add(this.textBoxTermName);
            this.groupBoxAddingTerms.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddingTerms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxAddingTerms.Location = new System.Drawing.Point(6, 103);
            this.groupBoxAddingTerms.Name = "groupBoxAddingTerms";
            this.groupBoxAddingTerms.Size = new System.Drawing.Size(396, 228);
            this.groupBoxAddingTerms.TabIndex = 1;
            this.groupBoxAddingTerms.TabStop = false;
            this.groupBoxAddingTerms.Text = "Add Terms";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panelGauss);
            this.panel2.Controls.Add(this.panelTriangle);
            this.panel2.Location = new System.Drawing.Point(6, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 200);
            this.panel2.TabIndex = 7;
            // 
            // panelGauss
            // 
            this.panelGauss.Controls.Add(this.textBoxGaussC);
            this.panelGauss.Controls.Add(this.textBoxGaussB);
            this.panelGauss.Controls.Add(this.label6);
            this.panelGauss.Controls.Add(this.label7);
            this.panelGauss.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGauss.Location = new System.Drawing.Point(0, 108);
            this.panelGauss.Name = "panelGauss";
            this.panelGauss.Size = new System.Drawing.Size(131, 73);
            this.panelGauss.TabIndex = 6;
            this.panelGauss.Visible = false;
            // 
            // textBoxGaussC
            // 
            this.textBoxGaussC.Font = new System.Drawing.Font("Arial", 9F);
            this.textBoxGaussC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxGaussC.Location = new System.Drawing.Point(55, 9);
            this.textBoxGaussC.Name = "textBoxGaussC";
            this.textBoxGaussC.Size = new System.Drawing.Size(72, 21);
            this.textBoxGaussC.TabIndex = 3;
            this.textBoxGaussC.Text = "0";
            // 
            // textBoxGaussB
            // 
            this.textBoxGaussB.Font = new System.Drawing.Font("Arial", 9F);
            this.textBoxGaussB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxGaussB.Location = new System.Drawing.Point(55, 38);
            this.textBoxGaussB.Name = "textBoxGaussB";
            this.textBoxGaussB.Size = new System.Drawing.Size(72, 21);
            this.textBoxGaussB.TabIndex = 0;
            this.textBoxGaussB.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "c";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "b";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTriangle
            // 
            this.panelTriangle.Controls.Add(this.textBoxTriangleLeft);
            this.panelTriangle.Controls.Add(this.textBoxTriangleRight);
            this.panelTriangle.Controls.Add(this.label3);
            this.panelTriangle.Controls.Add(this.textBoxTriangleMiddle);
            this.panelTriangle.Controls.Add(this.label4);
            this.panelTriangle.Controls.Add(this.label5);
            this.panelTriangle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTriangle.Location = new System.Drawing.Point(0, 0);
            this.panelTriangle.Name = "panelTriangle";
            this.panelTriangle.Size = new System.Drawing.Size(131, 108);
            this.panelTriangle.TabIndex = 5;
            this.panelTriangle.Visible = false;
            // 
            // textBoxTriangleLeft
            // 
            this.textBoxTriangleLeft.Font = new System.Drawing.Font("Arial", 9F);
            this.textBoxTriangleLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTriangleLeft.Location = new System.Drawing.Point(55, 10);
            this.textBoxTriangleLeft.Name = "textBoxTriangleLeft";
            this.textBoxTriangleLeft.Size = new System.Drawing.Size(72, 21);
            this.textBoxTriangleLeft.TabIndex = 3;
            this.textBoxTriangleLeft.Text = "0";
            // 
            // textBoxTriangleRight
            // 
            this.textBoxTriangleRight.Font = new System.Drawing.Font("Arial", 9F);
            this.textBoxTriangleRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTriangleRight.Location = new System.Drawing.Point(55, 68);
            this.textBoxTriangleRight.Name = "textBoxTriangleRight";
            this.textBoxTriangleRight.Size = new System.Drawing.Size(72, 21);
            this.textBoxTriangleRight.TabIndex = 0;
            this.textBoxTriangleRight.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Low";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTriangleMiddle
            // 
            this.textBoxTriangleMiddle.Font = new System.Drawing.Font("Arial", 9F);
            this.textBoxTriangleMiddle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTriangleMiddle.Location = new System.Drawing.Point(55, 39);
            this.textBoxTriangleMiddle.Name = "textBoxTriangleMiddle";
            this.textBoxTriangleMiddle.Size = new System.Drawing.Size(72, 21);
            this.textBoxTriangleMiddle.TabIndex = 0;
            this.textBoxTriangleMiddle.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Middle";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Right";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxTerms
            // 
            this.listBoxTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTerms.BackColor = System.Drawing.Color.White;
            this.listBoxTerms.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTerms.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxTerms.FormattingEnabled = true;
            this.listBoxTerms.ItemHeight = 14;
            this.listBoxTerms.Location = new System.Drawing.Point(210, 37);
            this.listBoxTerms.Name = "listBoxTerms";
            this.listBoxTerms.Size = new System.Drawing.Size(180, 102);
            this.listBoxTerms.TabIndex = 4;
            this.listBoxTerms.SelectedIndexChanged += new System.EventHandler(this.ListBoxTerms_SelectedIndexChanged);
            // 
            // buttonRemoveTerm
            // 
            this.buttonRemoveTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRemoveTerm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveTerm.Font = new System.Drawing.Font("Algerian", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveTerm.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRemoveTerm.Location = new System.Drawing.Point(143, 126);
            this.buttonRemoveTerm.Name = "buttonRemoveTerm";
            this.buttonRemoveTerm.Size = new System.Drawing.Size(61, 22);
            this.buttonRemoveTerm.TabIndex = 3;
            this.buttonRemoveTerm.Text = "Remove";
            this.buttonRemoveTerm.UseVisualStyleBackColor = false;
            this.buttonRemoveTerm.Click += new System.EventHandler(this.ButtonRemoveTerm_Click);
            // 
            // buttonAddTerm
            // 
            this.buttonAddTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddTerm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddTerm.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTerm.ForeColor = System.Drawing.Color.Green;
            this.buttonAddTerm.Location = new System.Drawing.Point(143, 98);
            this.buttonAddTerm.Name = "buttonAddTerm";
            this.buttonAddTerm.Size = new System.Drawing.Size(61, 22);
            this.buttonAddTerm.TabIndex = 2;
            this.buttonAddTerm.Text = "Add";
            this.buttonAddTerm.UseVisualStyleBackColor = false;
            this.buttonAddTerm.Click += new System.EventHandler(this.ButtonAddTerm_Click);
            // 
            // comboBoxVariableForm
            // 
            this.comboBoxVariableForm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxVariableForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxVariableForm.FormattingEnabled = true;
            this.comboBoxVariableForm.Items.AddRange(new object[] {
            "Gauss",
            "Triangle"});
            this.comboBoxVariableForm.Location = new System.Drawing.Point(61, 66);
            this.comboBoxVariableForm.Name = "comboBoxVariableForm";
            this.comboBoxVariableForm.Size = new System.Drawing.Size(143, 23);
            this.comboBoxVariableForm.TabIndex = 1;
            this.comboBoxVariableForm.Text = "Choose Type";
            this.comboBoxVariableForm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVariableForm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Form";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(9, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTermName
            // 
            this.textBoxTermName.Font = new System.Drawing.Font("Arial", 9F);
            this.textBoxTermName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTermName.Location = new System.Drawing.Point(61, 37);
            this.textBoxTermName.Name = "textBoxTermName";
            this.textBoxTermName.Size = new System.Drawing.Size(143, 21);
            this.textBoxTermName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxMBFDescription);
            this.groupBox2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.groupBox2.Size = new System.Drawing.Size(397, 90);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MBF Definition";
            // 
            // textBoxMBFDescription
            // 
            this.textBoxMBFDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMBFDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMBFDescription.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMBFDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMBFDescription.Location = new System.Drawing.Point(13, 29);
            this.textBoxMBFDescription.Multiline = true;
            this.textBoxMBFDescription.Name = "textBoxMBFDescription";
            this.textBoxMBFDescription.Size = new System.Drawing.Size(371, 47);
            this.textBoxMBFDescription.TabIndex = 0;
            this.textBoxMBFDescription.Text = "In this step you specify the number of terms, that determines the choice of term " +
    "names and the membership function definitions for the set of terms to be created" +
    ".";
            // 
            // thirdStep
            // 
            this.thirdStep.Controls.Add(this.textBoxVariableComment);
            this.thirdStep.Controls.Add(this.groupBox3);
            this.thirdStep.Location = new System.Drawing.Point(4, 23);
            this.thirdStep.Name = "thirdStep";
            this.thirdStep.Padding = new System.Windows.Forms.Padding(3);
            this.thirdStep.Size = new System.Drawing.Size(408, 316);
            this.thirdStep.TabIndex = 2;
            this.thirdStep.Text = "Third Step";
            this.thirdStep.UseVisualStyleBackColor = true;
            // 
            // textBoxVariableComment
            // 
            this.textBoxVariableComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVariableComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxVariableComment.Location = new System.Drawing.Point(7, 102);
            this.textBoxVariableComment.Multiline = true;
            this.textBoxVariableComment.Name = "textBoxVariableComment";
            this.textBoxVariableComment.Size = new System.Drawing.Size(395, 208);
            this.textBoxVariableComment.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.groupBox3.Size = new System.Drawing.Size(396, 89);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comment For Variable";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(10, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "The Linguistic Variables Wizard will help you to create a linguistic variable wit" +
    "h an initial set of terms and membership functions. In this step you specify nam" +
    "e, color and type of the variable.";
            // 
            // FuzzyVariableWizardDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 407);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "FuzzyVariableWizardDialog";
            this.Text = "Fuzzy Variables Wizard";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.firstStep.ResumeLayout(false);
            this.firstStep.PerformLayout();
            this.groupBoxVariableType.ResumeLayout(false);
            this.groupBoxVariableType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.secondStep.ResumeLayout(false);
            this.groupBoxAddingTerms.ResumeLayout(false);
            this.groupBoxAddingTerms.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelGauss.ResumeLayout(false);
            this.panelGauss.PerformLayout();
            this.panelTriangle.ResumeLayout(false);
            this.panelTriangle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.thirdStep.ResumeLayout(false);
            this.thirdStep.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage firstStep;
        private System.Windows.Forms.TabPage secondStep;
        private System.Windows.Forms.TabPage thirdStep;
        private System.Windows.Forms.GroupBox groupBoxVariableType;
        private System.Windows.Forms.RadioButton radioButtonOutputType;
        private System.Windows.Forms.RadioButton radioButtonIntermediateType;
        private System.Windows.Forms.RadioButton radioButtonInputType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxVariableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMBFDescription;
        private System.Windows.Forms.GroupBox groupBoxAddingTerms;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxTermName;
        private System.Windows.Forms.Button buttonRemoveTerm;
        private System.Windows.Forms.Button buttonAddTerm;
        private System.Windows.Forms.ComboBox comboBoxVariableForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTriangleRight;
        private System.Windows.Forms.TextBox textBoxTriangleMiddle;
        private System.Windows.Forms.TextBox textBoxTriangleLeft;
        private System.Windows.Forms.ListBox listBoxTerms;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxVariableComment;
        private System.Windows.Forms.Panel panelGauss;
        private System.Windows.Forms.TextBox textBoxGaussC;
        private System.Windows.Forms.TextBox textBoxGaussB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelTriangle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
    }
}