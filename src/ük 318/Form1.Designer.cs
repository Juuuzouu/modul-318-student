namespace ÜK_318
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonZugverlauf = new System.Windows.Forms.Button();
            this.buttonAbfahrtstafel = new System.Windows.Forms.Button();
            this.SBLogo = new System.Windows.Forms.PictureBox();
            this.buttonStartEndStation = new System.Windows.Forms.Button();
            this.panelTitleBar1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SBLogo)).BeginInit();
            this.panelTitleBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.panelTitleBar);
            this.panelMenu.Controls.Add(this.buttonZugverlauf);
            this.panelMenu.Controls.Add(this.buttonAbfahrtstafel);
            this.panelMenu.Controls.Add(this.SBLogo);
            this.panelMenu.Controls.Add(this.buttonStartEndStation);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(215, 400);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Location = new System.Drawing.Point(213, 2);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(662, 62);
            this.panelTitleBar.TabIndex = 1;
            // 
            // buttonZugverlauf
            // 
            this.buttonZugverlauf.FlatAppearance.BorderSize = 0;
            this.buttonZugverlauf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZugverlauf.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonZugverlauf.ForeColor = System.Drawing.Color.White;
            this.buttonZugverlauf.Location = new System.Drawing.Point(0, 249);
            this.buttonZugverlauf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonZugverlauf.Name = "buttonZugverlauf";
            this.buttonZugverlauf.Size = new System.Drawing.Size(218, 86);
            this.buttonZugverlauf.TabIndex = 4;
            this.buttonZugverlauf.Text = "Zugverlauf";
            this.buttonZugverlauf.UseVisualStyleBackColor = true;
            this.buttonZugverlauf.Click += new System.EventHandler(this.buttonZugverlauf_Click);
            // 
            // buttonAbfahrtstafel
            // 
            this.buttonAbfahrtstafel.FlatAppearance.BorderSize = 0;
            this.buttonAbfahrtstafel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbfahrtstafel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAbfahrtstafel.ForeColor = System.Drawing.Color.White;
            this.buttonAbfahrtstafel.Location = new System.Drawing.Point(0, 166);
            this.buttonAbfahrtstafel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAbfahrtstafel.Name = "buttonAbfahrtstafel";
            this.buttonAbfahrtstafel.Size = new System.Drawing.Size(218, 86);
            this.buttonAbfahrtstafel.TabIndex = 3;
            this.buttonAbfahrtstafel.Text = "Abfahrtstafel";
            this.buttonAbfahrtstafel.UseVisualStyleBackColor = true;
            this.buttonAbfahrtstafel.Click += new System.EventHandler(this.buttonAbfahrtstafel_Click);
            // 
            // SBLogo
            // 
            this.SBLogo.Image = ((System.Drawing.Image)(resources.GetObject("SBLogo.Image")));
            this.SBLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("SBLogo.InitialImage")));
            this.SBLogo.Location = new System.Drawing.Point(0, -4);
            this.SBLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SBLogo.Name = "SBLogo";
            this.SBLogo.Size = new System.Drawing.Size(129, 93);
            this.SBLogo.TabIndex = 1;
            this.SBLogo.TabStop = false;
            // 
            // buttonStartEndStation
            // 
            this.buttonStartEndStation.FlatAppearance.BorderSize = 0;
            this.buttonStartEndStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartEndStation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStartEndStation.ForeColor = System.Drawing.Color.White;
            this.buttonStartEndStation.Location = new System.Drawing.Point(0, 82);
            this.buttonStartEndStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartEndStation.Name = "buttonStartEndStation";
            this.buttonStartEndStation.Size = new System.Drawing.Size(218, 86);
            this.buttonStartEndStation.TabIndex = 2;
            this.buttonStartEndStation.Text = "Start-End Station";
            this.buttonStartEndStation.UseVisualStyleBackColor = true;
            this.buttonStartEndStation.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTitleBar1
            // 
            this.panelTitleBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitleBar1.Controls.Add(this.panelDesktop);
            this.panelTitleBar1.Controls.Add(this.labelTitle);
            this.panelTitleBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitleBar1.Location = new System.Drawing.Point(215, 2);
            this.panelTitleBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar1.Name = "panelTitleBar1";
            this.panelTitleBar1.Size = new System.Drawing.Size(716, 395);
            this.panelTitleBar1.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(0, 67);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(712, 328);
            this.panelDesktop.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(254, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(121, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Startseite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 400);
            this.Controls.Add(this.panelTitleBar1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SBLogo)).EndInit();
            this.panelTitleBar1.ResumeLayout(false);
            this.panelTitleBar1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button buttonZugverlauf;
        private Button buttonAbfahrtstafel;
        private Button buttonStartEndStation;
        private PictureBox SBLogo;
        private Panel panelTitleBar;
        private Panel panelTitleBar1;
        private Label labelTitle;
        private Panel panelDesktop;
    }
}