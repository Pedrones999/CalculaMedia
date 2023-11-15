namespace Media
{
    partial class EditMateria
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
            PainelMateria = new Panel();
            label3 = new Label();
            PainelLista = new Panel();
            listBox1 = new ListBox();
            PainelDadosAtv = new Panel();
            BtnNovaAtv = new Button();
            label2 = new Label();
            label1 = new Label();
            BtnApagaAtv = new Button();
            BtnSalvaAtv = new Button();
            Peso = new TextBox();
            NomeAtv = new TextBox();
            PainelMateria.SuspendLayout();
            PainelLista.SuspendLayout();
            PainelDadosAtv.SuspendLayout();
            SuspendLayout();
            // 
            // PainelMateria
            // 
            PainelMateria.BackColor = SystemColors.ControlDarkDark;
            PainelMateria.Controls.Add(label3);
            PainelMateria.Location = new Point(0, 3);
            PainelMateria.Name = "PainelMateria";
            PainelMateria.Size = new Size(948, 75);
            PainelMateria.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Lavender;
            label3.Location = new Point(464, 31);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // PainelLista
            // 
            PainelLista.BackColor = SystemColors.ControlDark;
            PainelLista.Controls.Add(PainelMateria);
            PainelLista.Controls.Add(listBox1);
            PainelLista.Dock = DockStyle.Fill;
            PainelLista.Location = new Point(0, 0);
            PainelLista.Name = "PainelLista";
            PainelLista.Size = new Size(945, 489);
            PainelLista.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(603, 394);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // PainelDadosAtv
            // 
            PainelDadosAtv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PainelDadosAtv.BackColor = SystemColors.AppWorkspace;
            PainelDadosAtv.Controls.Add(BtnNovaAtv);
            PainelDadosAtv.Controls.Add(label2);
            PainelDadosAtv.Controls.Add(label1);
            PainelDadosAtv.Controls.Add(BtnApagaAtv);
            PainelDadosAtv.Controls.Add(BtnSalvaAtv);
            PainelDadosAtv.Controls.Add(Peso);
            PainelDadosAtv.Controls.Add(NomeAtv);
            PainelDadosAtv.Location = new Point(612, 83);
            PainelDadosAtv.Name = "PainelDadosAtv";
            PainelDadosAtv.Size = new Size(333, 406);
            PainelDadosAtv.TabIndex = 0;
            // 
            // BtnNovaAtv
            // 
            BtnNovaAtv.Anchor = AnchorStyles.None;
            BtnNovaAtv.BackColor = Color.FromArgb(128, 255, 255);
            BtnNovaAtv.Location = new Point(15, 302);
            BtnNovaAtv.Name = "BtnNovaAtv";
            BtnNovaAtv.Size = new Size(96, 40);
            BtnNovaAtv.TabIndex = 6;
            BtnNovaAtv.Text = "Nova atividade";
            BtnNovaAtv.UseVisualStyleBackColor = false;
            BtnNovaAtv.Click += ClickNovaAtv;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(94, 214);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 5;
            label2.Text = "peso da atividade:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(94, 132);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome da atividade:";
            // 
            // BtnApagaAtv
            // 
            BtnApagaAtv.Anchor = AnchorStyles.None;
            BtnApagaAtv.BackColor = Color.FromArgb(255, 128, 128);
            BtnApagaAtv.Location = new Point(241, 302);
            BtnApagaAtv.Name = "BtnApagaAtv";
            BtnApagaAtv.Size = new Size(89, 40);
            BtnApagaAtv.TabIndex = 3;
            BtnApagaAtv.Text = "Apagar";
            BtnApagaAtv.UseVisualStyleBackColor = false;
            BtnApagaAtv.Click += BtnApagaAtv_Click;
            // 
            // BtnSalvaAtv
            // 
            BtnSalvaAtv.Anchor = AnchorStyles.None;
            BtnSalvaAtv.BackColor = Color.FromArgb(128, 255, 128);
            BtnSalvaAtv.Location = new Point(129, 302);
            BtnSalvaAtv.Name = "BtnSalvaAtv";
            BtnSalvaAtv.Size = new Size(89, 40);
            BtnSalvaAtv.TabIndex = 2;
            BtnSalvaAtv.Text = "Salvar";
            BtnSalvaAtv.UseVisualStyleBackColor = false;
            BtnSalvaAtv.Click += SalvarAtv;
            // 
            // Peso
            // 
            Peso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Peso.Location = new Point(210, 214);
            Peso.Name = "Peso";
            Peso.Size = new Size(43, 23);
            Peso.TabIndex = 1;
            // 
            // NomeAtv
            // 
            NomeAtv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            NomeAtv.Location = new Point(95, 164);
            NomeAtv.Name = "NomeAtv";
            NomeAtv.Size = new Size(158, 23);
            NomeAtv.TabIndex = 0;
            // 
            // EditMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 489);
            Controls.Add(PainelDadosAtv);
            Controls.Add(PainelLista);
            Name = "EditMateria";
            Text = "Editar Materia";
            Load += AoCarregar;
            PainelMateria.ResumeLayout(false);
            PainelMateria.PerformLayout();
            PainelLista.ResumeLayout(false);
            PainelDadosAtv.ResumeLayout(false);
            PainelDadosAtv.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PainelMateria;
        private Panel PainelLista;
        private Panel PainelDadosAtv;
        private ListBox listBox1;
        private TextBox NomeAtv;
        private TextBox Peso;
        private Button BtnApagaAtv;
        private Button BtnSalvaAtv;
        private Label label1;
        private Label label2;
        private Button BtnNovaAtv;
        private Label label3;
    }
}