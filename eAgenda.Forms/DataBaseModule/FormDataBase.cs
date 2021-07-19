using eAgenda.Controladores.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms.DataBaseModule
{
    public partial class FormDataBase : Form
    {
        public FormDataBase()
        {
            InitializeComponent();
        }

        
        private void ckbSqlite_Click(object sender, EventArgs e)
        {
            ckbMSsqlServer.Checked = false;
        }

        private void ckbMSsqlServer_Click(object sender, EventArgs e)
        {
            ckbSqlite.Checked = false;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
