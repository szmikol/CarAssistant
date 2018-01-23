namespace CarAssistant
{
    partial class FormCreateUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCreateDriver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateLicRelease = new System.Windows.Forms.DateTimePicker();
            this.dateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.bDriverPhoto = new System.Windows.Forms.Button();
            this.pbUserImageLoad = new System.Windows.Forms.PictureBox();
            this.tbCreateCity = new System.Windows.Forms.TextBox();
            this.tbCreatePostCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCreateStreet = new System.Windows.Forms.TextBox();
            this.tbCreateLicenceNr = new System.Windows.Forms.TextBox();
            this.tbCreateIdnumb = new System.Windows.Forms.TextBox();
            this.tbCreateName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImageLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.bCreateDriver);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 400);
            this.panel1.TabIndex = 0;
            // 
            // bCreateDriver
            // 
            this.bCreateDriver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCreateDriver.ForeColor = System.Drawing.Color.White;
            this.bCreateDriver.Location = new System.Drawing.Point(300, 350);
            this.bCreateDriver.Name = "bCreateDriver";
            this.bCreateDriver.Size = new System.Drawing.Size(200, 50);
            this.bCreateDriver.TabIndex = 1;
            this.bCreateDriver.Text = "Create Driver";
            this.bCreateDriver.UseVisualStyleBackColor = true;
            this.bCreateDriver.Click += new System.EventHandler(this.bCreateDriver_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.dateLicRelease);
            this.panel2.Controls.Add(this.dateBirthDate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.bDriverPhoto);
            this.panel2.Controls.Add(this.pbUserImageLoad);
            this.panel2.Controls.Add(this.tbCreateCity);
            this.panel2.Controls.Add(this.tbCreatePostCode);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbCreateStreet);
            this.panel2.Controls.Add(this.tbCreateLicenceNr);
            this.panel2.Controls.Add(this.tbCreateIdnumb);
            this.panel2.Controls.Add(this.tbCreateName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(50, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 300);
            this.panel2.TabIndex = 0;
            // 
            // dateLicRelease
            // 
            this.dateLicRelease.CustomFormat = "dd-MM-yyyy";
            this.dateLicRelease.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLicRelease.Location = new System.Drawing.Point(153, 137);
            this.dateLicRelease.Name = "dateLicRelease";
            this.dateLicRelease.Size = new System.Drawing.Size(100, 22);
            this.dateLicRelease.TabIndex = 21;
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dateBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirthDate.Location = new System.Drawing.Point(153, 56);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Size = new System.Drawing.Size(100, 22);
            this.dateBirthDate.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(111, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Personal information:";
            // 
            // bDriverPhoto
            // 
            this.bDriverPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDriverPhoto.Location = new System.Drawing.Point(350, 255);
            this.bDriverPhoto.Name = "bDriverPhoto";
            this.bDriverPhoto.Size = new System.Drawing.Size(200, 29);
            this.bDriverPhoto.TabIndex = 18;
            this.bDriverPhoto.Text = "Load drivers photo";
            this.bDriverPhoto.UseVisualStyleBackColor = true;
            this.bDriverPhoto.Click += new System.EventHandler(this.bDriverPhoto_Click);
            // 
            // pbUserImageLoad
            // 
            this.pbUserImageLoad.BackColor = System.Drawing.Color.DimGray;
            this.pbUserImageLoad.Location = new System.Drawing.Point(350, 27);
            this.pbUserImageLoad.Name = "pbUserImageLoad";
            this.pbUserImageLoad.Size = new System.Drawing.Size(200, 224);
            this.pbUserImageLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserImageLoad.TabIndex = 17;
            this.pbUserImageLoad.TabStop = false;
            // 
            // tbCreateCity
            // 
            this.tbCreateCity.Location = new System.Drawing.Point(153, 262);
            this.tbCreateCity.Name = "tbCreateCity";
            this.tbCreateCity.Size = new System.Drawing.Size(100, 22);
            this.tbCreateCity.TabIndex = 16;
            // 
            // tbCreatePostCode
            // 
            this.tbCreatePostCode.Location = new System.Drawing.Point(153, 234);
            this.tbCreatePostCode.Name = "tbCreatePostCode";
            this.tbCreatePostCode.Size = new System.Drawing.Size(100, 22);
            this.tbCreatePostCode.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Post code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Street:";
            // 
            // tbCreateStreet
            // 
            this.tbCreateStreet.Location = new System.Drawing.Point(153, 207);
            this.tbCreateStreet.Name = "tbCreateStreet";
            this.tbCreateStreet.Size = new System.Drawing.Size(100, 22);
            this.tbCreateStreet.TabIndex = 11;
            // 
            // tbCreateLicenceNr
            // 
            this.tbCreateLicenceNr.Location = new System.Drawing.Point(153, 109);
            this.tbCreateLicenceNr.Name = "tbCreateLicenceNr";
            this.tbCreateLicenceNr.Size = new System.Drawing.Size(100, 22);
            this.tbCreateLicenceNr.TabIndex = 10;
            // 
            // tbCreateIdnumb
            // 
            this.tbCreateIdnumb.Location = new System.Drawing.Point(153, 81);
            this.tbCreateIdnumb.Name = "tbCreateIdnumb";
            this.tbCreateIdnumb.Size = new System.Drawing.Size(100, 22);
            this.tbCreateIdnumb.TabIndex = 8;
            // 
            // tbCreateName
            // 
            this.tbCreateName.Location = new System.Drawing.Point(153, 27);
            this.tbCreateName.Name = "tbCreateName";
            this.tbCreateName.Size = new System.Drawing.Size(100, 22);
            this.tbCreateName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(107, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address of residence:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Licence release date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Licence number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birth date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // FormCreateUser
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.panel1);
            this.Name = "FormCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create user";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImageLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bCreateDriver;
        private System.Windows.Forms.TextBox tbCreateStreet;
        private System.Windows.Forms.TextBox tbCreateLicenceNr;
        private System.Windows.Forms.TextBox tbCreateIdnumb;
        private System.Windows.Forms.TextBox tbCreateName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCreateCity;
        private System.Windows.Forms.TextBox tbCreatePostCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bDriverPhoto;
        private System.Windows.Forms.PictureBox pbUserImageLoad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateBirthDate;
        private System.Windows.Forms.DateTimePicker dateLicRelease;
    }
}