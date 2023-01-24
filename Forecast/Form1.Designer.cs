namespace Forecast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.MaxTempTextBox = new System.Windows.Forms.TextBox();
            this.MinTempTextBox = new System.Windows.Forms.TextBox();
            this.HumidityTextBox = new System.Windows.Forms.TextBox();
            this.SunriseTextBox = new System.Windows.Forms.TextBox();
            this.SunsetTextBox = new System.Windows.Forms.TextBox();
            this.MaxTempLabel = new System.Windows.Forms.Label();
            this.MinTemperatureLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.SunriseLabel = new System.Windows.Forms.Label();
            this.SunsetLabel = new System.Windows.Forms.Label();
            this.TempTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.BackgroundGIF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // CityTextBox
            // 
            this.CityTextBox.AcceptsReturn = true;
            this.CityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityTextBox.Location = new System.Drawing.Point(60, 50);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(300, 20);
            this.CityTextBox.TabIndex = 0;
            this.CityTextBox.Text = "City";
            this.CityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CityTextBox.Click += new System.EventHandler(this.ResetCityBox);
            this.CityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCityEnter);
            // 
            // MaxTempTextBox
            // 
            this.MaxTempTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxTempTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MaxTempTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaxTempTextBox.Location = new System.Drawing.Point(210, 100);
            this.MaxTempTextBox.Name = "MaxTempTextBox";
            this.MaxTempTextBox.Size = new System.Drawing.Size(150, 22);
            this.MaxTempTextBox.TabIndex = 1;
            // 
            // MinTempTextBox
            // 
            this.MinTempTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MinTempTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinTempTextBox.Location = new System.Drawing.Point(210, 150);
            this.MinTempTextBox.Name = "MinTempTextBox";
            this.MinTempTextBox.Size = new System.Drawing.Size(150, 22);
            this.MinTempTextBox.TabIndex = 2;
            // 
            // HumidityTextBox
            // 
            this.HumidityTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.HumidityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HumidityTextBox.Location = new System.Drawing.Point(210, 200);
            this.HumidityTextBox.Name = "HumidityTextBox";
            this.HumidityTextBox.Size = new System.Drawing.Size(150, 22);
            this.HumidityTextBox.TabIndex = 3;
            // 
            // SunriseTextBox
            // 
            this.SunriseTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SunriseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SunriseTextBox.Location = new System.Drawing.Point(210, 250);
            this.SunriseTextBox.Name = "SunriseTextBox";
            this.SunriseTextBox.Size = new System.Drawing.Size(150, 22);
            this.SunriseTextBox.TabIndex = 4;
            // 
            // SunsetTextBox
            // 
            this.SunsetTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SunsetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SunsetTextBox.Location = new System.Drawing.Point(210, 300);
            this.SunsetTextBox.Name = "SunsetTextBox";
            this.SunsetTextBox.Size = new System.Drawing.Size(150, 22);
            this.SunsetTextBox.TabIndex = 5;
            // 
            // MaxTempLabel
            // 
            this.MaxTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaxTempLabel.Location = new System.Drawing.Point(60, 100);
            this.MaxTempLabel.Name = "MaxTempLabel";
            this.MaxTempLabel.Size = new System.Drawing.Size(150, 20);
            this.MaxTempLabel.TabIndex = 6;
            this.MaxTempLabel.Text = "Max Temperature:";
            // 
            // MinTemperatureLabel
            // 
            this.MinTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinTemperatureLabel.Location = new System.Drawing.Point(60, 149);
            this.MinTemperatureLabel.Name = "MinTemperatureLabel";
            this.MinTemperatureLabel.Size = new System.Drawing.Size(150, 20);
            this.MinTemperatureLabel.TabIndex = 12;
            this.MinTemperatureLabel.Text = "Min Temperature:";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HumidityLabel.Location = new System.Drawing.Point(60, 200);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(150, 20);
            this.HumidityLabel.TabIndex = 13;
            this.HumidityLabel.Text = "Humidity:";
            // 
            // SunriseLabel
            // 
            this.SunriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SunriseLabel.Location = new System.Drawing.Point(60, 249);
            this.SunriseLabel.Name = "SunriseLabel";
            this.SunriseLabel.Size = new System.Drawing.Size(150, 20);
            this.SunriseLabel.TabIndex = 14;
            this.SunriseLabel.Text = "Sunrise(UTC):";
            // 
            // SunsetLabel
            // 
            this.SunsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SunsetLabel.Location = new System.Drawing.Point(60, 300);
            this.SunsetLabel.Name = "SunsetLabel";
            this.SunsetLabel.Size = new System.Drawing.Size(150, 20);
            this.SunsetLabel.TabIndex = 15;
            this.SunsetLabel.Text = "Sunset(UTC):";
            // 
            // TempTextBox
            // 
            this.TempTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TempTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TempTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TempTextBox.Location = new System.Drawing.Point(568, 100);
            this.TempTextBox.Name = "TempTextBox";
            this.TempTextBox.Size = new System.Drawing.Size(50, 22);
            this.TempTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(448, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Temperature:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(458, 298);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(160, 22);
            this.DescriptionTextBox.TabIndex = 18;
            this.DescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(458, 170);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(160, 122);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 11;
            this.picIcon.TabStop = false;
            // 
            // BackgroundGIF
            // 
            this.BackgroundGIF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundGIF.ErrorImage = null;
            this.BackgroundGIF.InitialImage = null;
            this.BackgroundGIF.Location = new System.Drawing.Point(0, 0);
            this.BackgroundGIF.Name = "BackgroundGIF";
            this.BackgroundGIF.Size = new System.Drawing.Size(684, 341);
            this.BackgroundGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundGIF.TabIndex = 19;
            this.BackgroundGIF.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 341);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TempTextBox);
            this.Controls.Add(this.SunsetLabel);
            this.Controls.Add(this.SunriseLabel);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.MinTemperatureLabel);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.MaxTempLabel);
            this.Controls.Add(this.SunsetTextBox);
            this.Controls.Add(this.SunriseTextBox);
            this.Controls.Add(this.HumidityTextBox);
            this.Controls.Add(this.MinTempTextBox);
            this.Controls.Add(this.MaxTempTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.BackgroundGIF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox MaxTempTextBox;
        private System.Windows.Forms.TextBox MinTempTextBox;
        private System.Windows.Forms.TextBox HumidityTextBox;
        private System.Windows.Forms.TextBox SunriseTextBox;
        private System.Windows.Forms.TextBox SunsetTextBox;
        private System.Windows.Forms.Label MaxTempLabel;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label MinTemperatureLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label SunriseLabel;
        private System.Windows.Forms.Label SunsetLabel;
        private System.Windows.Forms.TextBox TempTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.PictureBox BackgroundGIF;
    }
}

