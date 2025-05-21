namespace WeatherAppWithAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TBCity = new TextBox();
            btnSearch = new Button();
            sunset = new Label();
            sunrise = new Label();
            labDetail = new Label();
            labCondition = new Label();
            labSunset = new Label();
            labSunrise = new Label();
            labWind = new Label();
            Pressure = new Label();
            labPressure = new Label();
            labWindSpeed = new Label();
            picIcon = new PictureBox();
            FeelsLike = new Label();
            Temp = new Label();
            MinTemp = new Label();
            MaxTemp = new Label();
            labMinTemp = new Label();
            labMaxTemp = new Label();
            labFeelsLike = new Label();
            labTemp = new Label();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Turquoise;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(71, 53);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 0;
            label1.Text = "City:";
            label1.Click += label1_Click;
            // 
            // TBCity
            // 
            TBCity.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TBCity.Location = new Point(123, 45);
            TBCity.Name = "TBCity";
            TBCity.Size = new Size(234, 31);
            TBCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Turquoise;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(373, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // sunset
            // 
            sunset.AutoSize = true;
            sunset.BackColor = Color.Turquoise;
            sunset.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sunset.ForeColor = Color.Black;
            sunset.Location = new Point(432, 334);
            sunset.Name = "sunset";
            sunset.Size = new Size(64, 23);
            sunset.TabIndex = 3;
            sunset.Text = "Sunset";
            // 
            // sunrise
            // 
            sunrise.AutoSize = true;
            sunrise.BackColor = Color.Turquoise;
            sunrise.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sunrise.ForeColor = Color.Black;
            sunrise.Location = new Point(432, 297);
            sunrise.Name = "sunrise";
            sunrise.Size = new Size(69, 23);
            sunrise.TabIndex = 4;
            sunrise.Text = "Sunrise";
            // 
            // labDetail
            // 
            labDetail.AutoSize = true;
            labDetail.BackColor = Color.Turquoise;
            labDetail.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labDetail.ForeColor = Color.Black;
            labDetail.Location = new Point(71, 167);
            labDetail.Name = "labDetail";
            labDetail.Size = new Size(66, 23);
            labDetail.TabIndex = 5;
            labDetail.Text = "Details";
            // 
            // labCondition
            // 
            labCondition.AutoSize = true;
            labCondition.BackColor = Color.Turquoise;
            labCondition.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labCondition.ForeColor = Color.Black;
            labCondition.Location = new Point(71, 132);
            labCondition.Name = "labCondition";
            labCondition.Size = new Size(86, 23);
            labCondition.TabIndex = 6;
            labCondition.Text = "Condition";
            // 
            // labSunset
            // 
            labSunset.AutoSize = true;
            labSunset.BackColor = Color.Turquoise;
            labSunset.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labSunset.ForeColor = Color.Black;
            labSunset.Location = new Point(544, 334);
            labSunset.Name = "labSunset";
            labSunset.Size = new Size(42, 23);
            labSunset.TabIndex = 7;
            labSunset.Text = "N/A";
            // 
            // labSunrise
            // 
            labSunrise.AutoSize = true;
            labSunrise.BackColor = Color.Turquoise;
            labSunrise.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labSunrise.ForeColor = Color.Black;
            labSunrise.Location = new Point(544, 297);
            labSunrise.Name = "labSunrise";
            labSunrise.Size = new Size(42, 23);
            labSunrise.TabIndex = 8;
            labSunrise.Text = "N/A";
            // 
            // labWind
            // 
            labWind.AutoSize = true;
            labWind.BackColor = Color.Turquoise;
            labWind.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labWind.ForeColor = Color.Black;
            labWind.Location = new Point(432, 214);
            labWind.Name = "labWind";
            labWind.Size = new Size(105, 23);
            labWind.TabIndex = 9;
            labWind.Text = "Wind Speed";
            // 
            // Pressure
            // 
            Pressure.AutoSize = true;
            Pressure.BackColor = Color.Turquoise;
            Pressure.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pressure.ForeColor = Color.Black;
            Pressure.Location = new Point(432, 255);
            Pressure.Name = "Pressure";
            Pressure.Size = new Size(80, 23);
            Pressure.TabIndex = 10;
            Pressure.Text = "Pressure";
            // 
            // labPressure
            // 
            labPressure.AutoSize = true;
            labPressure.BackColor = Color.Turquoise;
            labPressure.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labPressure.ForeColor = Color.Black;
            labPressure.Location = new Point(544, 255);
            labPressure.Name = "labPressure";
            labPressure.Size = new Size(42, 23);
            labPressure.TabIndex = 11;
            labPressure.Text = "N/A";
            // 
            // labWindSpeed
            // 
            labWindSpeed.AutoSize = true;
            labWindSpeed.BackColor = Color.Turquoise;
            labWindSpeed.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labWindSpeed.ForeColor = Color.Black;
            labWindSpeed.Location = new Point(544, 214);
            labWindSpeed.Name = "labWindSpeed";
            labWindSpeed.Size = new Size(42, 23);
            labWindSpeed.TabIndex = 12;
            labWindSpeed.Text = "N/A";
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.Transparent;
            picIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picIcon.Location = new Point(71, 79);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(100, 50);
            picIcon.TabIndex = 13;
            picIcon.TabStop = false;
            // 
            // FeelsLike
            // 
            FeelsLike.AutoSize = true;
            FeelsLike.BackColor = Color.Turquoise;
            FeelsLike.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FeelsLike.ForeColor = Color.Black;
            FeelsLike.Location = new Point(66, 255);
            FeelsLike.Name = "FeelsLike";
            FeelsLike.Size = new Size(87, 23);
            FeelsLike.TabIndex = 14;
            FeelsLike.Text = "Feels Like";
            // 
            // Temp
            // 
            Temp.AutoSize = true;
            Temp.BackColor = Color.Turquoise;
            Temp.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Temp.ForeColor = Color.Black;
            Temp.Location = new Point(66, 214);
            Temp.Name = "Temp";
            Temp.Size = new Size(177, 23);
            Temp.TabIndex = 15;
            Temp.Text = "Current Temperature";
            // 
            // MinTemp
            // 
            MinTemp.AutoSize = true;
            MinTemp.BackColor = Color.Turquoise;
            MinTemp.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinTemp.ForeColor = Color.Black;
            MinTemp.Location = new Point(66, 334);
            MinTemp.Name = "MinTemp";
            MinTemp.Size = new Size(88, 23);
            MinTemp.TabIndex = 16;
            MinTemp.Text = "Min Temp";
            // 
            // MaxTemp
            // 
            MaxTemp.AutoSize = true;
            MaxTemp.BackColor = Color.Turquoise;
            MaxTemp.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaxTemp.ForeColor = Color.Black;
            MaxTemp.Location = new Point(66, 297);
            MaxTemp.Name = "MaxTemp";
            MaxTemp.Size = new Size(91, 23);
            MaxTemp.TabIndex = 17;
            MaxTemp.Text = "Max Temp";
            // 
            // labMinTemp
            // 
            labMinTemp.AutoSize = true;
            labMinTemp.BackColor = Color.Turquoise;
            labMinTemp.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labMinTemp.ForeColor = Color.Black;
            labMinTemp.Location = new Point(274, 334);
            labMinTemp.Name = "labMinTemp";
            labMinTemp.Size = new Size(42, 23);
            labMinTemp.TabIndex = 18;
            labMinTemp.Text = "N/A";
            // 
            // labMaxTemp
            // 
            labMaxTemp.AutoSize = true;
            labMaxTemp.BackColor = Color.Turquoise;
            labMaxTemp.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labMaxTemp.ForeColor = Color.Black;
            labMaxTemp.Location = new Point(274, 297);
            labMaxTemp.Name = "labMaxTemp";
            labMaxTemp.Size = new Size(42, 23);
            labMaxTemp.TabIndex = 19;
            labMaxTemp.Text = "N/A";
            // 
            // labFeelsLike
            // 
            labFeelsLike.AutoSize = true;
            labFeelsLike.BackColor = Color.Turquoise;
            labFeelsLike.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labFeelsLike.ForeColor = Color.Black;
            labFeelsLike.Location = new Point(274, 255);
            labFeelsLike.Name = "labFeelsLike";
            labFeelsLike.Size = new Size(42, 23);
            labFeelsLike.TabIndex = 20;
            labFeelsLike.Text = "N/A";
            // 
            // labTemp
            // 
            labTemp.AutoSize = true;
            labTemp.BackColor = Color.Turquoise;
            labTemp.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labTemp.ForeColor = Color.Black;
            labTemp.Location = new Point(274, 214);
            labTemp.Name = "labTemp";
            labTemp.Size = new Size(42, 23);
            labTemp.TabIndex = 21;
            labTemp.Text = "N/A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(labTemp);
            Controls.Add(labFeelsLike);
            Controls.Add(labMaxTemp);
            Controls.Add(labMinTemp);
            Controls.Add(MaxTemp);
            Controls.Add(MinTemp);
            Controls.Add(Temp);
            Controls.Add(FeelsLike);
            Controls.Add(picIcon);
            Controls.Add(labWindSpeed);
            Controls.Add(labPressure);
            Controls.Add(Pressure);
            Controls.Add(labWind);
            Controls.Add(labSunrise);
            Controls.Add(labSunset);
            Controls.Add(labCondition);
            Controls.Add(labDetail);
            Controls.Add(sunrise);
            Controls.Add(sunset);
            Controls.Add(btnSearch);
            Controls.Add(TBCity);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBCity;
        private Button btnSearch;
        private Label sunset;
        private Label sunrise;
        private Label labDetail;
        private Label labCondition;
        private Label labSunset;
        private Label labSunrise;
        private Label labWind;
        private Label Pressure;
        private Label labPressure;
        private Label labWindSpeed;
        private PictureBox picIcon;
        private Label FeelsLike;
        private Label Temp;
        private Label MinTemp;
        private Label MaxTemp;
        private Label labMinTemp;
        private Label labMaxTemp;
        private Label labFeelsLike;
        private Label labTemp;
    }
}
