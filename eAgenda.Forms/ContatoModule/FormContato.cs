using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Forms.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms
{
    public partial class FormContato : Form
    {
        ControladorContato controladorContato;
        public FormContato()
        {
            controladorContato = new ControladorContato();
            InitializeComponent();
            CarregarContatosPorNome();
        }

        #region Botões Settings
        private void btnNovo_Click(object sender, EventArgs e)
        {
            AtualizarContato atualizarContato = new AtualizarContato();
            atualizarContato.ShowDialog();
            dtsContato.Clear();
            CarregarContatosPorNome();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contato = controladorContato.SelecionarPorId(Convert.ToInt32(dgvContato.CurrentRow.Cells[0].Value));
            AtualizarContato atualizarContatoForm = new AtualizarContato(contato,"Editar");
            atualizarContatoForm.ShowDialog();
            dtsContato.Clear();
            CarregarContatosPorNome();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contato = controladorContato.SelecionarPorId(Convert.ToInt32(dgvContato.CurrentRow.Cells[0].Value));
            controladorContato.Excluir(contato.Id);
            dtsContato.Clear();
            CarregarContatosPorNome();
            stsContato.Text = "Contato Excluído";
        }
        #endregion

        #region Grid
        private void CarregarGrid(List<Contato> contatos)
        {
            foreach (var item in contatos)
            {
                DataRow linha = tbContato.NewRow();
                linha["Id"] = item.Id;
                linha["Nome"] = item.Nome;
                linha["Telefone"] = item.Telefone;
                linha["Cargo"] = item.Cargo;
                linha["Empresa"] = item.Empresa;
                tbContato.Rows.Add(linha);
            }
        }
        #endregion

        #region Opções do grid
        private void btnAgruparPorId_Click(object sender, EventArgs e)
        {
            dtsContato.Clear();
            CarregarContatosAgrupadosPorId();
        }
        private void CarregarContatosAgrupadosPorId()
        {
            List<Contato> contatos = controladorContato.SelecionarTodosContatosAgrupadoPorId();
            CarregarGrid(contatos);
        }
        private void btnAgruparPorNome_Click(object sender, EventArgs e)
        {
            dtsContato.Clear();
            CarregarContatosPorNome();
        }
        private void CarregarContatosPorNome()
        {
            List<Contato> contatos = controladorContato.SelecionarTodos();
            CarregarGrid(contatos);
        }
        private void btnAgrupar_Click(object sender, EventArgs e)
        {
            dtsContato.Clear();
            CarregarContatosAgrupadosPorCargo();
        }
        private void CarregarContatosAgrupadosPorCargo()
        {
            List<Contato> contatos = controladorContato.SelecionarTodosContatosAgrupadoPorCargo();
            CarregarGrid(contatos);
        }
        #endregion

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            stsContato.Text = "Em construção, Aguardem...";
        }
    }
}
