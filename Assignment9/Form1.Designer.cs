
namespace KayuCarRental
{
    partial class Form1
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
            this.BtnSelection = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.modelList = new System.Windows.Forms.ListBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.totalDaysLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalDays = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSelection
            // 
            this.BtnSelection.AutoSize = true;
            this.BtnSelection.BackColor = System.Drawing.Color.LightCyan;
            this.BtnSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelection.Location = new System.Drawing.Point(56, 250);
            this.BtnSelection.Name = "BtnSelection";
            this.BtnSelection.Size = new System.Drawing.Size(192, 35);
            this.BtnSelection.TabIndex = 0;
            this.BtnSelection.Text = "Selection Complete\r\n";
            this.BtnSelection.UseVisualStyleBackColor = false;
            this.BtnSelection.Click += new System.EventHandler(this.BtnSelection_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(626, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnExit);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(439, 67);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // modelList
            // 
            this.modelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelList.FormattingEnabled = true;
            this.modelList.ItemHeight = 18;
            this.modelList.Location = new System.Drawing.Point(56, 134);
            this.modelList.Name = "modelList";
            this.modelList.Size = new System.Drawing.Size(105, 94);
            this.modelList.TabIndex = 4;
            this.modelList.Click += new System.EventHandler(this.modelList_Click);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(51, 92);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(66, 25);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "Model";
            // 
            // totalDaysLabel
            // 
            this.totalDaysLabel.AutoSize = true;
            this.totalDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalDaysLabel.Location = new System.Drawing.Point(51, 306);
            this.totalDaysLabel.Name = "totalDaysLabel";
            this.totalDaysLabel.Size = new System.Drawing.Size(186, 25);
            this.totalDaysLabel.TabIndex = 6;
            this.totalDaysLabel.Text = "Total rental days is: ";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(51, 343);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(80, 25);
            this.totalCostLabel.TabIndex = 7;
            this.totalCostLabel.Text = "Total is ";
            // 
            // totalDays
            // 
            this.totalDays.AutoSize = true;
            this.totalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDays.Location = new System.Drawing.Point(248, 306);
            this.totalDays.Name = "totalDays";
            this.totalDays.Size = new System.Drawing.Size(0, 25);
            this.totalDays.TabIndex = 8;
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.Location = new System.Drawing.Point(248, 338);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(0, 25);
            this.totalCost.TabIndex = 9;
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(49, 28);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(341, 39);
            this.companyName.TabIndex = 10;
            this.companyName.Text = "Kayu Lui Car Rental";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.totalDays);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.totalDaysLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.modelList);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSelection);
            this.Name = "Form1";
            this.Text = "Car Rental";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelection;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox modelList;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label totalDaysLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalDays;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label companyName;
    }
}

