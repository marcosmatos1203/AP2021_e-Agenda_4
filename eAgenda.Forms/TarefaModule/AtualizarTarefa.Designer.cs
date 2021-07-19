
namespace eAgenda.Forms.TarefaModule
{
    partial class AtualizarTarefa
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
            this.dtpDataConclusao = new System.Windows.Forms.DateTimePicker();
            this.dtpDataAbertura = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtAlta = new System.Windows.Forms.RadioButton();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.rbtBaixo = new System.Windows.Forms.RadioButton();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.gbxConfiguracoes = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDataAbertura = new System.Windows.Forms.Label();
            this.lblDataConclusao = new System.Windows.Forms.Label();
            this.gbxLista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.lblDataConclusao);
            this.gbxLista.Controls.Add(this.lblDataAbertura);
            this.gbxLista.Controls.Add(this.dtpDataConclusao);
            this.gbxLista.Controls.Add(this.dtpDataAbertura);
            this.gbxLista.Controls.Add(this.groupBox1);
            this.gbxLista.Controls.Add(this.lblPercentual);
            this.gbxLista.Controls.Add(this.txtPercentual);
            this.gbxLista.Controls.Add(this.lblTitulo);
            this.gbxLista.Controls.Add(this.txtTitulo);
            this.gbxLista.Enabled = false;
            this.gbxLista.Location = new System.Drawing.Point(170, 21);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLista.Size = new System.Drawing.Size(393, 342);
            this.gbxLista.TabIndex = 9;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Dados da Tarefa";
            // 
            // dtpDataConclusao
            // 
            this.dtpDataConclusao.Location = new System.Drawing.Point(135, 293);
            this.dtpDataConclusao.Name = "dtpDataConclusao";
            this.dtpDataConclusao.Size = new System.Drawing.Size(235, 20);
            this.dtpDataConclusao.TabIndex = 22;
            // 
            // dtpDataAbertura
            // 
            this.dtpDataAbertura.Enabled = false;
            this.dtpDataAbertura.Location = new System.Drawing.Point(135, 78);
            this.dtpDataAbertura.Name = "dtpDataAbertura";
            this.dtpDataAbertura.Size = new System.Drawing.Size(235, 20);
            this.dtpDataAbertura.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtAlta);
            this.groupBox1.Controls.Add(this.rbtNormal);
            this.groupBox1.Controls.Add(this.rbtBaixo);
            this.groupBox1.Location = new System.Drawing.Point(28, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(341, 99);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prioridade";
            // 
            // rbtAlta
            // 
            this.rbtAlta.AutoSize = true;
            this.rbtAlta.Location = new System.Drawing.Point(255, 42);
            this.rbtAlta.Margin = new System.Windows.Forms.Padding(2);
            this.rbtAlta.Name = "rbtAlta";
            this.rbtAlta.Size = new System.Drawing.Size(43, 17);
            this.rbtAlta.TabIndex = 2;
            this.rbtAlta.Text = "Alta";
            this.rbtAlta.UseVisualStyleBackColor = true;
            this.rbtAlta.Click += new System.EventHandler(this.rbtAlta_Click);
            // 
            // rbtNormal
            // 
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Location = new System.Drawing.Point(140, 42);
            this.rbtNormal.Margin = new System.Windows.Forms.Padding(2);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(58, 17);
            this.rbtNormal.TabIndex = 1;
            this.rbtNormal.Text = "Normal";
            this.rbtNormal.UseVisualStyleBackColor = true;
            this.rbtNormal.Click += new System.EventHandler(this.rbtNormal_Click);
            // 
            // rbtBaixo
            // 
            this.rbtBaixo.AutoSize = true;
            this.rbtBaixo.Checked = true;
            this.rbtBaixo.Location = new System.Drawing.Point(26, 42);
            this.rbtBaixo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtBaixo.Name = "rbtBaixo";
            this.rbtBaixo.Size = new System.Drawing.Size(51, 17);
            this.rbtBaixo.TabIndex = 0;
            this.rbtBaixo.TabStop = true;
            this.rbtBaixo.Text = "Baixa";
            this.rbtBaixo.UseVisualStyleBackColor = true;
            this.rbtBaixo.Click += new System.EventHandler(this.rbtBaixo_Click);
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.Location = new System.Drawing.Point(26, 249);
            this.lblPercentual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(61, 13);
            this.lblPercentual.TabIndex = 17;
            this.lblPercentual.Text = "Percentual:";
            // 
            // txtPercentual
            // 
            this.txtPercentual.Location = new System.Drawing.Point(93, 245);
            this.txtPercentual.Margin = new System.Windows.Forms.Padding(2);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(277, 20);
            this.txtPercentual.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(25, 39);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(92, 34);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(277, 20);
            this.txtTitulo.TabIndex = 10;
            // 
            // gbxConfiguracoes
            // 
            this.gbxConfiguracoes.Controls.Add(this.btnSalvar);
            this.gbxConfiguracoes.Controls.Add(this.btnCancelar);
            this.gbxConfiguracoes.Location = new System.Drawing.Point(20, 21);
            this.gbxConfiguracoes.Margin = new System.Windows.Forms.Padding(2);
            this.gbxConfiguracoes.Name = "gbxConfiguracoes";
            this.gbxConfiguracoes.Padding = new System.Windows.Forms.Padding(2);
            this.gbxConfiguracoes.Size = new System.Drawing.Size(132, 342);
            this.gbxConfiguracoes.TabIndex = 8;
            this.gbxConfiguracoes.TabStop = false;
            this.gbxConfiguracoes.Text = "Settings";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(11, 34);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 34);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(11, 73);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 34);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(586, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDataAbertura
            // 
            this.lblDataAbertura.AutoSize = true;
            this.lblDataAbertura.Location = new System.Drawing.Point(26, 84);
            this.lblDataAbertura.Name = "lblDataAbertura";
            this.lblDataAbertura.Size = new System.Drawing.Size(91, 13);
            this.lblDataAbertura.TabIndex = 23;
            this.lblDataAbertura.Text = "Data de Abertura:";
            // 
            // lblDataConclusao
            // 
            this.lblDataConclusao.AutoSize = true;
            this.lblDataConclusao.Location = new System.Drawing.Point(26, 299);
            this.lblDataConclusao.Name = "lblDataConclusao";
            this.lblDataConclusao.Size = new System.Drawing.Size(101, 13);
            this.lblDataConclusao.TabIndex = 24;
            this.lblDataConclusao.Text = "Data de Conclusão:";
            // 
            // AtualizarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.gbxConfiguracoes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AtualizarTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Tarefa";
            this.gbxLista.ResumeLayout(false);
            this.gbxLista.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxConfiguracoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.GroupBox gbxConfiguracoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.RadioButton rbtBaixo;
        private System.Windows.Forms.RadioButton rbtAlta;
        private System.Windows.Forms.DateTimePicker dtpDataConclusao;
        private System.Windows.Forms.DateTimePicker dtpDataAbertura;
        private System.Windows.Forms.Label lblDataConclusao;
        private System.Windows.Forms.Label lblDataAbertura;
    }
}