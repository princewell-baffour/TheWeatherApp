
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
            this.lbl_temp1_min = new System.Windows.Forms.Label();
            this.lbl_temp2_min = new System.Windows.Forms.Label();
            this.lbl_wind2 = new System.Windows.Forms.Label();
            this.lbl_desc2 = new System.Windows.Forms.Label();
            this.lbl_condition2 = new System.Windows.Forms.Label();
            this.lbl_day2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_temp1_max = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_temp2_max = new System.Windows.Forms.Label();
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
            this.lbl_Temp.Location = new System.Drawing.Point(136, 115);
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
            this.label1.Location = new System.Drawing.Point(714, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forecast";
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Location = new System.Drawing.Point(697, 94);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(48, 18);
            this.lbl_days.TabIndex = 4;
            this.lbl_days.Text = "Days";
            // 
            // lbl_condition
            // 
            this.lbl_condition.AutoSize = true;
            this.lbl_condition.Location = new System.Drawing.Point(694, 124);
            this.lbl_condition.Name = "lbl_condition";
            this.lbl_condition.Size = new System.Drawing.Size(108, 18);
            this.lbl_condition.TabIndex = 5;
            this.lbl_condition.Text = "Conditions";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(879, 124);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(118, 18);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Description";
            // 
            // lbl_wind
            // 
            this.lbl_wind.AutoSize = true;
            this.lbl_wind.Location = new System.Drawing.Point(899, 101);
            this.lbl_wind.Name = "lbl_wind";
            this.lbl_wind.Size = new System.Drawing.Size(68, 18);
            this.lbl_wind.TabIndex = 7;
            this.lbl_wind.Text = "12km/h";
            // 
            // lbl_temp1_min
            // 
            this.lbl_temp1_min.AutoSize = true;
            this.lbl_temp1_min.Location = new System.Drawing.Point(708, 183);
            this.lbl_temp1_min.Name = "lbl_temp1_min";
            this.lbl_temp1_min.Size = new System.Drawing.Size(38, 18);
            this.lbl_temp1_min.TabIndex = 8;
            this.lbl_temp1_min.Text = "min";
            // 
            // lbl_temp2_min
            // 
            this.lbl_temp2_min.AutoSize = true;
            this.lbl_temp2_min.Location = new System.Drawing.Point(708, 311);
            this.lbl_temp2_min.Name = "lbl_temp2_min";
            this.lbl_temp2_min.Size = new System.Drawing.Size(38, 18);
            this.lbl_temp2_min.TabIndex = 13;
            this.lbl_temp2_min.Text = "min";
            // 
            // lbl_wind2
            // 
            this.lbl_wind2.AutoSize = true;
            this.lbl_wind2.Location = new System.Drawing.Point(902, 230);
            this.lbl_wind2.Name = "lbl_wind2";
            this.lbl_wind2.Size = new System.Drawing.Size(68, 18);
            this.lbl_wind2.TabIndex = 12;
            this.lbl_wind2.Text = "12km/h";
            // 
            // lbl_desc2
            // 
            this.lbl_desc2.AutoSize = true;
            this.lbl_desc2.Location = new System.Drawing.Point(899, 253);
            this.lbl_desc2.Name = "lbl_desc2";
            this.lbl_desc2.Size = new System.Drawing.Size(118, 18);
            this.lbl_desc2.TabIndex = 11;
            this.lbl_desc2.Text = "Description";
            // 
            // lbl_condition2
            // 
            this.lbl_condition2.AutoSize = true;
            this.lbl_condition2.Location = new System.Drawing.Point(697, 253);
            this.lbl_condition2.Name = "lbl_condition2";
            this.lbl_condition2.Size = new System.Drawing.Size(108, 18);
            this.lbl_condition2.TabIndex = 10;
            this.lbl_condition2.Text = "Conditions";
            // 
            // lbl_day2
            // 
            this.lbl_day2.AutoSize = true;
            this.lbl_day2.Location = new System.Drawing.Point(700, 223);
            this.lbl_day2.Name = "lbl_day2";
            this.lbl_day2.Size = new System.Drawing.Size(48, 18);
            this.lbl_day2.TabIndex = 9;
            this.lbl_day2.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "MIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(899, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "MAX";
            // 
            // lbl_temp1_max
            // 
            this.lbl_temp1_max.AutoSize = true;
            this.lbl_temp1_max.Location = new System.Drawing.Point(899, 183);
            this.lbl_temp1_max.Name = "lbl_temp1_max";
            this.lbl_temp1_max.Size = new System.Drawing.Size(38, 18);
            this.lbl_temp1_max.TabIndex = 16;
            this.lbl_temp1_max.Text = "max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "MAX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(708, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "MIN";
            // 
            // lbl_temp2_max
            // 
            this.lbl_temp2_max.AutoSize = true;
            this.lbl_temp2_max.Location = new System.Drawing.Point(903, 313);
            this.lbl_temp2_max.Name = "lbl_temp2_max";
            this.lbl_temp2_max.Size = new System.Drawing.Size(38, 18);
            this.lbl_temp2_max.TabIndex = 19;
            this.lbl_temp2_max.Text = "max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 623);
            this.Controls.Add(this.lbl_temp2_max);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_temp1_max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_temp2_min);
            this.Controls.Add(this.lbl_wind2);
            this.Controls.Add(this.lbl_desc2);
            this.Controls.Add(this.lbl_condition2);
            this.Controls.Add(this.lbl_day2);
            this.Controls.Add(this.lbl_temp1_min);
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
        private System.Windows.Forms.Label lbl_temp1_min;
        private System.Windows.Forms.Label lbl_temp2_min;
        private System.Windows.Forms.Label lbl_wind2;
        private System.Windows.Forms.Label lbl_desc2;
        private System.Windows.Forms.Label lbl_condition2;
        private System.Windows.Forms.Label lbl_day2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_temp1_max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_temp2_max;
    }
}

