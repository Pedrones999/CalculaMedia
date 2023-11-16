namespace Media
{
    partial class PreencherNota
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
            panel1 = new Panel();
            NomeAtv = new Label();
            BtnSalva = new Button();
            CaixaNota = new TextBox();
            panel2 = new Panel();
            ListaAtvs = new ListBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(NomeAtv);
            panel1.Controls.Add(BtnSalva);
            panel1.Controls.Add(CaixaNota);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(443, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 415);
            panel1.TabIndex = 0;
            // 
            // NomeAtv
            // 
            NomeAtv.AutoSize = true;
            NomeAtv.Location = new Point(86, 65);
            NomeAtv.Name = "NomeAtv";
            NomeAtv.Size = new Size(38, 15);
            NomeAtv.TabIndex = 2;
            NomeAtv.Text = "label1";
            // 
            // BtnSalva
            // 
            BtnSalva.BackColor = Color.PaleGreen;
            BtnSalva.Location = new Point(54, 244);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(118, 30);
            BtnSalva.TabIndex = 1;
            BtnSalva.Text = "Salvar nota";
            BtnSalva.UseVisualStyleBackColor = false;
            BtnSalva.Click += SalvaNota;
            // 
            // CaixaNota
            // 
            CaixaNota.Location = new Point(86, 128);
            CaixaNota.Name = "CaixaNota";
            CaixaNota.Size = new Size(56, 23);
            CaixaNota.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(ListaAtvs);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 415);
            panel2.TabIndex = 1;
            // 
            // ListaAtvs
            // 
            ListaAtvs.FormattingEnabled = true;
            ListaAtvs.ItemHeight = 15;
            ListaAtvs.Location = new Point(12, 12);
            ListaAtvs.Name = "ListaAtvs";
            ListaAtvs.Size = new Size(415, 394);
            ListaAtvs.TabIndex = 2;
            ListaAtvs.SelectedIndexChanged += trocaIndex;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 137);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // PreencherNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 415);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PreencherNota";
            Text = "Preencher notas";
            Load += aoCarregar;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnSalva;
        private TextBox CaixaNota;
        private Panel panel2;
        private ListBox ListaAtvs;
        private Label NomeAtv;
        private Label label1;
    }
}