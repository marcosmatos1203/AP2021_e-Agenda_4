using eAgenda.Controladores.ContatoModule;
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

namespace eAgenda.Forms.ContatoModule
{
    public partial class AtualizarContato : Form
    {
        ControladorContato controladorContato = new ControladorContato();
        Contato contatoParaEditar;
        public AtualizarContato()
        {
            InitializeComponent();
            gbxLista.Enabled = true;
        }
        public AtualizarContato(Contato contato, string tipo)
        {
            InitializeComponent();
            btnSalvar.Text = "Atualizar";
            contatoParaEditar = contato;
            CarregaContatoParaEditar();
            if (tipo == "Editar")
                HabilitaEdicao(contato);
            else
                btnSalvar.Text = "Editar";
        }
       
        private void HabilitaEdicao(Contato contato)
        {
            gbxLista.Enabled = true;
            btnSalvar.Text = "Atualizar";

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private Contato ObterContato()
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;
            return new Contato(nome, email, telefone, empresa, cargo);
        }
        private void CarregaContatoParaEditar()
        {
            txtNome.Text = contatoParaEditar.Nome;
            txtEmail.Text = contatoParaEditar.Email;
            txtTelefone.Text = contatoParaEditar.Telefone;
            txtCargo.Text = contatoParaEditar.Cargo;
            txtEmpresa.Text = contatoParaEditar.Empresa;
            
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Salvar")
                SalvarContato();
            else if (btnSalvar.Text == "Atualizar")
                EditarContato();
            else if (btnSalvar.Text == "Editar")
                HabilitaEdicao(contatoParaEditar);


        }
        private void SalvarContato()
        {
            Contato novoContato = ObterContato();
            string resultadoValidacao = controladorContato.InserirNovo(novoContato);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                this.Close();
            }

            else
            {
                stsContato.Text = "Falha ao salvar o contato, revise os dados";
            }
        }
      
        private void EditarContato()
        {
            Contato contato = ObterContato();
            string resultadoValidacao = controladorContato.Editar(contatoParaEditar.Id, contato);

            if (resultadoValidacao == "ESTA_VALIDO")
            {

                //ApresentarMensagem(MensagemDeEdicaoComSucesso(), TipoMensagem.Sucesso); 
                this.Close();
            }

            else
            {
                //ApresentarMensagem(resultadoValidacao, TipoMensagem.Erro);
                
            }
        }
    }
}
