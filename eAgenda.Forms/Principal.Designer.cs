
namespace eAgenda.Forms
{
    partial class Principal
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
            this.btnContato = new System.Windows.Forms.Button();
            this.btnTarefa = new System.Windows.Forms.Button();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.btnCompromisso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnOpcao = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnDetalhar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dtsContato = new System.Data.DataSet();
            this.tbContato = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dtsTarefa = new System.Data.DataSet();
            this.tbTarefa = new System.Data.DataTable();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dtsCompromisso = new System.Data.DataSet();
            this.tbCompromisso = new System.Data.DataTable();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.stsPrincipal = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCompromisso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompromisso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContato
            // 
            this.btnContato.Location = new System.Drawing.Point(11, 34);
            this.btnContato.Margin = new System.Windows.Forms.Padding(2);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(106, 34);
            this.btnContato.TabIndex = 0;
            this.btnContato.Text = "Contatos";
            this.btnContato.UseVisualStyleBackColor = true;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            // 
            // btnTarefa
            // 
            this.btnTarefa.Location = new System.Drawing.Point(11, 73);
            this.btnTarefa.Margin = new System.Windows.Forms.Padding(2);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(106, 34);
            this.btnTarefa.TabIndex = 1;
            this.btnTarefa.Text = "Tarefas";
            this.btnTarefa.UseVisualStyleBackColor = true;
            this.btnTarefa.Click += new System.EventHandler(this.btnTarefa_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Location = new System.Drawing.Point(11, 151);
            this.btnConfiguracao.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(106, 34);
            this.btnConfiguracao.TabIndex = 3;
            this.btnConfiguracao.Text = "Configurações";
            this.btnConfiguracao.UseVisualStyleBackColor = true;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.Location = new System.Drawing.Point(11, 112);
            this.btnCompromisso.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(106, 34);
            this.btnCompromisso.TabIndex = 2;
            this.btnCompromisso.Text = "Compromissos";
            this.btnCompromisso.UseVisualStyleBackColor = true;
            this.btnCompromisso.Click += new System.EventHandler(this.btnCompromisso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfiguracao);
            this.groupBox1.Controls.Add(this.btnContato);
            this.groupBox1.Controls.Add(this.btnCompromisso);
            this.groupBox1.Controls.Add(this.btnTarefa);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(132, 342);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvPrincipal);
            this.gbxLista.Controls.Add(this.btnOpcao);
            this.gbxLista.Controls.Add(this.btnNovo);
            this.gbxLista.Controls.Add(this.btnDetalhar);
            this.gbxLista.Enabled = false;
            this.gbxLista.Location = new System.Drawing.Point(170, 21);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLista.Size = new System.Drawing.Size(546, 342);
            this.gbxLista.TabIndex = 5;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Listas";
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(29, 35);
            this.dgvPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersVisible = false;
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.RowTemplate.Height = 24;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(494, 237);
            this.dgvPrincipal.TabIndex = 9;
            // 
            // btnOpcao
            // 
            this.btnOpcao.Location = new System.Drawing.Point(29, 286);
            this.btnOpcao.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpcao.Name = "btnOpcao";
            this.btnOpcao.Size = new System.Drawing.Size(148, 34);
            this.btnOpcao.TabIndex = 8;
            this.btnOpcao.Text = "mais";
            this.btnOpcao.UseVisualStyleBackColor = true;
            this.btnOpcao.Click += new System.EventHandler(this.btnOpcao_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(376, 286);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 34);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnDetalhar
            // 
            this.btnDetalhar.Location = new System.Drawing.Point(203, 286);
            this.btnDetalhar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetalhar.Name = "btnDetalhar";
            this.btnDetalhar.Size = new System.Drawing.Size(148, 34);
            this.btnDetalhar.TabIndex = 5;
            this.btnDetalhar.Text = "Detalhar";
            this.btnDetalhar.UseVisualStyleBackColor = true;
            this.btnDetalhar.Click += new System.EventHandler(this.btnDetalhar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsPrincipal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Id";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Titulo";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Prioridade";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Id";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Nome";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Telefone";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Empresa";
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
            this.dataColumn4});
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
            this.dataColumn4.ColumnName = "Empresa";
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
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14});
            this.tbTarefa.TableName = "tbTarefa";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Id";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "Titulo";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "Prioridade";
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
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18});
            this.tbCompromisso.TableName = "Table1";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Id";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "Assunto";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "Data";
            // 
            // dataColumn18
            // 
            this.dataColumn18.Caption = "Hora Inicial";
            this.dataColumn18.ColumnName = "HoraInicio";
            // 
            // stsPrincipal
            // 
            this.stsPrincipal.Name = "stsPrincipal";
            this.stsPrincipal.Size = new System.Drawing.Size(0, 17);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda";
            this.groupBox1.ResumeLayout(false);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCompromisso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompromisso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContato;
        private System.Windows.Forms.Button btnTarefa;
        private System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.Button btnCompromisso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.Button btnDetalhar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnOpcao;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataSet dtsContato;
        private System.Data.DataTable tbContato;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataSet dtsTarefa;
        private System.Data.DataTable tbTarefa;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataSet dtsCompromisso;
        private System.Data.DataTable tbCompromisso;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Windows.Forms.ToolStripStatusLabel stsPrincipal;
    }
}

