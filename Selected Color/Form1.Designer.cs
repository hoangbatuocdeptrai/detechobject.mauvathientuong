namespace Selected_Color
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IbIRGBValues = new System.Windows.Forms.Label();
            this.IbISmallScreen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tblRedValue = new System.Windows.Forms.TextBox();
            this.tblGreenValues = new System.Windows.Forms.TextBox();
            this.tblBlueValues = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // IbIRGBValues
            // 
            this.IbIRGBValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IbIRGBValues.Location = new System.Drawing.Point(260, 224);
            this.IbIRGBValues.Name = "IbIRGBValues";
            this.IbIRGBValues.Size = new System.Drawing.Size(238, 33);
            this.IbIRGBValues.TabIndex = 1;
            // 
            // IbISmallScreen
            // 
            this.IbISmallScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IbISmallScreen.Location = new System.Drawing.Point(531, 224);
            this.IbISmallScreen.Name = "IbISmallScreen";
            this.IbISmallScreen.Size = new System.Drawing.Size(71, 33);
            this.IbISmallScreen.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tblBlueValues);
            this.groupBox1.Controls.Add(this.tblGreenValues);
            this.groupBox1.Controls.Add(this.tblRedValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(195, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "selector control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Blue";
            // 
            // tblRedValue
            // 
            this.tblRedValue.Location = new System.Drawing.Point(130, 39);
            this.tblRedValue.Name = "tblRedValue";
            this.tblRedValue.Size = new System.Drawing.Size(154, 22);
            this.tblRedValue.TabIndex = 1;
            // 
            // tblGreenValues
            // 
            this.tblGreenValues.Location = new System.Drawing.Point(130, 91);
            this.tblGreenValues.Name = "tblGreenValues";
            this.tblGreenValues.Size = new System.Drawing.Size(154, 22);
            this.tblGreenValues.TabIndex = 1;
            // 
            // tblBlueValues
            // 
            this.tblBlueValues.Location = new System.Drawing.Point(130, 140);
            this.tblBlueValues.Name = "tblBlueValues";
            this.tblBlueValues.Size = new System.Drawing.Size(154, 22);
            this.tblBlueValues.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(308, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 123);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IbISmallScreen);
            this.Controls.Add(this.IbIRGBValues);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IbIRGBValues;
        private System.Windows.Forms.Label IbISmallScreen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tblBlueValues;
        private System.Windows.Forms.TextBox tblGreenValues;
        private System.Windows.Forms.TextBox tblRedValue;
        private System.Windows.Forms.Panel panel1;
    }
}

