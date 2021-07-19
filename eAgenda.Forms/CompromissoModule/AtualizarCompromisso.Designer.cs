
namespace eAgenda.Forms.CompromissoModule
{
    partial class AtualizarCompromisso
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
            this.mtbHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.mtbHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.rbtPresencial = new System.Windows.Forms.RadioButton();
            this.rbtRemoto = new System.Windows.Forms.RadioButton();
            this.cbxContato = new System.Windows.Forms.ComboBox();
            this.ckbContato = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.gbxConfiguracoes = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gbxLista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.mtbHoraFim);
            this.gbxLista.Controls.Add(this.mtbHoraInicio);
            this.gbxLista.Controls.Add(this.groupBox1);
            this.gbxLista.Controls.Add(this.cbxContato);
            this.gbxLista.Controls.Add(this.ckbContato);
            this.gbxLista.Controls.Add(this.label6);
            this.gbxLista.Controls.Add(this.dtpData);
            this.gbxLista.Controls.Add(this.label4);
            this.gbxLista.Controls.Add(this.label2);
            this.gbxLista.Controls.Add(this.label1);
            this.gbxLista.Controls.Add(this.txtAssunto);
            this.gbxLista.Enabled = false;
            this.gbxLista.Location = new System.Drawing.Point(170, 21);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLista.Size = new System.Drawing.Size(396, 342);
            this.gbxLista.TabIndex = 9;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Dados do Compromisso";
            // 
            // mtbHoraFim
            // 
            this.mtbHoraFim.Location = new System.Drawing.Point(329, 123);
            this.mtbHoraFim.Mask = "00:00";
            this.mtbHoraFim.Name = "mtbHoraFim";
            this.mtbHoraFim.Size = new System.Drawing.Size(42, 20);
            this.mtbHoraFim.TabIndex = 2;
            this.mtbHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHoraInicio
            // 
            this.mtbHoraInicio.Location = new System.Drawing.Point(122, 123);
            this.mtbHoraInicio.Mask = "00:00";
            this.mtbHoraInicio.Name = "mtbHoraInicio";
            this.mtbHoraInicio.Size = new System.Drawing.Size(42, 20);
            this.mtbHoraInicio.TabIndex = 2;
            this.mtbHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLocal);
            this.groupBox1.Controls.Add(this.txtLocal);
            this.groupBox1.Controls.Add(this.rbtPresencial);
            this.groupBox1.Controls.Add(this.rbtRemoto);
            this.groupBox1.Location = new System.Drawing.Point(29, 200);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(341, 106);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a forma";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(16, 67);
            this.lblLocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(33, 13);
            this.lblLocal.TabIndex = 28;
            this.lblLocal.Text = "Data:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(72, 65);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(253, 20);
            this.txtLocal.TabIndex = 28;
            // 
            // rbtPresencial
            // 
            this.rbtPresencial.AutoSize = true;
            this.rbtPresencial.Location = new System.Drawing.Point(18, 28);
            this.rbtPresencial.Margin = new System.Windows.Forms.Padding(2);
            this.rbtPresencial.Name = "rbtPresencial";
            this.rbtPresencial.Size = new System.Drawing.Size(74, 17);
            this.rbtPresencial.TabIndex = 25;
            this.rbtPresencial.TabStop = true;
            this.rbtPresencial.Text = "Presencial";
            this.rbtPresencial.UseVisualStyleBackColor = true;
            this.rbtPresencial.Click += new System.EventHandler(this.rbtPresencial_Click);
            // 
            // rbtRemoto
            // 
            this.rbtRemoto.AutoSize = true;
            this.rbtRemoto.Location = new System.Drawing.Point(122, 28);
            this.rbtRemoto.Margin = new System.Windows.Forms.Padding(2);
            this.rbtRemoto.Name = "rbtRemoto";
            this.rbtRemoto.Size = new System.Drawing.Size(62, 17);
            this.rbtRemoto.TabIndex = 26;
            this.rbtRemoto.TabStop = true;
            this.rbtRemoto.Text = "Remoto";
            this.rbtRemoto.UseVisualStyleBackColor = true;
            this.rbtRemoto.Click += new System.EventHandler(this.rbtRemoto_Click);
            // 
            // cbxContato
            // 
            this.cbxContato.FormattingEnabled = true;
            this.cbxContato.Location = new System.Drawing.Point(222, 163);
            this.cbxContato.Margin = new System.Windows.Forms.Padding(2);
            this.cbxContato.Name = "cbxContato";
            this.cbxContato.Size = new System.Drawing.Size(149, 21);
            this.cbxContato.TabIndex = 24;
            // 
            // ckbContato
            // 
            this.ckbContato.AutoSize = true;
            this.ckbContato.Location = new System.Drawing.Point(29, 163);
            this.ckbContato.Margin = new System.Windows.Forms.Padding(2);
            this.ckbContato.Name = "ckbContato";
            this.ckbContato.Size = new System.Drawing.Size(189, 17);
            this.ckbContato.TabIndex = 23;
            this.ckbContato.Text = "Adicionar Contato ao compromisso";
            this.ckbContato.UseVisualStyleBackColor = true;
            this.ckbContato.Click += new System.EventHandler(this.ckbContato_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hora de término:";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(101, 76);
            this.dtpData.Margin = new System.Windows.Forms.Padding(2);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(270, 20);
            this.dtpData.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hora de início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Assunto:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(101, 34);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(270, 20);
            this.txtAssunto.TabIndex = 10;
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
            // AtualizarCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.gbxConfiguracoes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AtualizarCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Compromisso";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxContato;
        private System.Windows.Forms.CheckBox ckbContato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtPresencial;
        private System.Windows.Forms.RadioButton rbtRemoto;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.MaskedTextBox mtbHoraFim;
        private System.Windows.Forms.MaskedTextBox mtbHoraInicio;
    }
}