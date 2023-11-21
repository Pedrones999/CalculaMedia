namespace Media
{
    partial class ConfigBoletim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigBoletim));
            periodo = new ComboBox();
            checkBimestre = new CheckBox();
            checkTrimestre = new CheckBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            caixaCaminho = new TextBox();
            AchaPasta = new Button();
            btnGerar = new Button();
            checkLetra = new CheckBox();
            checkNum = new CheckBox();
            SuspendLayout();
            // 
            // periodo
            // 
            periodo.FormattingEnabled = true;
            periodo.Location = new Point(222, 133);
            periodo.Name = "periodo";
            periodo.Size = new Size(141, 23);
            periodo.TabIndex = 0;
            // 
            // checkBimestre
            // 
            checkBimestre.AutoSize = true;
            checkBimestre.Checked = true;
            checkBimestre.CheckState = CheckState.Checked;
            checkBimestre.Location = new Point(83, 49);
            checkBimestre.Name = "checkBimestre";
            checkBimestre.Size = new Size(75, 19);
            checkBimestre.TabIndex = 1;
            checkBimestre.Text = "Bimestral";
            checkBimestre.UseVisualStyleBackColor = true;
            checkBimestre.CheckedChanged += checkBimestre_CheckedChanged;
            // 
            // checkTrimestre
            // 
            checkTrimestre.AutoSize = true;
            checkTrimestre.Location = new Point(254, 49);
            checkTrimestre.Name = "checkTrimestre";
            checkTrimestre.Size = new Size(77, 19);
            checkTrimestre.TabIndex = 2;
            checkTrimestre.Text = "Trimestral";
            checkTrimestre.UseVisualStyleBackColor = true;
            checkTrimestre.CheckedChanged += checkTrimestre_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 3;
            label1.Text = "Formato do boletim:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 136);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 4;
            label2.Text = "Periodo a ser preenchido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 190);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 5;
            label3.Text = "Salvar em:";
            // 
            // caixaCaminho
            // 
            caixaCaminho.Location = new Point(100, 187);
            caixaCaminho.Name = "caixaCaminho";
            caixaCaminho.Size = new Size(263, 23);
            caixaCaminho.TabIndex = 6;
            // 
            // AchaPasta
            // 
            AchaPasta.Image = (Image)resources.GetObject("AchaPasta.Image");
            AchaPasta.Location = new Point(383, 182);
            AchaPasta.Name = "AchaPasta";
            AchaPasta.Size = new Size(35, 28);
            AchaPasta.TabIndex = 7;
            AchaPasta.UseVisualStyleBackColor = true;
            AchaPasta.Click += AchaPasta_Click;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.FromArgb(128, 255, 128);
            btnGerar.Location = new Point(134, 224);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(159, 36);
            btnGerar.TabIndex = 8;
            btnGerar.Text = "Gerar boletim";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // checkLetra
            // 
            checkLetra.AutoSize = true;
            checkLetra.Checked = true;
            checkLetra.CheckState = CheckState.Checked;
            checkLetra.Location = new Point(83, 97);
            checkLetra.Name = "checkLetra";
            checkLetra.Size = new Size(79, 19);
            checkLetra.TabIndex = 9;
            checkLetra.Text = "Notas A-E";
            checkLetra.UseVisualStyleBackColor = true;
            checkLetra.CheckedChanged += checkLetra_CheckedChanged;
            // 
            // checkNum
            // 
            checkNum.AutoSize = true;
            checkNum.Location = new Point(254, 97);
            checkNum.Name = "checkNum";
            checkNum.Size = new Size(83, 19);
            checkNum.TabIndex = 10;
            checkNum.Text = "Notas 0-10";
            checkNum.UseVisualStyleBackColor = true;
            checkNum.CheckedChanged += checkNum_CheckedChanged;
            // 
            // ConfigBoletim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 298);
            Controls.Add(checkNum);
            Controls.Add(checkLetra);
            Controls.Add(btnGerar);
            Controls.Add(AchaPasta);
            Controls.Add(caixaCaminho);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkTrimestre);
            Controls.Add(checkBimestre);
            Controls.Add(periodo);
            Name = "ConfigBoletim";
            Text = "Config. Boletim";
            Load += ConfigBoletim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox periodo;
        private CheckBox checkBimestre;
        private CheckBox checkTrimestre;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox caixaCaminho;
        private Button AchaPasta;
        private Button btnGerar;
        private CheckBox checkLetra;
        private CheckBox checkNum;
    }
}