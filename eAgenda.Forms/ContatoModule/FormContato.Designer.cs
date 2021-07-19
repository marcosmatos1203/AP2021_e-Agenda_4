
namespace eAgenda.Forms
{
    partial class FormContato
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
            this.btnAgruparPorId = new System.Windows.Forms.Button();
            this.btnAgruparPorNome = new System.Windows.Forms.Button();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtsContato = new System.Data.DataSet();
            this.tbContato = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.btnAgruparPorCargo = new System.Windows.Forms.Button();
            this.gbxConfiguracoes = new System.Windows.Forms.GroupBox();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsContato = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContato)).BeginInit();
            this.gbxConfiguracoes.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.btnAgruparPorId);
            this.gbxLista.Controls.Add(this.btnAgruparPorNome);
            this.gbxLista.Controls.Add(this.dgvContato);
            this.gbxLista.Controls.Add(this.btnAgruparPorCargo);
            this.gbxLista.Location = new System.Drawing.Point(170, 21);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLista.Size = new System.Drawing.Size(546, 342);
            this.gbxLista.TabIndex = 9;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Listas de Contatos";
            // 
            // btnAgruparPorId
            // 
            this.btnAgruparPorId.Location = new System.Drawing.Point(29, 285);
            this.btnAgruparPorId.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgruparPorId.Name = "btnAgruparPorId";
            this.btnAgruparPorId.Size = new System.Drawing.Size(148, 34);
            this.btnAgruparPorId.TabIndex = 12;
            this.btnAgruparPorId.Text = "Listar por Id";
            this.btnAgruparPorId.UseVisualStyleBackColor = true;
            this.btnAgruparPorId.Click += new System.EventHandler(this.btnAgruparPorId_Click);
            // 
            // btnAgruparPorNome
            // 
            this.btnAgruparPorNome.Location = new System.Drawing.Point(204, 285);
            this.btnAgruparPorNome.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgruparPorNome.Name = "btnAgruparPorNome";
            this.btnAgruparPorNome.Size = new System.Drawing.Size(148, 34);
            this.btnAgruparPorNome.TabIndex = 11;
            this.btnAgruparPorNome.Text = "Listar por nome";
            this.btnAgruparPorNome.UseVisualStyleBackColor = true;
            this.btnAgruparPorNome.Click += new System.EventHandler(this.btnAgruparPorNome_Click);
            // 
            // dgvContato
            // 
            this.dgvContato.AutoGenerateColumns = false;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn});
            this.dgvContato.DataMember = "tbContato";
            this.dgvContato.DataSource = this.dtsContato;
            this.dgvContato.Location = new System.Drawing.Point(29, 35);
            this.dgvContato.Margin = new System.Windows.Forms.Padding(2);
            this.dgvContato.MultiSelect = false;
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.ReadOnly = true;
            this.dgvContato.RowHeadersVisible = false;
            this.dgvContato.RowHeadersWidth = 51;
            this.dgvContato.RowTemplate.Height = 24;
            this.dgvContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContato.Size = new System.Drawing.Size(494, 237);
            this.dgvContato.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 140;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 90;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtsContato
            // 
            this.dtsContato.DataSetName = "NewDataSet";
            this.dtsContato.Tables.AddRange(new System.Data.DataTable[] {
            this.tbContato});
            // 
            // tbContato
            // 
            this.tbContato.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.tbContato.TableName = "tbContato";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Nome";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Telefone";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Cargo";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Empresa";
            // 
            // btnAgruparPorCargo
            // 
            this.btnAgruparPorCargo.Location = new System.Drawing.Point(376, 285);
            this.btnAgruparPorCargo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgruparPorCargo.Name = "btnAgruparPorCargo";
            this.btnAgruparPorCargo.Size = new System.Drawing.Size(148, 34);
            this.btnAgruparPorCargo.TabIndex = 5;
            this.btnAgruparPorCargo.Text = "Listar por cargo";
            this.btnAgruparPorCargo.UseVisualStyleBackColor = true;
            this.btnAgruparPorCargo.Click += new System.EventHandler(this.btnAgrupar_Click);
            // 
            // gbxConfiguracoes
            // 
            this.gbxConfiguracoes.Controls.Add(this.btnConfiguracoes);
            this.gbxConfiguracoes.Controls.Add(this.btnCancelar);
            this.gbxConfiguracoes.Controls.Add(this.btnNovo);
            this.gbxConfiguracoes.Controls.Add(this.btnExcluir);
            this.gbxConfiguracoes.Controls.Add(this.btnEditar);
            this.gbxConfiguracoes.Location = new System.Drawing.Point(20, 21);
            this.gbxConfiguracoes.Margin = new System.Windows.Forms.Padding(2);
            this.gbxConfiguracoes.Name = "gbxConfiguracoes";
            this.gbxConfiguracoes.Padding = new System.Windows.Forms.Padding(2);
            this.gbxConfiguracoes.Size = new System.Drawing.Size(132, 342);
            this.gbxConfiguracoes.TabIndex = 8;
            this.gbxConfiguracoes.TabStop = false;
            this.gbxConfiguracoes.Text = "Settings";
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
            this.btnExcluir.Text = "excluir";
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
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsContato});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsContato
            // 
            this.stsContato.Name = "stsContato";
            this.stsContato.Size = new System.Drawing.Size(0, 17);
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.gbxConfiguracoes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contato";
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContato)).EndInit();
            this.gbxConfiguracoes.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.Button btnAgruparPorCargo;
        private System.Windows.Forms.GroupBox gbxConfiguracoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Data.DataSet dtsContato;
        private System.Data.DataTable tbContato;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAgruparPorNome;
        private System.Windows.Forms.Button btnAgruparPorId;
        private System.Windows.Forms.ToolStripStatusLabel stsContato;
    }
}