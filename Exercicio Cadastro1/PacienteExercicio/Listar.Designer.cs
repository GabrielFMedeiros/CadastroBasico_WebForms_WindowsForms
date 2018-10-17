namespace PacienteExercicio
{
    partial class Listar
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdadePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelularPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RespPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhes = new System.Windows.Forms.DataGridViewImageColumn();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteDataSet = new PacienteExercicio.PacienteDataSet();
            this.pacientesTableAdapter = new PacienteExercicio.PacienteDataSetTableAdapters.PacientesTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.NomePaciente,
            this.IdadePaciente,
            this.SexoPaciente,
            this.TelefonePaciente,
            this.CelularPaciente,
            this.EmailPaciente,
            this.RespPaciente,
            this.Detalhes});
            this.dataGridView1.DataSource = this.pacientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(831, 327);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            this.IdPaciente.HeaderText = "ID";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Width = 33;
            // 
            // NomePaciente
            // 
            this.NomePaciente.DataPropertyName = "NomePaciente";
            this.NomePaciente.HeaderText = "Nome";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.Width = 140;
            // 
            // IdadePaciente
            // 
            this.IdadePaciente.DataPropertyName = "IdadePaciente";
            this.IdadePaciente.HeaderText = "Idade";
            this.IdadePaciente.Name = "IdadePaciente";
            this.IdadePaciente.Width = 40;
            // 
            // SexoPaciente
            // 
            this.SexoPaciente.DataPropertyName = "SexoPaciente";
            this.SexoPaciente.HeaderText = "Sexo";
            this.SexoPaciente.Name = "SexoPaciente";
            this.SexoPaciente.Width = 59;
            // 
            // TelefonePaciente
            // 
            this.TelefonePaciente.DataPropertyName = "TelefonePaciente";
            this.TelefonePaciente.HeaderText = "Telefone";
            this.TelefonePaciente.Name = "TelefonePaciente";
            this.TelefonePaciente.Width = 82;
            // 
            // CelularPaciente
            // 
            this.CelularPaciente.DataPropertyName = "CelularPaciente";
            this.CelularPaciente.HeaderText = "Celular";
            this.CelularPaciente.Name = "CelularPaciente";
            this.CelularPaciente.Width = 87;
            // 
            // EmailPaciente
            // 
            this.EmailPaciente.DataPropertyName = "EmailPaciente";
            this.EmailPaciente.HeaderText = "E-mail";
            this.EmailPaciente.Name = "EmailPaciente";
            this.EmailPaciente.Width = 145;
            // 
            // RespPaciente
            // 
            this.RespPaciente.DataPropertyName = "RespPaciente";
            this.RespPaciente.HeaderText = "Responsavel";
            this.RespPaciente.Name = "RespPaciente";
            this.RespPaciente.Width = 170;
            // 
            // Detalhes
            // 
            this.Detalhes.HeaderText = "Detalhes";
            this.Detalhes.Image = global::PacienteExercicio.Properties.Resources.editar;
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.ReadOnly = true;
            this.Detalhes.Width = 53;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.pacienteDataSet;
            // 
            // pacienteDataSet
            // 
            this.pacienteDataSet.DataSetName = "PacienteDataSet";
            this.pacienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::PacienteExercicio.Properties.Resources.logo;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = global::PacienteExercicio.Properties.Resources.home;
            this.inicioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Image = global::PacienteExercicio.Properties.Resources.cadastro;
            this.cadastroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Image = global::PacienteExercicio.Properties.Resources.lista;
            this.listaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Listar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private PacienteDataSet pacienteDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private PacienteDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdadePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelularPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RespPaciente;
        private System.Windows.Forms.DataGridViewImageColumn Detalhes;
    }
}