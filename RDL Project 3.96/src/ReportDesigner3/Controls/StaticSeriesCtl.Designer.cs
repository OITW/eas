namespace fyiReporting.RdlDesign
{
    partial class StaticSeriesCtl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbDataSeries = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkShowLabels = new System.Windows.Forms.CheckBox();
            this.txtSeriesName = new System.Windows.Forms.TextBox();
            this.txtLabelValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnLabelValue = new System.Windows.Forms.Button();
            this.btnDataValue = new System.Windows.Forms.Button();
            this.btnSeriesName = new System.Windows.Forms.Button();
            this.txtDataValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPlotType = new System.Windows.Forms.ComboBox();
            this.chkLeft = new System.Windows.Forms.RadioButton();
            this.chkRight = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据序列：";
            // 
            // lbDataSeries
            // 
            this.lbDataSeries.FormattingEnabled = true;
            this.lbDataSeries.ItemHeight = 12;
            this.lbDataSeries.Location = new System.Drawing.Point(16, 26);
            this.lbDataSeries.Name = "lbDataSeries";
            this.lbDataSeries.Size = new System.Drawing.Size(120, 124);
            this.lbDataSeries.TabIndex = 1;
            this.lbDataSeries.SelectedIndexChanged += new System.EventHandler(this.lbDataSeries_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "序列名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "数据：";
            // 
            // chkShowLabels
            // 
            this.chkShowLabels.AutoSize = true;
            this.chkShowLabels.Location = new System.Drawing.Point(145, 122);
            this.chkShowLabels.Name = "chkShowLabels";
            this.chkShowLabels.Size = new System.Drawing.Size(72, 16);
            this.chkShowLabels.TabIndex = 4;
            this.chkShowLabels.Text = "显示标记";
            this.chkShowLabels.UseVisualStyleBackColor = true;
            this.chkShowLabels.CheckedChanged += new System.EventHandler(this.chkShowLabels_CheckedChanged);
            // 
            // txtSeriesName
            // 
            this.txtSeriesName.Location = new System.Drawing.Point(142, 26);
            this.txtSeriesName.Name = "txtSeriesName";
            this.txtSeriesName.Size = new System.Drawing.Size(184, 21);
            this.txtSeriesName.TabIndex = 5;
            this.txtSeriesName.TextChanged += new System.EventHandler(this.txtSeriesName_TextChanged);
            // 
            // txtLabelValue
            // 
            this.txtLabelValue.Enabled = false;
            this.txtLabelValue.Location = new System.Drawing.Point(142, 140);
            this.txtLabelValue.Name = "txtLabelValue";
            this.txtLabelValue.Size = new System.Drawing.Size(184, 21);
            this.txtLabelValue.TabIndex = 7;
            this.txtLabelValue.TextChanged += new System.EventHandler(this.txtLabelValue_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(86, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "新建";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(16, 155);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 29);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnLabelValue
            // 
            this.btnLabelValue.Enabled = false;
            this.btnLabelValue.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLabelValue.Location = new System.Drawing.Point(332, 140);
            this.btnLabelValue.Name = "btnLabelValue";
            this.btnLabelValue.Size = new System.Drawing.Size(25, 21);
            this.btnLabelValue.TabIndex = 21;
            this.btnLabelValue.Text = "fx";
            this.btnLabelValue.UseVisualStyleBackColor = true;
            this.btnLabelValue.Click += new System.EventHandler(this.FunctionButtonClick);
            // 
            // btnDataValue
            // 
            this.btnDataValue.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDataValue.Location = new System.Drawing.Point(332, 62);
            this.btnDataValue.Name = "btnDataValue";
            this.btnDataValue.Size = new System.Drawing.Size(25, 21);
            this.btnDataValue.TabIndex = 22;
            this.btnDataValue.Text = "fx";
            this.btnDataValue.UseVisualStyleBackColor = true;
            this.btnDataValue.Click += new System.EventHandler(this.FunctionButtonClick);
            // 
            // btnSeriesName
            // 
            this.btnSeriesName.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSeriesName.Location = new System.Drawing.Point(332, 26);
            this.btnSeriesName.Name = "btnSeriesName";
            this.btnSeriesName.Size = new System.Drawing.Size(25, 21);
            this.btnSeriesName.TabIndex = 23;
            this.btnSeriesName.Text = "fx";
            this.btnSeriesName.UseVisualStyleBackColor = true;
            this.btnSeriesName.Click += new System.EventHandler(this.FunctionButtonClick);
            // 
            // txtDataValue
            // 
            this.txtDataValue.Location = new System.Drawing.Point(142, 62);
            this.txtDataValue.Name = "txtDataValue";
            this.txtDataValue.Size = new System.Drawing.Size(184, 21);
            this.txtDataValue.TabIndex = 24;
            this.txtDataValue.TextChanged += new System.EventHandler(this.txtDataValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "序列绘图类型";
            // 
            // cbPlotType
            // 
            this.cbPlotType.FormattingEnabled = true;
            this.cbPlotType.Items.AddRange(new object[] {
            "Auto",
            "Line"});
            this.cbPlotType.Location = new System.Drawing.Point(142, 176);
            this.cbPlotType.Name = "cbPlotType";
            this.cbPlotType.Size = new System.Drawing.Size(184, 20);
            this.cbPlotType.TabIndex = 26;
            this.cbPlotType.SelectedIndexChanged += new System.EventHandler(this.cbPlotType_SelectedIndexChanged);
            // 
            // chkLeft
            // 
            this.chkLeft.AutoSize = true;
            this.chkLeft.Location = new System.Drawing.Point(163, 213);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new System.Drawing.Size(35, 16);
            this.chkLeft.TabIndex = 27;
            this.chkLeft.TabStop = true;
            this.chkLeft.Text = "左";
            this.chkLeft.UseVisualStyleBackColor = true;
            this.chkLeft.CheckedChanged += new System.EventHandler(this.chkLeft_CheckedChanged);
            // 
            // chkRight
            // 
            this.chkRight.AutoSize = true;
            this.chkRight.Location = new System.Drawing.Point(226, 213);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new System.Drawing.Size(35, 16);
            this.chkRight.TabIndex = 28;
            this.chkRight.TabStop = true;
            this.chkRight.Text = "右";
            this.chkRight.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "Y轴";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(0, 26);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(17, 21);
            this.btnUp.TabIndex = 30;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(0, 128);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(17, 21);
            this.btnDown.TabIndex = 31;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(142, 98);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(184, 21);
            this.txtX.TabIndex = 32;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "X值：";
            // 
            // btnX
            // 
            this.btnX.Enabled = false;
            this.btnX.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnX.Location = new System.Drawing.Point(332, 98);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(25, 21);
            this.btnX.TabIndex = 34;
            this.btnX.Text = "fx";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // StaticSeriesCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkRight);
            this.Controls.Add(this.chkLeft);
            this.Controls.Add(this.cbPlotType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataValue);
            this.Controls.Add(this.btnSeriesName);
            this.Controls.Add(this.btnDataValue);
            this.Controls.Add(this.btnLabelValue);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLabelValue);
            this.Controls.Add(this.txtSeriesName);
            this.Controls.Add(this.chkShowLabels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDataSeries);
            this.Controls.Add(this.label1);
            this.Name = "StaticSeriesCtl";
            this.Size = new System.Drawing.Size(371, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDataSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkShowLabels;
        private System.Windows.Forms.TextBox txtSeriesName;
        private System.Windows.Forms.TextBox txtLabelValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnLabelValue;
        private System.Windows.Forms.Button btnDataValue;
        private System.Windows.Forms.Button btnSeriesName;
        private System.Windows.Forms.TextBox txtDataValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPlotType;
        private System.Windows.Forms.RadioButton chkLeft;
        private System.Windows.Forms.RadioButton chkRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnX;
    }
}
