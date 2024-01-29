namespace Thomas_Verifica
{
    partial class FormModifica
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
            this.textBoxCodiceFarnell = new System.Windows.Forms.TextBox();
            this.textBoxPrezzo = new System.Windows.Forms.TextBox();
            this.textBoxQuantita = new System.Windows.Forms.TextBox();
            this.textBoxCodiceProduttore = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPrezzo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCodiceFarnell
            // 
            this.textBoxCodiceFarnell.Location = new System.Drawing.Point(12, 12);
            this.textBoxCodiceFarnell.Name = "textBoxCodiceFarnell";
            this.textBoxCodiceFarnell.Size = new System.Drawing.Size(85, 23);
            this.textBoxCodiceFarnell.TabIndex = 0;
            // 
            // textBoxPrezzo
            // 
            this.textBoxPrezzo.Location = new System.Drawing.Point(12, 102);
            this.textBoxPrezzo.Name = "textBoxPrezzo";
            this.textBoxPrezzo.Size = new System.Drawing.Size(85, 23);
            this.textBoxPrezzo.TabIndex = 2;
            // 
            // textBoxQuantita
            // 
            this.textBoxQuantita.Location = new System.Drawing.Point(12, 73);
            this.textBoxQuantita.Name = "textBoxQuantita";
            this.textBoxQuantita.Size = new System.Drawing.Size(85, 23);
            this.textBoxQuantita.TabIndex = 3;
            // 
            // textBoxCodiceProduttore
            // 
            this.textBoxCodiceProduttore.Location = new System.Drawing.Point(12, 44);
            this.textBoxCodiceProduttore.Name = "textBoxCodiceProduttore";
            this.textBoxCodiceProduttore.Size = new System.Drawing.Size(85, 23);
            this.textBoxCodiceProduttore.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(196, 137);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Salva";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(103, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 15);
            this.label.TabIndex = 9;
            this.label.Text = "CodiceFarnell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "CodiceProduttore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantita";
            // 
            // labelPrezzo
            // 
            this.labelPrezzo.AutoSize = true;
            this.labelPrezzo.Location = new System.Drawing.Point(103, 104);
            this.labelPrezzo.Name = "labelPrezzo";
            this.labelPrezzo.Size = new System.Drawing.Size(41, 15);
            this.labelPrezzo.TabIndex = 12;
            this.labelPrezzo.Text = "Prezzo";
            // 
            // FormModifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 170);
            this.Controls.Add(this.labelPrezzo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCodiceProduttore);
            this.Controls.Add(this.textBoxQuantita);
            this.Controls.Add(this.textBoxPrezzo);
            this.Controls.Add(this.textBoxCodiceFarnell);
            this.Name = "FormModifica";
            this.Text = "FormModifica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxCodiceFarnell;
        private TextBox textBoxPrezzo;
        private TextBox textBoxQuantita;
        private TextBox textBoxCodiceProduttore;
        private Button buttonSave;
        private Label label1;
        private Label label;
        private Label label3;
        private Label label4;
        private Label labelPrezzo;
    }
}