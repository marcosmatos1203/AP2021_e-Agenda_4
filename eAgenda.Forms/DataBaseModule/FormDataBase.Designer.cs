
namespace eAgenda.Forms.DataBaseModule
{
    partial class FormDataBase
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
            this.ckbMSsqlServer = new System.Windows.Forms.CheckBox();
            this.ckbSqlite = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbMSsqlServer
            // 
            this.ckbMSsqlServer.AutoSize = true;
            this.ckbMSsqlServer.Location = new System.Drawing.Point(228, 43);
            this.ckbMSsqlServer.Name = "ckbMSsqlServer";
            this.ckbMSsqlServer.Size = new System.Drawing.Size(160, 17);
            this.ckbMSsqlServer.TabIndex = 1;
            this.ckbMSsqlServer.Text = "MICROSOFT SQL SERVER";
            this.ckbMSsqlServer.UseVisualStyleBackColor = true;
            this.ckbMSsqlServer.Click += new System.EventHandler(this.ckbMSsqlServer_Click);
            // 
            // ckbSqlite
            // 
            this.ckbSqlite.AutoSize = true;
            this.ckbSqlite.Checked = true;
            this.ckbSqlite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSqlite.Location = new System.Drawing.Point(52, 43);
            this.ckbSqlite.Name = "ckbSqlite";
            this.ckbSqlite.Size = new System.Drawing.Size(64, 17);
            this.ckbSqlite.TabIndex = 2;
            this.ckbSqlite.Text = "SQLITE";
            this.ckbSqlite.UseVisualStyleBackColor = true;
            this.ckbSqlite.Click += new System.EventHandler(this.ckbSqlite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbSqlite);
            this.groupBox1.Controls.Add(this.ckbMSsqlServer);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o Banco de Dados";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(325, 129);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 34);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 176);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda Data Base";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbMSsqlServer;
        private System.Windows.Forms.CheckBox ckbSqlite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
    }
}