namespace CarsDatabase
{
    partial class frmCars
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
            this.vehRegNoBox = new System.Windows.Forms.TextBox();
            this.rentPerDayBox = new System.Windows.Forms.TextBox();
            this.dateRgBox = new System.Windows.Forms.TextBox();
            this.engineBox = new System.Windows.Forms.TextBox();
            this.makeBox = new System.Windows.Forms.TextBox();
            this.availCheckBox = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.engSizeLbl = new System.Windows.Forms.Label();
            this.dateRegLbl = new System.Windows.Forms.Label();
            this.makeLbl = new System.Windows.Forms.Label();
            this.regNoLbl = new System.Windows.Forms.Label();
            this.rentalPriceLbl = new System.Windows.Forms.Label();
            this.titleFrm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.boxCounter = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehRegNoBox
            // 
            this.vehRegNoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehRegNoBox.Location = new System.Drawing.Point(220, 120);
            this.vehRegNoBox.MaxLength = 10;
            this.vehRegNoBox.Name = "vehRegNoBox";
            this.vehRegNoBox.Size = new System.Drawing.Size(142, 22);
            this.vehRegNoBox.TabIndex = 0;
            this.vehRegNoBox.Tag = "Text";
            // 
            // rentPerDayBox
            // 
            this.rentPerDayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentPerDayBox.Location = new System.Drawing.Point(220, 268);
            this.rentPerDayBox.Name = "rentPerDayBox";
            this.rentPerDayBox.Size = new System.Drawing.Size(142, 22);
            this.rentPerDayBox.TabIndex = 5;
            this.rentPerDayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rentperdaybox_KeyPress);
            // 
            // dateRgBox
            // 
            this.dateRgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRgBox.Location = new System.Drawing.Point(220, 232);
            this.dateRgBox.Name = "dateRgBox";
            this.dateRgBox.Size = new System.Drawing.Size(142, 22);
            this.dateRgBox.TabIndex = 4;
            // 
            // engineBox
            // 
            this.engineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineBox.Location = new System.Drawing.Point(220, 192);
            this.engineBox.MaxLength = 10;
            this.engineBox.Name = "engineBox";
            this.engineBox.Size = new System.Drawing.Size(167, 22);
            this.engineBox.TabIndex = 3;
            // 
            // makeBox
            // 
            this.makeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeBox.Location = new System.Drawing.Point(220, 153);
            this.makeBox.MaxLength = 50;
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(200, 22);
            this.makeBox.TabIndex = 2;
            this.makeBox.Tag = "Text";
            // 
            // availCheckBox
            // 
            this.availCheckBox.AutoSize = true;
            this.availCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availCheckBox.Location = new System.Drawing.Point(220, 316);
            this.availCheckBox.Name = "availCheckBox";
            this.availCheckBox.Size = new System.Drawing.Size(15, 14);
            this.availCheckBox.TabIndex = 6;
            this.availCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(647, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 32);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(647, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(647, 221);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(647, 144);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(85, 32);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(647, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(647, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 39);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Available";
            // 
            // engSizeLbl
            // 
            this.engSizeLbl.AutoSize = true;
            this.engSizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engSizeLbl.Location = new System.Drawing.Point(35, 198);
            this.engSizeLbl.Name = "engSizeLbl";
            this.engSizeLbl.Size = new System.Drawing.Size(77, 16);
            this.engSizeLbl.TabIndex = 14;
            this.engSizeLbl.Text = "Engine size";
            // 
            // dateRegLbl
            // 
            this.dateRegLbl.AutoSize = true;
            this.dateRegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRegLbl.Location = new System.Drawing.Point(35, 236);
            this.dateRegLbl.Name = "dateRegLbl";
            this.dateRegLbl.Size = new System.Drawing.Size(101, 16);
            this.dateRegLbl.TabIndex = 15;
            this.dateRegLbl.Text = "Date registered";
            // 
            // makeLbl
            // 
            this.makeLbl.AutoSize = true;
            this.makeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLbl.Location = new System.Drawing.Point(35, 159);
            this.makeLbl.Name = "makeLbl";
            this.makeLbl.Size = new System.Drawing.Size(42, 16);
            this.makeLbl.TabIndex = 16;
            this.makeLbl.Text = "Make";
            // 
            // regNoLbl
            // 
            this.regNoLbl.AutoSize = true;
            this.regNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNoLbl.Location = new System.Drawing.Point(35, 126);
            this.regNoLbl.Name = "regNoLbl";
            this.regNoLbl.Size = new System.Drawing.Size(170, 16);
            this.regNoLbl.TabIndex = 17;
            this.regNoLbl.Text = "Vehicle registration number";
            // 
            // rentalPriceLbl
            // 
            this.rentalPriceLbl.AutoSize = true;
            this.rentalPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalPriceLbl.Location = new System.Drawing.Point(35, 274);
            this.rentalPriceLbl.Name = "rentalPriceLbl";
            this.rentalPriceLbl.Size = new System.Drawing.Size(96, 16);
            this.rentalPriceLbl.TabIndex = 18;
            this.rentalPriceLbl.Text = "Rental per day";
            // 
            // titleFrm
            // 
            this.titleFrm.AutoSize = true;
            this.titleFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFrm.Location = new System.Drawing.Point(290, 40);
            this.titleFrm.Name = "titleFrm";
            this.titleFrm.Size = new System.Drawing.Size(245, 33);
            this.titleFrm.TabIndex = 19;
            this.titleFrm.Text = "Bowman Car Hire";
            this.titleFrm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.rtb);
            this.panel1.Controls.Add(this.boxCounter);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.regNoLbl);
            this.panel1.Controls.Add(this.rentalPriceLbl);
            this.panel1.Controls.Add(this.titleFrm);
            this.panel1.Controls.Add(this.makeLbl);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.dateRegLbl);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.engSizeLbl);
            this.panel1.Controls.Add(this.vehRegNoBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rentPerDayBox);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.dateRgBox);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.engineBox);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.makeBox);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.availCheckBox);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 451);
            this.panel1.TabIndex = 20;
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(383, 251);
            this.rtb.Margin = new System.Windows.Forms.Padding(2);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(260, 79);
            this.rtb.TabIndex = 25;
            this.rtb.Text = "";
            // 
            // boxCounter
            // 
            this.boxCounter.Location = new System.Drawing.Point(260, 395);
            this.boxCounter.MaxLength = 20;
            this.boxCounter.Name = "boxCounter";
            this.boxCounter.Size = new System.Drawing.Size(102, 20);
            this.boxCounter.TabIndex = 24;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(483, 388);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(85, 32);
            this.btnLast.TabIndex = 13;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(383, 388);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 32);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(150, 388);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(85, 32);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(46, 388);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(85, 32);
            this.btnFirst.TabIndex = 16;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCars";
            this.Text = "Task A - Andreea Iosip 04/12/2019";
            this.Load += new System.EventHandler(this.frmCars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox vehRegNoBox;
        private System.Windows.Forms.TextBox rentPerDayBox;
        private System.Windows.Forms.TextBox dateRgBox;
        private System.Windows.Forms.TextBox engineBox;
        private System.Windows.Forms.TextBox makeBox;
        private System.Windows.Forms.CheckBox availCheckBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label engSizeLbl;
        private System.Windows.Forms.Label dateRegLbl;
        private System.Windows.Forms.Label makeLbl;
        private System.Windows.Forms.Label regNoLbl;
        private System.Windows.Forms.Label rentalPriceLbl;
        private System.Windows.Forms.Label titleFrm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox boxCounter;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.RichTextBox rtb;
    }
}

