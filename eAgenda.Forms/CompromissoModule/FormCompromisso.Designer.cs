
namespace eAgenda.Forms
{
    partial class FormCompromisso
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
            this.dgvCompromisso = new System.Windows.Forms.DataGridView();
            this.dtsCompromisso = new System.Data.DataSet();
            this.tbCompromisso = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.btnAnteriores = new System.Windows.Forms.Button();
            this.btnProximos = new System.Windows.Forms.Button();
            this.gbxConfiguracoes = new System.Windows.Forms.GroupBox();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnTodos = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTerminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCompromisso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompromisso)).BeginInit();
            this.gbxConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.btnTodos);
            this.gbxLista.Controls.Add(this.dgvCompromisso);
            this.gbxLista.Controls.Add(this.btnAnteriores);
            this.gbxLista.Controls.Add(this.btnProximos);
            this.gbxLista.Location = new System.Drawing.Point(170, 21);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLista.Size = new System.Drawing.Size(546, 342);
            this.gbxLista.TabIndex = 7;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Listas de Compromissos";
            // 
            // dgvCompromisso
            // 
            this.dgvCompromisso.AutoGenerateColumns = false;
            this.dgvCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromisso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.assuntoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaTerminoDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn});
            this.dgvCompromisso.DataMember = "tbCompromisso";
            this.dgvCompromisso.DataSource = this.dtsCompromisso;
            this.dgvCompromisso.Location = new System.Drawing.Point(29, 35);
            this.dgvCompromisso.Name = "dgvCompromisso";
            this.dgvCompromisso.ReadOnly = true;
            this.dgvCompromisso.RowHeadersVisible = false;
            this.dgvCompromisso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompromisso.Size = new System.Drawing.Size(494, 237);
            this.dgvCompromisso.TabIndex = 9;
            // 
            // dtsCompromisso
            // 
            this.dtsCompromisso.DataSetName = "NewDataSet";
            this.dtsCompromisso.Tables.AddRange(new System.Data.DataTable[] {
            this.tbCompromisso});
            // 
            // tbCompromisso
            // 
            this.tbCompromisso.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.tbCompromisso.TableName = "tbCompromisso";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Assunto";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Data";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Hora Inicial";
            this.dataColumn4.ColumnName = "HoraInicio";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Hora Final";
            this.dataColumn5.ColumnName = "HoraTermino";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Contato";
            // 
            // btnAnteriores
            // 
            this.btnAnteriores.Location = new System.Drawing.Point(202, 288);
            this.btnAnteriores.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnteriores.Name = "btnAnteriores";
            this.btnAnteriores.Size = new System.Drawing.Size(148, 34);
            this.btnAnteriores.TabIndex = 8;
            this.btnAnteriores.Text = "Anteriores";
            this.btnAnteriores.UseVisualStyleBackColor = true;
            this.btnAnteriores.Click += new System.EventHandler(this.btnAnteriores_Click);
            // 
            // btnProximos
            // 
            this.btnProximos.Location = new System.Drawing.Point(376, 288);
            this.btnProximos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProximos.Name = "btnProximos";
            this.btnProximos.Size = new System.Drawing.Size(148, 34);
            this.btnProximos.TabIndex = 5;
            this.btnProximos.Text = "Próximos";
            this.btnProximos.UseVisualStyleBackColor = true;
            this.btnProximos.Click += new System.EventHandler(this.btnProximos_Click);
            // 
            // gbxConfiguracoes
            // 
            this.gbxConfiguracoes.Controls.Add(this.btnConfiguracao);
            this.gbxConfiguracoes.Controls.Add(this.btnCancelar);
            this.gbxConfiguracoes.Controls.Add(this.btnNovo);
            this.gbxConfiguracoes.Controls.Add(this.btnExcluir);
            this.gbxConfiguracoes.Controls.Add(this.btnEditar);
            this.gbxConfiguracoes.Location = new System.Drawing.Point(20, 21);
            this.gbxConfiguracoes.Margin = new System.Windows.Forms.Padding(2);
            this.gbxConfiguracoes.Name = "gbxConfiguracoes";
            this.gbxConfiguracoes.Padding = new System.Windows.Forms.Padding(2);
            this.gbxConfiguracoes.Size = new System.Drawing.Size(132, 342);
            this.gbxConfiguracoes.TabIndex = 6;
            this.gbxConfiguracoes.TabStop = false;
            this.gbxConfiguracoes.Text = "Settings";
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Location = new System.Drawing.Point(11, 190);
            this.btnConfiguracao.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(106, 34);
            this.btnConfiguracao.TabIndex = 4;
            this.btnConfiguracao.Text = "Configurações";
            this.btnConfiguracao.UseVisualStyleBackColor = true;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(29, 288);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(148, 34);
            this.btnTodos.TabIndex = 10;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            this.assuntoDataGridViewTextBoxColumn.ReadOnly = true;
            this.assuntoDataGridViewTextBoxColumn.Width = 130;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 80;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaInicioDataGridViewTextBoxColumn.Width = 65;
            // 
            // horaTerminoDataGridViewTextBoxColumn
            // 
            this.horaTerminoDataGridViewTextBoxColumn.DataPropertyName = "HoraTermino";
            this.horaTerminoDataGridViewTextBoxColumn.HeaderText = "HoraTermino";
            this.horaTerminoDataGridViewTextBoxColumn.Name = "horaTerminoDataGridViewTextBoxColumn";
            this.horaTerminoDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaTerminoDataGridViewTextBoxColumn.Width = 75;
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.gbxConfiguracoes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "FormCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compromisso";
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCompromisso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompromisso)).EndInit();
            this.gbxConfiguracoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.Button btnAnteriores;
        private System.Windows.Forms.Button btnProximos;
        private System.Windows.Forms.GroupBox gbxConfiguracoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.DataGridView dgvCompromisso;
        private System.Data.DataSet dtsCompromisso;
        private System.Data.DataTable tbCompromisso;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTerminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
    }
}