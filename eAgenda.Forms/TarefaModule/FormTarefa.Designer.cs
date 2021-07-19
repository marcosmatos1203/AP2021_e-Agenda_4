
namespace eAgenda.Forms
{
    partial class FormTarefa
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
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvTarefa = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtsTarefa = new System.Data.DataSet();
            this.tbTarefa = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.btnPendentes = new System.Windows.Forms.Button();
            this.btnConcluidas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.stsTarefa = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTarefa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.stsTarefa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvTarefa);
            this.gbxLista.Controls.Add(this.btnPendentes);
            this.gbxLista.Controls.Add(this.btnConcluidas);
            this.gbxLista.Location = new System.Drawing.Point(170, 21);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLista.Size = new System.Drawing.Size(546, 342);
            this.gbxLista.TabIndex = 7;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Listas";
            // 
            // dgvTarefa
            // 
            this.dgvTarefa.AutoGenerateColumns = false;
            this.dgvTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn,
            this.prioridadeDataGridViewTextBoxColumn,
            this.percentualDataGridViewTextBoxColumn,
            this.dataConclusaoDataGridViewTextBoxColumn});
            this.dgvTarefa.DataMember = "tbTarefa";
            this.dgvTarefa.DataSource = this.dtsTarefa;
            this.dgvTarefa.Location = new System.Drawing.Point(29, 35);
            this.dgvTarefa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTarefa.Name = "dgvTarefa";
            this.dgvTarefa.ReadOnly = true;
            this.dgvTarefa.RowHeadersVisible = false;
            this.dgvTarefa.RowHeadersWidth = 51;
            this.dgvTarefa.RowTemplate.Height = 24;
            this.dgvTarefa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarefa.Size = new System.Drawing.Size(494, 237);
            this.dgvTarefa.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 120;
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            this.dataCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCriacaoDataGridViewTextBoxColumn.Width = 80;
            // 
            // prioridadeDataGridViewTextBoxColumn
            // 
            this.prioridadeDataGridViewTextBoxColumn.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.Name = "prioridadeDataGridViewTextBoxColumn";
            this.prioridadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prioridadeDataGridViewTextBoxColumn.Width = 95;
            // 
            // percentualDataGridViewTextBoxColumn
            // 
            this.percentualDataGridViewTextBoxColumn.DataPropertyName = "Percentual";
            this.percentualDataGridViewTextBoxColumn.HeaderText = "Percentual";
            this.percentualDataGridViewTextBoxColumn.Name = "percentualDataGridViewTextBoxColumn";
            this.percentualDataGridViewTextBoxColumn.ReadOnly = true;
            this.percentualDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataConclusaoDataGridViewTextBoxColumn
            // 
            this.dataConclusaoDataGridViewTextBoxColumn.DataPropertyName = "DataConclusao";
            this.dataConclusaoDataGridViewTextBoxColumn.HeaderText = "DataConclusao";
            this.dataConclusaoDataGridViewTextBoxColumn.Name = "dataConclusaoDataGridViewTextBoxColumn";
            this.dataConclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataConclusaoDataGridViewTextBoxColumn.Width = 90;
            // 
            // dtsTarefa
            // 
            this.dtsTarefa.DataSetName = "NewDataSet";
            this.dtsTarefa.Tables.AddRange(new System.Data.DataTable[] {
            this.tbTarefa});
            // 
            // tbTarefa
            // 
            this.tbTarefa.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.tbTarefa.TableName = "tbTarefa";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Id";
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Titulo";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Data Criação";
            this.dataColumn3.ColumnName = "DataCriacao";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Prioridade";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Percentual";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Data Conclusão";
            this.dataColumn6.ColumnName = "DataConclusao";
            // 
            // btnPendentes
            // 
            this.btnPendentes.Location = new System.Drawing.Point(202, 288);
            this.btnPendentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnPendentes.Name = "btnPendentes";
            this.btnPendentes.Size = new System.Drawing.Size(148, 34);
            this.btnPendentes.TabIndex = 8;
            this.btnPendentes.Text = "Tarefas Pendentes";
            this.btnPendentes.UseVisualStyleBackColor = true;
            this.btnPendentes.Click += new System.EventHandler(this.btnPendentes_Click);
            // 
            // btnConcluidas
            // 
            this.btnConcluidas.Location = new System.Drawing.Point(376, 288);
            this.btnConcluidas.Margin = new System.Windows.Forms.Padding(2);
            this.btnConcluidas.Name = "btnConcluidas";
            this.btnConcluidas.Size = new System.Drawing.Size(148, 34);
            this.btnConcluidas.TabIndex = 5;
            this.btnConcluidas.Text = "Tarefas Concluídas";
            this.btnConcluidas.UseVisualStyleBackColor = true;
            this.btnConcluidas.Click += new System.EventHandler(this.btnConcluidas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfiguracoes);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(132, 342);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Location = new System.Drawing.Point(11, 190);
            this.btnConfiguracoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(106, 34);
            this.btnConfiguracoes.TabIndex = 4;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(11, 151);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 34);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(11, 34);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 34);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(11, 112);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 34);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(11, 73);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(106, 34);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // stsTarefa
            // 
            this.stsTarefa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsTarefa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stsTarefa.Location = new System.Drawing.Point(0, 427);
            this.stsTarefa.Name = "stsTarefa";
            this.stsTarefa.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.stsTarefa.Size = new System.Drawing.Size(736, 22);
            this.stsTarefa.TabIndex = 8;
            this.stsTarefa.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.stsTarefa);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefa";
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTarefa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.stsTarefa.ResumeLayout(false);
            this.stsTarefa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.Button btnPendentes;
        private System.Windows.Forms.Button btnConcluidas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.StatusStrip stsTarefa;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.DataGridView dgvTarefa;
        private System.Data.DataSet dtsTarefa;
        private System.Data.DataTable tbTarefa;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}