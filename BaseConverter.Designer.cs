namespace BaseConverter
{
    partial class BaseConverter
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblFromBase = new System.Windows.Forms.Label();
            this.lblToBase = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cbFromBase = new System.Windows.Forms.ComboBox();
            this.cbToBase = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(35, 45);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(86, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter Number";
            // 
            // lblFromBase
            // 
            this.lblFromBase.AutoSize = true;
            this.lblFromBase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFromBase.Location = new System.Drawing.Point(35, 153);
            this.lblFromBase.Name = "lblFromBase";
            this.lblFromBase.Size = new System.Drawing.Size(65, 15);
            this.lblFromBase.TabIndex = 1;
            this.lblFromBase.Text = "From Base";
            // 
            // lblToBase
            // 
            this.lblToBase.AutoSize = true;
            this.lblToBase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToBase.Location = new System.Drawing.Point(35, 258);
            this.lblToBase.Name = "lblToBase";
            this.lblToBase.Size = new System.Drawing.Size(49, 15);
            this.lblToBase.TabIndex = 2;
            this.lblToBase.Text = "To Base";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(35, 481);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(42, 15);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumber.Location = new System.Drawing.Point(35, 76);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(436, 39);
            this.txtNumber.TabIndex = 4;
            // 
            // cbFromBase
            // 
            this.cbFromBase.DropDownHeight = 220;
            this.cbFromBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFromBase.FormattingEnabled = true;
            this.cbFromBase.IntegralHeight = false;
            this.cbFromBase.ItemHeight = 30;
            this.cbFromBase.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.cbFromBase.Location = new System.Drawing.Point(35, 181);
            this.cbFromBase.Name = "cbFromBase";
            this.cbFromBase.Size = new System.Drawing.Size(436, 38);
            this.cbFromBase.TabIndex = 5;
            // 
            // cbToBase
            // 
            this.cbToBase.DropDownHeight = 220;
            this.cbToBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbToBase.FormattingEnabled = true;
            this.cbToBase.IntegralHeight = false;
            this.cbToBase.ItemHeight = 30;
            this.cbToBase.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.cbToBase.Location = new System.Drawing.Point(35, 286);
            this.cbToBase.Name = "cbToBase";
            this.cbToBase.Size = new System.Drawing.Size(436, 38);
            this.cbToBase.TabIndex = 6;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(35, 512);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(436, 39);
            this.txtResult.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 458);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 124);
            this.panel2.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSwap);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 412);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base Converter";
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSwap.Location = new System.Drawing.Point(302, 330);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(99, 49);
            this.btnSwap.TabIndex = 15;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.Location = new System.Drawing.Point(185, 330);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 49);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConvert.Location = new System.Drawing.Point(71, 330);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(99, 49);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // BaseConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 602);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cbToBase);
            this.Controls.Add(this.cbFromBase);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblToBase);
            this.Controls.Add(this.lblFromBase);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaseConverter";
            this.Text = "Base Converter";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumber;
        private Label lblFromBase;
        private Label lblToBase;
        private Label lblResult;
        private TextBox txtNumber;
        private ComboBox cbFromBase;
        private ComboBox cbToBase;
        private TextBox txtResult;
        private Panel panel2;
        private GroupBox groupBox1;
        private Button btnSwap;
        private Button btnReset;
        private Button btnConvert;
    }
}