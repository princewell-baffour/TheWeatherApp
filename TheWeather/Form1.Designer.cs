
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.lbl_cond = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_0wind = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_0maxTemp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_0minTemp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_condition3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_wind3 = new System.Windows.Forms.Label();
            this.lbl_temp3_max = new System.Windows.Forms.Label();
            this.lbl_desc3 = new System.Windows.Forms.Label();
            this.lbl_temp3_min = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_day3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_cityName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cityName.ForeColor = System.Drawing.Color.White;
            this.lbl_cityName.Location = new System.Drawing.Point(13, 16);
            this.lbl_cityName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(53, 25);
            this.lbl_cityName.TabIndex = 0;
            this.lbl_cityName.Text = "City";
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp.ForeColor = System.Drawing.Color.White;
            this.lbl_Temp.Location = new System.Drawing.Point(13, 45);
            this.lbl_Temp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(27, 25);
            this.lbl_Temp.TabIndex = 1;
            this.lbl_Temp.Text = "C";
            // 
            // lbl_cond
            // 
            this.lbl_cond.AutoSize = true;
            this.lbl_cond.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cond.ForeColor = System.Drawing.Color.White;
            this.lbl_cond.Location = new System.Drawing.Point(13, 81);
            this.lbl_cond.Name = "lbl_cond";
            this.lbl_cond.Size = new System.Drawing.Size(90, 24);
            this.lbl_cond.TabIndex = 2;
            this.lbl_cond.Text = "Condition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forecast";
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.BackColor = System.Drawing.Color.Transparent;
            this.lbl_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_days.ForeColor = System.Drawing.Color.White;
            this.lbl_days.Location = new System.Drawing.Point(155, 10);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(70, 29);
            this.lbl_days.TabIndex = 4;
            this.lbl_days.Text = "Days";
            // 
            // lbl_condition
            // 
            this.lbl_condition.AutoSize = true;
            this.lbl_condition.BackColor = System.Drawing.Color.Transparent;
            this.lbl_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_condition.ForeColor = System.Drawing.Color.White;
            this.lbl_condition.Location = new System.Drawing.Point(18, 55);
            this.lbl_condition.Name = "lbl_condition";
            this.lbl_condition.Size = new System.Drawing.Size(99, 24);
            this.lbl_condition.TabIndex = 5;
            this.lbl_condition.Text = "Conditions";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(234, 55);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(104, 24);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Description";
            // 
            // lbl_wind
            // 
            this.lbl_wind.AutoSize = true;
            this.lbl_wind.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wind.ForeColor = System.Drawing.Color.White;
            this.lbl_wind.Location = new System.Drawing.Point(294, 90);
            this.lbl_wind.Name = "lbl_wind";
            this.lbl_wind.Size = new System.Drawing.Size(51, 24);
            this.lbl_wind.TabIndex = 7;
            this.lbl_wind.Text = "km/h";
            // 
            // lbl_temp1_min
            // 
            this.lbl_temp1_min.AutoSize = true;
            this.lbl_temp1_min.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp1_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp1_min.ForeColor = System.Drawing.Color.White;
            this.lbl_temp1_min.Location = new System.Drawing.Point(76, 90);
            this.lbl_temp1_min.Name = "lbl_temp1_min";
            this.lbl_temp1_min.Size = new System.Drawing.Size(41, 24);
            this.lbl_temp1_min.TabIndex = 8;
            this.lbl_temp1_min.Text = "min";
            // 
            // lbl_temp2_min
            // 
            this.lbl_temp2_min.AutoSize = true;
            this.lbl_temp2_min.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp2_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp2_min.ForeColor = System.Drawing.Color.White;
            this.lbl_temp2_min.Location = new System.Drawing.Point(65, 96);
            this.lbl_temp2_min.Name = "lbl_temp2_min";
            this.lbl_temp2_min.Size = new System.Drawing.Size(41, 24);
            this.lbl_temp2_min.TabIndex = 13;
            this.lbl_temp2_min.Text = "min";
            // 
            // lbl_wind2
            // 
            this.lbl_wind2.AutoSize = true;
            this.lbl_wind2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wind2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wind2.ForeColor = System.Drawing.Color.White;
            this.lbl_wind2.Location = new System.Drawing.Point(292, 96);
            this.lbl_wind2.Name = "lbl_wind2";
            this.lbl_wind2.Size = new System.Drawing.Size(51, 24);
            this.lbl_wind2.TabIndex = 12;
            this.lbl_wind2.Text = "km/h";
            // 
            // lbl_desc2
            // 
            this.lbl_desc2.AutoSize = true;
            this.lbl_desc2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc2.ForeColor = System.Drawing.Color.White;
            this.lbl_desc2.Location = new System.Drawing.Point(235, 59);
            this.lbl_desc2.Name = "lbl_desc2";
            this.lbl_desc2.Size = new System.Drawing.Size(104, 24);
            this.lbl_desc2.TabIndex = 11;
            this.lbl_desc2.Text = "Description";
            // 
            // lbl_condition2
            // 
            this.lbl_condition2.AutoSize = true;
            this.lbl_condition2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_condition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_condition2.ForeColor = System.Drawing.Color.White;
            this.lbl_condition2.Location = new System.Drawing.Point(13, 59);
            this.lbl_condition2.Name = "lbl_condition2";
            this.lbl_condition2.Size = new System.Drawing.Size(99, 24);
            this.lbl_condition2.TabIndex = 10;
            this.lbl_condition2.Text = "Conditions";
            // 
            // lbl_day2
            // 
            this.lbl_day2.AutoSize = true;
            this.lbl_day2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day2.ForeColor = System.Drawing.Color.White;
            this.lbl_day2.Location = new System.Drawing.Point(161, 13);
            this.lbl_day2.Name = "lbl_day2";
            this.lbl_day2.Size = new System.Drawing.Size(70, 29);
            this.lbl_day2.TabIndex = 9;
            this.lbl_day2.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "MIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "MAX";
            // 
            // lbl_temp1_max
            // 
            this.lbl_temp1_max.AutoSize = true;
            this.lbl_temp1_max.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp1_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp1_max.ForeColor = System.Drawing.Color.White;
            this.lbl_temp1_max.Location = new System.Drawing.Point(76, 122);
            this.lbl_temp1_max.Name = "lbl_temp1_max";
            this.lbl_temp1_max.Size = new System.Drawing.Size(46, 24);
            this.lbl_temp1_max.TabIndex = 16;
            this.lbl_temp1_max.Text = "max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "MAX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "MIN";
            // 
            // lbl_temp2_max
            // 
            this.lbl_temp2_max.AutoSize = true;
            this.lbl_temp2_max.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp2_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp2_max.ForeColor = System.Drawing.Color.White;
            this.lbl_temp2_max.Location = new System.Drawing.Point(66, 124);
            this.lbl_temp2_max.Name = "lbl_temp2_max";
            this.lbl_temp2_max.Size = new System.Drawing.Size(46, 24);
            this.lbl_temp2_max.TabIndex = 19;
            this.lbl_temp2_max.Text = "max";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.lbl_0wind);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lbl_0maxTemp);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_0minTemp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_cond);
            this.panel1.Controls.Add(this.lbl_Temp);
            this.panel1.Controls.Add(this.lbl_cityName);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 169);
            this.panel1.TabIndex = 20;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(166, 49);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 20);
            this.lbl_date.TabIndex = 9;
            // 
            // lbl_0wind
            // 
            this.lbl_0wind.AutoSize = true;
            this.lbl_0wind.BackColor = System.Drawing.Color.Transparent;
            this.lbl_0wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_0wind.ForeColor = System.Drawing.Color.White;
            this.lbl_0wind.Location = new System.Drawing.Point(228, 85);
            this.lbl_0wind.Name = "lbl_0wind";
            this.lbl_0wind.Size = new System.Drawing.Size(51, 24);
            this.lbl_0wind.TabIndex = 8;
            this.lbl_0wind.Text = "km/h";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(166, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 24);
            this.label14.TabIndex = 7;
            this.label14.Text = "WIND";
            // 
            // lbl_0maxTemp
            // 
            this.lbl_0maxTemp.AutoSize = true;
            this.lbl_0maxTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_0maxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_0maxTemp.ForeColor = System.Drawing.Color.White;
            this.lbl_0maxTemp.Location = new System.Drawing.Point(217, 120);
            this.lbl_0maxTemp.Name = "lbl_0maxTemp";
            this.lbl_0maxTemp.Size = new System.Drawing.Size(46, 24);
            this.lbl_0maxTemp.TabIndex = 6;
            this.lbl_0maxTemp.Text = "max";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(166, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "MAX";
            // 
            // lbl_0minTemp
            // 
            this.lbl_0minTemp.AutoSize = true;
            this.lbl_0minTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_0minTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_0minTemp.ForeColor = System.Drawing.Color.White;
            this.lbl_0minTemp.Location = new System.Drawing.Point(61, 120);
            this.lbl_0minTemp.Name = "lbl_0minTemp";
            this.lbl_0minTemp.Size = new System.Drawing.Size(41, 24);
            this.lbl_0minTemp.TabIndex = 4;
            this.lbl_0minTemp.Tag = "";
            this.lbl_0minTemp.Text = "min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "MIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lbl_condition3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lbl_wind3);
            this.panel2.Controls.Add(this.lbl_temp3_max);
            this.panel2.Controls.Add(this.lbl_desc3);
            this.panel2.Controls.Add(this.lbl_temp3_min);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.lbl_day3);
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(650, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 163);
            this.panel2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(239, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "WIND";
            // 
            // lbl_condition3
            // 
            this.lbl_condition3.AutoSize = true;
            this.lbl_condition3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_condition3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_condition3.ForeColor = System.Drawing.Color.White;
            this.lbl_condition3.Location = new System.Drawing.Point(16, 59);
            this.lbl_condition3.Name = "lbl_condition3";
            this.lbl_condition3.Size = new System.Drawing.Size(99, 24);
            this.lbl_condition3.TabIndex = 21;
            this.lbl_condition3.Text = "Conditions";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "MIN";
            // 
            // lbl_wind3
            // 
            this.lbl_wind3.AutoSize = true;
            this.lbl_wind3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wind3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wind3.ForeColor = System.Drawing.Color.White;
            this.lbl_wind3.Location = new System.Drawing.Point(298, 96);
            this.lbl_wind3.Name = "lbl_wind3";
            this.lbl_wind3.Size = new System.Drawing.Size(51, 24);
            this.lbl_wind3.TabIndex = 23;
            this.lbl_wind3.Text = "km/h";
            // 
            // lbl_temp3_max
            // 
            this.lbl_temp3_max.AutoSize = true;
            this.lbl_temp3_max.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp3_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp3_max.ForeColor = System.Drawing.Color.White;
            this.lbl_temp3_max.Location = new System.Drawing.Point(68, 124);
            this.lbl_temp3_max.Name = "lbl_temp3_max";
            this.lbl_temp3_max.Size = new System.Drawing.Size(46, 24);
            this.lbl_temp3_max.TabIndex = 27;
            this.lbl_temp3_max.Text = "max";
            // 
            // lbl_desc3
            // 
            this.lbl_desc3.AutoSize = true;
            this.lbl_desc3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc3.ForeColor = System.Drawing.Color.White;
            this.lbl_desc3.Location = new System.Drawing.Point(239, 59);
            this.lbl_desc3.Name = "lbl_desc3";
            this.lbl_desc3.Size = new System.Drawing.Size(104, 24);
            this.lbl_desc3.TabIndex = 22;
            this.lbl_desc3.Text = "Description";
            // 
            // lbl_temp3_min
            // 
            this.lbl_temp3_min.AutoSize = true;
            this.lbl_temp3_min.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp3_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp3_min.ForeColor = System.Drawing.Color.White;
            this.lbl_temp3_min.Location = new System.Drawing.Point(67, 96);
            this.lbl_temp3_min.Name = "lbl_temp3_min";
            this.lbl_temp3_min.Size = new System.Drawing.Size(41, 24);
            this.lbl_temp3_min.TabIndex = 24;
            this.lbl_temp3_min.Text = "min";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(16, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 24);
            this.label16.TabIndex = 26;
            this.label16.Text = "MAX";
            // 
            // lbl_day3
            // 
            this.lbl_day3.AutoSize = true;
            this.lbl_day3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day3.ForeColor = System.Drawing.Color.White;
            this.lbl_day3.Location = new System.Drawing.Point(161, 17);
            this.lbl_day3.Name = "lbl_day3";
            this.lbl_day3.Size = new System.Drawing.Size(70, 29);
            this.lbl_day3.TabIndex = 10;
            this.lbl_day3.Text = "Days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(234, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "WIND";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lbl_day2);
            this.panel3.Controls.Add(this.lbl_condition2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lbl_wind2);
            this.panel3.Controls.Add(this.lbl_temp2_max);
            this.panel3.Controls.Add(this.lbl_desc2);
            this.panel3.Controls.Add(this.lbl_temp2_min);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(650, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 165);
            this.panel3.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(234, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "WIND";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(667, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 44);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lbl_days);
            this.panel5.Controls.Add(this.lbl_condition);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lbl_temp1_min);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lbl_temp1_max);
            this.panel5.Controls.Add(this.lbl_wind);
            this.panel5.Controls.Add(this.lbl_description);
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(650, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(395, 162);
            this.panel5.TabIndex = 18;
            // 
            // txt_cityName
            // 
            this.txt_cityName.Location = new System.Drawing.Point(23, 48);
            this.txt_cityName.Name = "txt_cityName";
            this.txt_cityName.Size = new System.Drawing.Size(206, 26);
            this.txt_cityName.TabIndex = 24;
            this.txt_cityName.TextChanged += new System.EventHandler(this.txt_cityName_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl8);
            this.panel6.Controls.Add(this.txt_cityName);
            this.panel6.Location = new System.Drawing.Point(26, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 87);
            this.panel6.TabIndex = 26;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Transparent;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(66, 21);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(88, 20);
            this.lbl8.TabIndex = 25;
            this.lbl8.Text = "Enter City";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(51, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "Save Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(568, 183);
            this.dataGridView1.TabIndex = 29;
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(26, 592);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(166, 26);
            this.btndel.TabIndex = 30;
            this.btndel.Text = "Clear Saved Data";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 623);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "TheWeather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_cityName;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.Label lbl_cond;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_condition3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_wind3;
        private System.Windows.Forms.Label lbl_temp3_max;
        private System.Windows.Forms.Label lbl_desc3;
        private System.Windows.Forms.Label lbl_temp3_min;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_day3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_cityName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_0wind;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_0maxTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_0minTemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndel;
    }
}

