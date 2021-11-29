
namespace TheWeather
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
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_days = new System.Windows.Forms.Label();
            this.lbl_condition = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_wind = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cityName.ForeColor = System.Drawing.Color.Black;
            this.lbl_cityName.Location = new System.Drawing.Point(50, 31);
            this.lbl_cityName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(78, 31);
            this.lbl_cityName.TabIndex = 0;
            this.lbl_cityName.Text = "City";
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp.Location = new System.Drawing.Point(175, 92);
            this.lbl_Temp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(26, 27);
            this.lbl_Temp.TabIndex = 1;
            this.lbl_Temp.Text = "C";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(53, 78);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(78, 18);
            this.lbl_country.TabIndex = 2;
            this.lbl_country.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(965, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forecast";
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Location = new System.Drawing.Point(948, 90);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(48, 18);
            this.lbl_days.TabIndex = 4;
            this.lbl_days.Text = "Days";
            // 
            // lbl_condition
            // 
            this.lbl_condition.AutoSize = true;
            this.lbl_condition.Location = new System.Drawing.Point(945, 120);
            this.lbl_condition.Name = "lbl_condition";
            this.lbl_condition.Size = new System.Drawing.Size(108, 18);
            this.lbl_condition.TabIndex = 5;
            this.lbl_condition.Text = "Conditions";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(948, 150);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(118, 18);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Description";
            // 
            // lbl_wind
            // 
            this.lbl_wind.AutoSize = true;
            this.lbl_wind.Location = new System.Drawing.Point(1150, 97);
            this.lbl_wind.Name = "lbl_wind";
            this.lbl_wind.Size = new System.Drawing.Size(68, 18);
            this.lbl_wind.TabIndex = 7;
            this.lbl_wind.Text = "12km/h";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Location = new System.Drawing.Point(1150, 142);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(28, 18);
            this.lbl_.TabIndex = 8;
            this.lbl_.Text = "26";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lbl_wind);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_condition);
            this.Controls.Add(this.lbl_days);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_Temp);
            this.Controls.Add(this.lbl_cityName);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cityName;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.Label lbl_condition;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_wind;
        private System.Windows.Forms.Label lbl_;
    }
}

