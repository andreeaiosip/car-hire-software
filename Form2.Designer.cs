namespace CarsDatabase
{
    partial class taskAsearch
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
            this.boxField = new System.Windows.Forms.ComboBox();
            this.boxOperator = new System.Windows.Forms.ComboBox();
            this.boxValue = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblField = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxField
            // 
            this.boxField.FormattingEnabled = true;
            this.boxField.Location = new System.Drawing.Point(94, 124);
            this.boxField.Name = "boxField";
            this.boxField.Size = new System.Drawing.Size(121, 21);
            this.boxField.TabIndex = 0;
            // 
            // boxOperator
            // 
            this.boxOperator.FormattingEnabled = true;
            this.boxOperator.Location = new System.Drawing.Point(270, 124);
            this.boxOperator.Name = "boxOperator";
            this.boxOperator.Size = new System.Drawing.Size(121, 21);
            this.boxOperator.TabIndex = 1;
            // 
            // boxValue
            // 
            this.boxValue.Location = new System.Drawing.Point(467, 125);
            this.boxValue.Name = "boxValue";
            this.boxValue.Size = new System.Drawing.Size(100, 20);
            this.boxValue.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(634, 97);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 32);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(634, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(97, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 143);
            this.panel1.TabIndex = 5;
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(94, 97);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(29, 13);
            this.lblField.TabIndex = 6;
            this.lblField.Text = "Field";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(464, 97);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 7;
            this.lblValue.Text = "Value";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(267, 97);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(48, 13);
            this.lblOperator.TabIndex = 8;
            this.lblOperator.Text = "Operator";
            // 
            // taskAsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.boxValue);
            this.Controls.Add(this.boxOperator);
            this.Controls.Add(this.boxField);
            this.Name = "taskAsearch";
            this.Text = "frmSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxField;
        private System.Windows.Forms.ComboBox boxOperator;
        private System.Windows.Forms.TextBox boxValue;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblOperator;
    }
}