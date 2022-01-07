namespace ÜK_318.Forms
{
    partial class FormAbfahrttafel
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
            this.textBoxHaltestelle = new System.Windows.Forms.TextBox();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GridAbfahrttafel = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAbfahrttafel)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxHaltestelle
            // 
            this.textBoxHaltestelle.Location = new System.Drawing.Point(14, 32);
            this.textBoxHaltestelle.Name = "textBoxHaltestelle";
            this.textBoxHaltestelle.Size = new System.Drawing.Size(186, 27);
            this.textBoxHaltestelle.TabIndex = 0;
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Location = new System.Drawing.Point(216, 33);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(94, 29);
            this.buttonSuchen.TabIndex = 1;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(481, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(299, 200);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(479, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 27);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uhrzeit";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(14, 65);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(89, 20);
            this.lable4.TabIndex = 9;
            this.lable4.Text = "Abfahrttafel";
            this.lable4.Click += new System.EventHandler(this.lable4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Haltestelle";
            // 
            // GridAbfahrttafel
            // 
            this.GridAbfahrttafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAbfahrttafel.Location = new System.Drawing.Point(14, 89);
            this.GridAbfahrttafel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridAbfahrttafel.Name = "GridAbfahrttafel";
            this.GridAbfahrttafel.ReadOnly = true;
            this.GridAbfahrttafel.RowHeadersWidth = 51;
            this.GridAbfahrttafel.RowTemplate.Height = 25;
            this.GridAbfahrttafel.Size = new System.Drawing.Size(429, 253);
            this.GridAbfahrttafel.TabIndex = 11;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(669, 374);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormAbfahrttafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.GridAbfahrttafel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonSuchen);
            this.Controls.Add(this.textBoxHaltestelle);
            this.Name = "FormAbfahrttafel";
            this.Text = "Abfahrttafel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAbfahrttafel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxHaltestelle;
        private Button buttonSuchen;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label lable4;
        private Label label4;
        private DataGridView GridAbfahrttafel;
        private Button buttonExit;
    }
}