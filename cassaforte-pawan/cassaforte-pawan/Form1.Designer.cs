namespace cassaforte_pawan
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
            buttonInserisci = new Button();
            buttonRimuovi = new Button();
            Pin = new TextBox();
            valoreDichiarato = new TextBox();
            labelValoreAssicurato = new Label();
            labelTipoOggetto = new Label();
            SuspendLayout();
            // 
            // buttonInserisci
            // 
            buttonInserisci.Location = new Point(141, 235);
            buttonInserisci.Name = "buttonInserisci";
            buttonInserisci.Size = new Size(94, 29);
            buttonInserisci.TabIndex = 0;
            buttonInserisci.Text = "INSERISCI";
            buttonInserisci.UseVisualStyleBackColor = true;
            buttonInserisci.Click += buttonInserisci_Click;
            // 
            // buttonRimuovi
            // 
            buttonRimuovi.Location = new Point(529, 235);
            buttonRimuovi.Name = "buttonRimuovi";
            buttonRimuovi.Size = new Size(94, 29);
            buttonRimuovi.TabIndex = 1;
            buttonRimuovi.Text = "RIMUOVI";
            buttonRimuovi.UseVisualStyleBackColor = true;
            buttonRimuovi.Click += buttonRimuovi_Click;
            // 
            // Pin
            // 
            Pin.Location = new Point(303, 147);
            Pin.Name = "Pin";
            Pin.Size = new Size(125, 27);
            Pin.TabIndex = 2;
            // 
            // valoreDichiarato
            // 
            valoreDichiarato.Location = new Point(303, 351);
            valoreDichiarato.Name = "valoreDichiarato";
            valoreDichiarato.Size = new Size(125, 27);
            valoreDichiarato.TabIndex = 3;
            // 
            // labelValoreAssicurato
            // 
            labelValoreAssicurato.AutoSize = true;
            labelValoreAssicurato.Location = new Point(202, 351);
            labelValoreAssicurato.Name = "labelValoreAssicurato";
            labelValoreAssicurato.Size = new Size(50, 20);
            labelValoreAssicurato.TabIndex = 4;
            labelValoreAssicurato.Text = "label1";
            // 
            // labelTipoOggetto
            // 
            labelTipoOggetto.AutoSize = true;
            labelTipoOggetto.Location = new Point(510, 351);
            labelTipoOggetto.Name = "labelTipoOggetto";
            labelTipoOggetto.Size = new Size(50, 20);
            labelTipoOggetto.TabIndex = 5;
            labelTipoOggetto.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTipoOggetto);
            Controls.Add(labelValoreAssicurato);
            Controls.Add(valoreDichiarato);
            Controls.Add(Pin);
            Controls.Add(buttonRimuovi);
            Controls.Add(buttonInserisci);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInserisci;
        private Button buttonRimuovi;
        private TextBox Pin;
        private TextBox valoreDichiarato;
        private Label labelValoreAssicurato;
        private Label labelTipoOggetto;
    }
}
