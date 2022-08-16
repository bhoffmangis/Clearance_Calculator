namespace Clearance_Calculator
{
    partial class ClearanceCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClearanceCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultingClearance = new System.Windows.Forms.Label();
            this.txtMeasuredClearance = new System.Windows.Forms.TextBox();
            this.txtCurrentShim = new System.Windows.Forms.TextBox();
            this.txtReplacementShim = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Measured Clearance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Shim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Replacement Shim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Resulting Clearance:";
            // 
            // lblResultingClearance
            // 
            this.lblResultingClearance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultingClearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultingClearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblResultingClearance.Location = new System.Drawing.Point(142, 131);
            this.lblResultingClearance.Name = "lblResultingClearance";
            this.lblResultingClearance.Size = new System.Drawing.Size(100, 20);
            this.lblResultingClearance.TabIndex = 4;
            this.lblResultingClearance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMeasuredClearance
            // 
            this.txtMeasuredClearance.Location = new System.Drawing.Point(142, 35);
            this.txtMeasuredClearance.Name = "txtMeasuredClearance";
            this.txtMeasuredClearance.Size = new System.Drawing.Size(100, 20);
            this.txtMeasuredClearance.TabIndex = 1;
            this.txtMeasuredClearance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMeasuredClearance.TextChanged += new System.EventHandler(this.txtMeasuredClearance_TextChanged);
            // 
            // txtCurrentShim
            // 
            this.txtCurrentShim.Location = new System.Drawing.Point(142, 67);
            this.txtCurrentShim.Name = "txtCurrentShim";
            this.txtCurrentShim.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentShim.TabIndex = 2;
            this.txtCurrentShim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReplacementShim
            // 
            this.txtReplacementShim.Location = new System.Drawing.Point(142, 99);
            this.txtReplacementShim.Name = "txtReplacementShim";
            this.txtReplacementShim.Size = new System.Drawing.Size(100, 20);
            this.txtReplacementShim.TabIndex = 3;
            this.txtReplacementShim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReplacementShim.TextChanged += new System.EventHandler(this.txtReplacementShim_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(40, 175);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 35);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(180, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "( .mmm )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "( m.mm )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "( m.mm )";
            // 
            // ClearanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 234);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtReplacementShim);
            this.Controls.Add(this.txtCurrentShim);
            this.Controls.Add(this.txtMeasuredClearance);
            this.Controls.Add(this.lblResultingClearance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClearanceCalculator";
            this.Text = "Clearance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultingClearance;
        private System.Windows.Forms.TextBox txtMeasuredClearance;
        private System.Windows.Forms.TextBox txtCurrentShim;
        private System.Windows.Forms.TextBox txtReplacementShim;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

