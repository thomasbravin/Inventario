namespace Thomas_Verifica
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodiceFarnell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produttore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodiceProduttore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodiceFarnell,
            this.Descrizione,
            this.Produttore,
            this.CodiceProduttore,
            this.Quantita,
            this.Prezzo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(451, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // CodiceFarnell
            // 
            this.CodiceFarnell.HeaderText = "CodiceFarnell";
            this.CodiceFarnell.Name = "CodiceFarnell";
            // 
            // Descrizione
            // 
            this.Descrizione.HeaderText = "Descrizione";
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.Visible = false;
            // 
            // Produttore
            // 
            this.Produttore.HeaderText = "Produttore";
            this.Produttore.Name = "Produttore";
            this.Produttore.Visible = false;
            // 
            // CodiceProduttore
            // 
            this.CodiceProduttore.HeaderText = "CodiceProduttore";
            this.CodiceProduttore.Name = "CodiceProduttore";
            // 
            // Quantita
            // 
            this.Quantita.HeaderText = "Quantita";
            this.Quantita.Name = "Quantita";
            // 
            // Prezzo
            // 
            this.Prezzo.HeaderText = "Prezzo";
            this.Prezzo.Name = "Prezzo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 364);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CodiceFarnell;
        private DataGridViewTextBoxColumn Descrizione;
        private DataGridViewTextBoxColumn Produttore;
        private DataGridViewTextBoxColumn CodiceProduttore;
        private DataGridViewTextBoxColumn Quantita;
        private DataGridViewTextBoxColumn Prezzo;
    }
}