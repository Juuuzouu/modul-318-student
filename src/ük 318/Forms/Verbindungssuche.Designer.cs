namespace ÜK_318.Forms
{
    partial class Verbindungssuche
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.listBoxKommentar = new System.Windows.Forms.ListBox();
            this.labelKommentar = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelVerlauf = new System.Windows.Forms.Label();
            this.listBoxVerlauf = new System.Windows.Forms.ListBox();
            this.buttonSuche = new System.Windows.Forms.Button();
            this.labelVorschläge = new System.Windows.Forms.Label();
            this.textBoxEndstation = new System.Windows.Forms.TextBox();
            this.textBoxStartstation = new System.Windows.Forms.TextBox();
            this.labelEndstation = new System.Windows.Forms.Label();
            this.labelStartstation = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.buttonSend = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBoxDrop = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(694, 410);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(417, 165);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(295, 27);
            this.textBoxEMail.TabIndex = 26;
            // 
            // listBoxKommentar
            // 
            this.listBoxKommentar.FormattingEnabled = true;
            this.listBoxKommentar.ItemHeight = 20;
            this.listBoxKommentar.Location = new System.Drawing.Point(417, 229);
            this.listBoxKommentar.Name = "listBoxKommentar";
            this.listBoxKommentar.Size = new System.Drawing.Size(295, 124);
            this.listBoxKommentar.TabIndex = 25;
            // 
            // labelKommentar
            // 
            this.labelKommentar.AutoSize = true;
            this.labelKommentar.Location = new System.Drawing.Point(417, 206);
            this.labelKommentar.Name = "labelKommentar";
            this.labelKommentar.Size = new System.Drawing.Size(87, 20);
            this.labelKommentar.TabIndex = 24;
            this.labelKommentar.Text = "Kommentar";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(417, 136);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(52, 20);
            this.labelEMail.TabIndex = 23;
            this.labelEMail.Text = "E-Mail";
            // 
            // labelVerlauf
            // 
            this.labelVerlauf.AutoSize = true;
            this.labelVerlauf.Location = new System.Drawing.Point(417, 21);
            this.labelVerlauf.Name = "labelVerlauf";
            this.labelVerlauf.Size = new System.Drawing.Size(55, 20);
            this.labelVerlauf.TabIndex = 22;
            this.labelVerlauf.Text = "Verlauf";
            // 
            // listBoxVerlauf
            // 
            this.listBoxVerlauf.FormattingEnabled = true;
            this.listBoxVerlauf.ItemHeight = 20;
            this.listBoxVerlauf.Location = new System.Drawing.Point(417, 45);
            this.listBoxVerlauf.Name = "listBoxVerlauf";
            this.listBoxVerlauf.Size = new System.Drawing.Size(295, 64);
            this.listBoxVerlauf.TabIndex = 21;
            // 
            // buttonSuche
            // 
            this.buttonSuche.Location = new System.Drawing.Point(213, 133);
            this.buttonSuche.Name = "buttonSuche";
            this.buttonSuche.Size = new System.Drawing.Size(94, 29);
            this.buttonSuche.TabIndex = 20;
            this.buttonSuche.Text = "Suche";
            this.buttonSuche.UseVisualStyleBackColor = true;
            this.buttonSuche.Click += new System.EventHandler(this.buttonSuche_Click);
            // 
            // labelVorschläge
            // 
            this.labelVorschläge.AutoSize = true;
            this.labelVorschläge.Location = new System.Drawing.Point(11, 172);
            this.labelVorschläge.Name = "labelVorschläge";
            this.labelVorschläge.Size = new System.Drawing.Size(81, 20);
            this.labelVorschläge.TabIndex = 19;
            this.labelVorschläge.Text = "Vorschläge";
            // 
            // textBoxEndstation
            // 
            this.textBoxEndstation.Location = new System.Drawing.Point(11, 133);
            this.textBoxEndstation.Name = "textBoxEndstation";
            this.textBoxEndstation.Size = new System.Drawing.Size(186, 27);
            this.textBoxEndstation.TabIndex = 17;
            this.textBoxEndstation.TextChanged += new System.EventHandler(this.textBoxEndstation_TextChanged);
            // 
            // textBoxStartstation
            // 
            this.textBoxStartstation.Location = new System.Drawing.Point(11, 56);
            this.textBoxStartstation.Name = "textBoxStartstation";
            this.textBoxStartstation.Size = new System.Drawing.Size(186, 27);
            this.textBoxStartstation.TabIndex = 16;
            this.textBoxStartstation.TextChanged += new System.EventHandler(this.textBoxStartstation_TextChanged);
            this.textBoxStartstation.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.textBoxStartstation_HelpRequested);
            // 
            // labelEndstation
            // 
            this.labelEndstation.AutoSize = true;
            this.labelEndstation.Location = new System.Drawing.Point(11, 111);
            this.labelEndstation.Name = "labelEndstation";
            this.labelEndstation.Size = new System.Drawing.Size(79, 20);
            this.labelEndstation.TabIndex = 15;
            this.labelEndstation.Text = "Endstation";
            // 
            // labelStartstation
            // 
            this.labelStartstation.AutoSize = true;
            this.labelStartstation.Location = new System.Drawing.Point(11, 21);
            this.labelStartstation.Name = "labelStartstation";
            this.labelStartstation.Size = new System.Drawing.Size(85, 20);
            this.labelStartstation.TabIndex = 14;
            this.labelStartstation.Text = "Startstation";
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(14, 196);
            this.Grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 25;
            this.Grid.Size = new System.Drawing.Size(383, 205);
            this.Grid.TabIndex = 28;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(621, 359);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(94, 29);
            this.buttonSend.TabIndex = 29;
            this.buttonSend.Text = "Senden";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(11, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 104);
            this.listBox1.TabIndex = 30;
            this.listBox1.Visible = false;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_Mouseclick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxDrop
            // 
            this.listBoxDrop.FormattingEnabled = true;
            this.listBoxDrop.ItemHeight = 20;
            this.listBoxDrop.Location = new System.Drawing.Point(12, 165);
            this.listBoxDrop.Name = "listBoxDrop";
            this.listBoxDrop.Size = new System.Drawing.Size(186, 104);
            this.listBoxDrop.TabIndex = 31;
            this.listBoxDrop.Visible = false;
            this.listBoxDrop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxDrop_Mouseclick);
            // 
            // Verbindungssuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.listBoxDrop);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.listBoxKommentar);
            this.Controls.Add(this.labelKommentar);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.labelVerlauf);
            this.Controls.Add(this.listBoxVerlauf);
            this.Controls.Add(this.buttonSuche);
            this.Controls.Add(this.labelVorschläge);
            this.Controls.Add(this.textBoxEndstation);
            this.Controls.Add(this.textBoxStartstation);
            this.Controls.Add(this.labelEndstation);
            this.Controls.Add(this.labelStartstation);
            this.Name = "Verbindungssuche";
            this.Text = "Verbindungssuche";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonExit;
        private TextBox textBoxEMail;
        private ListBox listBoxKommentar;
        private Label labelKommentar;
        private Label labelEMail;
        private Label labelVerlauf;
        private ListBox listBoxVerlauf;
        private Button buttonSuche;
        private Label labelVorschläge;
        private TextBox textBoxEndstation;
        private TextBox textBoxStartstation;
        private Label labelEndstation;
        private Label labelStartstation;
        private DataGridView Grid;
        private Button buttonSend;
        private ListBox listBox1;
        private ListBox listBoxDrop;
    }
}