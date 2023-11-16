namespace Media
{
    partial class TabelaAluno
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
            label1 = new Label();
            panel3 = new Panel();
            LinkMaterias = new LinkLabel();
            NomeMateria = new TextBox();
            BtnPreencher = new Button();
            BtnRemoverMateria = new Button();
            BtnAddMateria = new Button();
            labelAtvs = new Label();
            ListaMaterias = new ListBox();
            ListaAlunos = new ListBox();
            panel2 = new Panel();
            BtnSalvar = new Button();
            BtnApagar = new Button();
            CaixaNome = new TextBox();
            BtnNovoAluno = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(ListaAlunos);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1268, 605);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 5;
            label1.Text = "LIsta de alunos";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ScrollBar;
            panel3.Controls.Add(LinkMaterias);
            panel3.Controls.Add(NomeMateria);
            panel3.Controls.Add(BtnPreencher);
            panel3.Controls.Add(BtnRemoverMateria);
            panel3.Controls.Add(BtnAddMateria);
            panel3.Controls.Add(labelAtvs);
            panel3.Controls.Add(ListaMaterias);
            panel3.Location = new Point(679, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(589, 557);
            panel3.TabIndex = 4;
            // 
            // LinkMaterias
            // 
            LinkMaterias.AutoSize = true;
            LinkMaterias.Location = new Point(501, 9);
            LinkMaterias.Name = "LinkMaterias";
            LinkMaterias.Size = new Size(85, 15);
            LinkMaterias.TabIndex = 10;
            LinkMaterias.TabStop = true;
            LinkMaterias.Text = "Editar materias";
            LinkMaterias.LinkClicked += LinkMaterias_LinkClicked;
            // 
            // NomeMateria
            // 
            NomeMateria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            NomeMateria.Location = new Point(15, 54);
            NomeMateria.Name = "NomeMateria";
            NomeMateria.Size = new Size(184, 23);
            NomeMateria.TabIndex = 9;
            // 
            // BtnPreencher
            // 
            BtnPreencher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnPreencher.BackColor = Color.Khaki;
            BtnPreencher.Location = new Point(463, 46);
            BtnPreencher.Name = "BtnPreencher";
            BtnPreencher.Size = new Size(114, 37);
            BtnPreencher.TabIndex = 4;
            BtnPreencher.Text = "Preencher notas";
            BtnPreencher.UseVisualStyleBackColor = false;
            BtnPreencher.Click += BtnPreencher_Click;
            // 
            // BtnRemoverMateria
            // 
            BtnRemoverMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnRemoverMateria.BackColor = Color.LightCoral;
            BtnRemoverMateria.Location = new Point(345, 46);
            BtnRemoverMateria.Name = "BtnRemoverMateria";
            BtnRemoverMateria.Size = new Size(112, 39);
            BtnRemoverMateria.TabIndex = 8;
            BtnRemoverMateria.Text = "Remover materia";
            BtnRemoverMateria.UseVisualStyleBackColor = false;
            BtnRemoverMateria.Click += BtnRemoverMateria_Click;
            // 
            // BtnAddMateria
            // 
            BtnAddMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnAddMateria.BackColor = Color.LightGreen;
            BtnAddMateria.Location = new Point(230, 46);
            BtnAddMateria.Name = "BtnAddMateria";
            BtnAddMateria.Size = new Size(109, 37);
            BtnAddMateria.TabIndex = 7;
            BtnAddMateria.Text = "Adicionar materia";
            BtnAddMateria.UseVisualStyleBackColor = false;
            BtnAddMateria.Click += BtnAddMateria_Click;
            // 
            // labelAtvs
            // 
            labelAtvs.AutoSize = true;
            labelAtvs.ForeColor = SystemColors.ActiveCaptionText;
            labelAtvs.Location = new Point(12, 24);
            labelAtvs.Name = "labelAtvs";
            labelAtvs.Size = new Size(257, 15);
            labelAtvs.TabIndex = 6;
            labelAtvs.Text = "Selecione ou crie um aluno para ver as materias";
            // 
            // ListaMaterias
            // 
            ListaMaterias.FormattingEnabled = true;
            ListaMaterias.ItemHeight = 15;
            ListaMaterias.Location = new Point(12, 87);
            ListaMaterias.Name = "ListaMaterias";
            ListaMaterias.Size = new Size(565, 454);
            ListaMaterias.TabIndex = 0;
            ListaMaterias.SelectedIndexChanged += ListaMaterias_SelectedIndexChanged;
            // 
            // ListaAlunos
            // 
            ListaAlunos.FormattingEnabled = true;
            ListaAlunos.ItemHeight = 15;
            ListaAlunos.Location = new Point(12, 42);
            ListaAlunos.Name = "ListaAlunos";
            ListaAlunos.Size = new Size(653, 499);
            ListaAlunos.TabIndex = 3;
            ListaAlunos.SelectedIndexChanged += ListaAlunos_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(BtnSalvar);
            panel2.Controls.Add(BtnApagar);
            panel2.Controls.Add(CaixaNome);
            panel2.Controls.Add(BtnNovoAluno);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 556);
            panel2.Name = "panel2";
            panel2.Size = new Size(1268, 49);
            panel2.TabIndex = 2;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSalvar.BackColor = Color.LightGreen;
            BtnSalvar.Location = new Point(784, 6);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(137, 37);
            BtnSalvar.TabIndex = 3;
            BtnSalvar.Text = "Salvar nome";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnApagar
            // 
            BtnApagar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnApagar.BackColor = Color.LightCoral;
            BtnApagar.Location = new Point(948, 5);
            BtnApagar.Name = "BtnApagar";
            BtnApagar.Size = new Size(130, 39);
            BtnApagar.TabIndex = 2;
            BtnApagar.Text = "Apagar aluno";
            BtnApagar.UseVisualStyleBackColor = false;
            BtnApagar.Click += BtnApagar_Click;
            // 
            // CaixaNome
            // 
            CaixaNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CaixaNome.Location = new Point(36, 14);
            CaixaNome.Name = "CaixaNome";
            CaixaNome.Size = new Size(537, 23);
            CaixaNome.TabIndex = 1;
            CaixaNome.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnNovoAluno
            // 
            BtnNovoAluno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnNovoAluno.BackColor = Color.Aquamarine;
            BtnNovoAluno.Location = new Point(623, 6);
            BtnNovoAluno.Name = "BtnNovoAluno";
            BtnNovoAluno.Size = new Size(132, 37);
            BtnNovoAluno.TabIndex = 0;
            BtnNovoAluno.Text = "Novo aluno";
            BtnNovoAluno.UseVisualStyleBackColor = false;
            BtnNovoAluno.Click += BtnNovoAluno_Click;
            // 
            // TabelaAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1268, 607);
            Controls.Add(panel1);
            Name = "TabelaAluno";
            Text = "Form1";
            Load += TabelaAluno_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BtnSalvar;
        private Button BtnApagar;
        private TextBox CaixaNome;
        private Button BtnNovoAluno;
        private Panel panel3;
        private ListBox ListaAlunos;
        private ListBox ListaMaterias;
        private Label label1;
        private Label labelAtvs;
        private Button BtnRemoverMateria;
        private Button BtnAddMateria;
        private Button BtnPreencher;
        private TextBox NomeMateria;
        private LinkLabel LinkMaterias;
    }
}