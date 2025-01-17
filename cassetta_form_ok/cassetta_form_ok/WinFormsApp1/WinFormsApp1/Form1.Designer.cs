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
            inserisciOggetto = new Button();
            inserisciDocumento = new Button();
            inserisciChiave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // inserisciOggetto
            // 
            inserisciOggetto.Location = new Point(136, 190);
            inserisciOggetto.Margin = new Padding(3, 2, 3, 2);
            inserisciOggetto.Name = "inserisciOggetto";
            inserisciOggetto.Size = new Size(118, 35);
            inserisciOggetto.TabIndex = 0;
            inserisciOggetto.Text = "Inserisci Oggetto";
            inserisciOggetto.UseVisualStyleBackColor = true;
            inserisciOggetto.Click += button1_Click;
            // 
            // inserisciDocumento
            // 
            inserisciDocumento.Location = new Point(285, 190);
            inserisciDocumento.Margin = new Padding(3, 2, 3, 2);
            inserisciDocumento.Name = "inserisciDocumento";
            inserisciDocumento.Size = new Size(134, 35);
            inserisciDocumento.TabIndex = 1;
            inserisciDocumento.Text = "inserisci documento";
            inserisciDocumento.UseVisualStyleBackColor = true;
            inserisciDocumento.Click += inserisciDocumento_Click;
            // 
            // inserisciChiave
            // 
            inserisciChiave.Location = new Point(468, 190);
            inserisciChiave.Margin = new Padding(3, 2, 3, 2);
            inserisciChiave.Name = "inserisciChiave";
            inserisciChiave.Size = new Size(126, 35);
            inserisciChiave.TabIndex = 2;
            inserisciChiave.Text = "inserisci Chiave";
            inserisciChiave.UseVisualStyleBackColor = true;
            inserisciChiave.Click += inserisciChiave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 151);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 151);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 151);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inserisciChiave);
            Controls.Add(inserisciDocumento);
            Controls.Add(inserisciOggetto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inserisciOggetto;
        private Button inserisciDocumento;
        private Button inserisciChiave;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
