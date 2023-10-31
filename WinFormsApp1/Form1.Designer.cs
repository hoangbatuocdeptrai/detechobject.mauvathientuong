namespace WinFormsApp1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openimg = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            detectToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            cameraToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            picbox = new PictureBox();
            pictureBox1 = new PictureBox();
            IblRGBValues = new Label();
            IblSmallScreen = new Label();
            groupBox1 = new GroupBox();
            panelSelectedScreen = new Panel();
            txtBlueValues = new TextBox();
            txtGreenValues = new TextBox();
            txtRedValues = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chụpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, detectToolStripMenuItem, cameraToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1161, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openimg, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openimg
            // 
            openimg.Name = "openimg";
            openimg.Size = new Size(103, 22);
            openimg.Text = "Open";
            openimg.Click += openimg_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // detectToolStripMenuItem
            // 
            detectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { greenToolStripMenuItem });
            detectToolStripMenuItem.Name = "detectToolStripMenuItem";
            detectToolStripMenuItem.Size = new Size(53, 20);
            detectToolStripMenuItem.Text = "Detect";
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(105, 22);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // cameraToolStripMenuItem
            // 
            cameraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, chụpToolStripMenuItem });
            cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            cameraToolStripMenuItem.Size = new Size(60, 20);
            cameraToolStripMenuItem.Text = "Camera";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // picbox
            // 
            picbox.Location = new Point(52, 49);
            picbox.Margin = new Padding(3, 2, 3, 2);
            picbox.Name = "picbox";
            picbox.Size = new Size(567, 380);
            picbox.TabIndex = 1;
            picbox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(741, 49);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // IblRGBValues
            // 
            IblRGBValues.BorderStyle = BorderStyle.FixedSingle;
            IblRGBValues.Location = new Point(707, 208);
            IblRGBValues.Name = "IblRGBValues";
            IblRGBValues.Size = new Size(140, 26);
            IblRGBValues.TabIndex = 3;
            IblRGBValues.Click += IblRGBValues_Click;
            // 
            // IblSmallScreen
            // 
            IblSmallScreen.BorderStyle = BorderStyle.FixedSingle;
            IblSmallScreen.Location = new Point(914, 208);
            IblSmallScreen.Name = "IblSmallScreen";
            IblSmallScreen.Size = new Size(70, 26);
            IblSmallScreen.TabIndex = 4;
            IblSmallScreen.Click += IblSmallScreen_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelSelectedScreen);
            groupBox1.Controls.Add(txtBlueValues);
            groupBox1.Controls.Add(txtGreenValues);
            groupBox1.Controls.Add(txtRedValues);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(654, 262);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(420, 133);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Color";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panelSelectedScreen
            // 
            panelSelectedScreen.Location = new Point(272, 19);
            panelSelectedScreen.Margin = new Padding(3, 2, 3, 2);
            panelSelectedScreen.Name = "panelSelectedScreen";
            panelSelectedScreen.Size = new Size(129, 94);
            panelSelectedScreen.TabIndex = 2;
            // 
            // txtBlueValues
            // 
            txtBlueValues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBlueValues.Location = new Point(95, 88);
            txtBlueValues.Margin = new Padding(3, 2, 3, 2);
            txtBlueValues.Name = "txtBlueValues";
            txtBlueValues.ReadOnly = true;
            txtBlueValues.Size = new Size(124, 23);
            txtBlueValues.TabIndex = 1;
            // 
            // txtGreenValues
            // 
            txtGreenValues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtGreenValues.Location = new Point(95, 55);
            txtGreenValues.Margin = new Padding(3, 2, 3, 2);
            txtGreenValues.Name = "txtGreenValues";
            txtGreenValues.ReadOnly = true;
            txtGreenValues.Size = new Size(124, 23);
            txtGreenValues.TabIndex = 1;
            // 
            // txtRedValues
            // 
            txtRedValues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtRedValues.Location = new Point(95, 19);
            txtRedValues.Margin = new Padding(3, 2, 3, 2);
            txtRedValues.Name = "txtRedValues";
            txtRedValues.ReadOnly = true;
            txtRedValues.Size = new Size(124, 23);
            txtRedValues.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(16, 93);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 0;
            label3.Text = "Blue";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(16, 60);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Green";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Red";
            // 
            // chụpToolStripMenuItem
            // 
            chụpToolStripMenuItem.Name = "chụpToolStripMenuItem";
            chụpToolStripMenuItem.Size = new Size(180, 22);
            chụpToolStripMenuItem.Text = "Chụp";
            chụpToolStripMenuItem.Click += chụpToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 450);
            Controls.Add(groupBox1);
            Controls.Add(IblSmallScreen);
            Controls.Add(IblRGBValues);
            Controls.Add(pictureBox1);
            Controls.Add(picbox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openimg;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox picbox;
        private ToolStripMenuItem detectToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label IblRGBValues;
        private Label IblSmallScreen;
        private GroupBox groupBox1;
        private Label label1;
        private Panel panelSelectedScreen;
        private TextBox txtBlueValues;
        private TextBox txtGreenValues;
        private TextBox txtRedValues;
        private Label label3;
        private Label label2;
        private ToolStripMenuItem cameraToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem chụpToolStripMenuItem;
    }
}