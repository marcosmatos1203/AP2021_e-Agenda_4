using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms.CompromissoModule
{
    public partial class AtualizarCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        ControladorContato controladorContato = new ControladorContato();
        Compromisso compromissoParaEditar;
        public AtualizarCompromisso()
        {
            InitializeComponent();
            gbxLista.Enabled = true;
        }
        public AtualizarCompromisso(Compromisso compromisso,string tipo)
        {
            InitializeComponent();
            compromissoParaEditar = compromisso;
            CarregaEdicao();
            if (tipo == "Editar")
                HabilitaEdicao();
            else
                btnSalvar.Text = "Editar";


        }

        #region Edição

        private void EditarCompromisso()
        {
            Compromisso compromisso = ObtemCompromisso();
            string resultadoValidacao = controladorCompromisso.Editar(compromissoParaEditar.Id, compromisso);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                this.Close();
            }
            else
            {
                //ApresentarMensagem(resultadoValidacao, TipoMensagem.Erro);
            }
        }
        private void CarregaEdicao() 
        {
            txtAssunto.Text = compromissoParaEditar.Assunto;
            dtpData.Value = compromissoParaEditar.Data;
            mtbHoraInicio.Text = compromissoParaEditar.HoraInicio.ToString();
            mtbHoraFim.Text=compromissoParaEditar.HoraTermino.ToString();
            if (compromissoParaEditar.Contato != null)
            {
                CarregaComboBox();
                ckbContato.Checked=true;
                cbxContato.SelectedItem = compromissoParaEditar.Contato.Nome;
            }
            if (compromissoParaEditar.Local == "Presencial")
            {
                lblLocal.Text = "Local:";
                txtLocal.Text = compromissoParaEditar.Local;
                rbtPresencial.Checked = true;
            }
            else
            {
                lblLocal.Text = "Link:";
                rbtRemoto.Checked = true;
                txtLocal.Text = compromissoParaEditar.Link;
            }
        }

        private void HabilitaEdicao()
        {
            gbxLista.Enabled = true;
            btnSalvar.Text = "Atualizar";
            
        }
        #endregion

        #region Botões Settings
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Salvar")
                SalvarCompromisso();
            else if (btnSalvar.Text == "Atualizar")
                EditarCompromisso();
            else if (btnSalvar.Text == "Editar")
                HabilitaEdicao();

        }


        #endregion


        private void SalvarCompromisso()
        {
            Compromisso compromisso = ObtemCompromisso();
            string resultadoValidacao = controladorCompromisso.InserirNovo(compromisso);
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                this.Close();
            }
            else
            {
                stsCompromisso.Text = "Falha ao salvar compromisso, revisse os dados";
            }
        }
        private void CarregaComboBox()
        {
            cbxContato.Items.Clear();
            List<Contato> contatos = controladorContato.SelecionarTodos();
            foreach (Contato contato in contatos)
            {
                cbxContato.Items.Add(contato.Nome);
            }
        }
        private Compromisso ObtemCompromisso()
        {
            string assunto = txtAssunto.Text;
            string local = "";
            string link = "";
            if (lblLocal.Text == "Link:")
            {
                local = "Remoto";
                link = txtLocal.Text;
            }
            else
            {
                link = "Presencial";
                local = txtLocal.Text;
            }
            DateTime data = dtpData.Value;
            TimeSpan horaInicio = TimeSpan.Parse(mtbHoraInicio.Text);
            TimeSpan horaFim = TimeSpan.Parse(mtbHoraFim.Text);
            Contato contato = null;
            if (ckbContato.Checked)
                contato = ObtemContato(cbxContato.SelectedItem.ToString());

            return new Compromisso(assunto, local, link, data, horaInicio, horaFim, contato);
        }
        private Contato ObtemContato(string nome)
        {
            Contato contato = controladorContato.SelecionarPorNome(nome);
            return contato;
        }
        private void rbtPresencial_Click(object sender, EventArgs e)
        {
            rbtRemoto.Checked = false;
            lblLocal.Text = "Local:";
        }

        private void rbtRemoto_Click(object sender, EventArgs e)
        {
            rbtPresencial.Checked = false;
            lblLocal.Text = "Link:";
        }

        private void ckbContato_Click(object sender, EventArgs e)
        {
            if (ckbContato.Checked)
                CarregaComboBox();
            else
                cbxContato.Items.Clear();
        }
    }
}
