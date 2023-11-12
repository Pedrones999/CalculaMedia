namespace Media
{
    partial class TabelaMaterias
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
            components = new System.ComponentModel.Container();
            BtnNovaMateria = new Button();
            panel1 = new Panel();
            CaixaNomeMateria = new TextBox();
            panel2 = new Panel();
            ListaMaterias = new ListBox();
            BsMateria = new BindingSource(components);
            controleMateriaBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BsMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controleMateriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BtnNovaMateria
            // 
            BtnNovaMateria.BackColor = Color.DarkSeaGreen;
            BtnNovaMateria.Dock = DockStyle.Right;
            BtnNovaMateria.Location = new Point(254, 0);
            BtnNovaMateria.Name = "BtnNovaMateria";
            BtnNovaMateria.Size = new Size(246, 49);
            BtnNovaMateria.TabIndex = 0;
            BtnNovaMateria.Text = "Nova materia";
            BtnNovaMateria.UseVisualStyleBackColor = false;
            BtnNovaMateria.Click += NovaMateria;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(CaixaNomeMateria);
            panel1.Controls.Add(BtnNovaMateria);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 479);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 49);
            panel1.TabIndex = 1;
            // 
            // CaixaNomeMateria
            // 
            CaixaNomeMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CaixaNomeMateria.Location = new Point(36, 14);
            CaixaNomeMateria.Name = "CaixaNomeMateria";
            CaixaNomeMateria.Size = new Size(179, 23);
            CaixaNomeMateria.TabIndex = 1;
            CaixaNomeMateria.Text = "Nome para nova materia";
            CaixaNomeMateria.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(ListaMaterias);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 528);
            panel2.TabIndex = 1;
            // 
            // ListaMaterias
            // 
            ListaMaterias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListaMaterias.FormattingEnabled = true;
            ListaMaterias.ItemHeight = 15;
            ListaMaterias.Location = new Point(12, 12);
            ListaMaterias.Name = "ListaMaterias";
            ListaMaterias.Size = new Size(476, 454);
            ListaMaterias.TabIndex = 0;
            ListaMaterias.MouseDoubleClick += ListaMaterias_MouseDoubleClick;
            // 
            // TabelaMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 528);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "TabelaMaterias";
            Text = "Materias";
            Load += TabelaMaterias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BsMateria).EndInit();
            ((System.ComponentModel.ISupportInitialize)controleMateriaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnNovaMateria;
        private Panel panel1;
        private Panel panel2;
        private TextBox CaixaNomeMateria;
        private BindingSource BsMateria;
        private ListBox ListaMaterias;
        private BindingSource controleMateriaBindingSource;
    }
}