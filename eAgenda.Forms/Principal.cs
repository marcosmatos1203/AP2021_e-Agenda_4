using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.TarefaModule;
using eAgenda.Forms.CompromissoModule;
using eAgenda.Forms.ContatoModule;
using eAgenda.Forms.DataBaseModule;
using eAgenda.Forms.TarefaModule;
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
    public partial class Principal : Form
    {
        ControladorContato controladorContato = new ControladorContato();
        ControladorTarefa controladorTarefa = new ControladorTarefa();
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        public Principal()
        {
            InitializeComponent();
            CarregarContatos();
        }
        #region Botoes Settings
        private void btnContato_Click(object sender, EventArgs e)
        {
            atualizaBotoesContato();
            CarregarContatos();
            stsPrincipal.Text = "Previa dos Contatos...";
        }

        private void btnTarefa_Click(object sender, EventArgs e)
        {
            atualizaBotoesTarefa();
            CarregarTarefas();
            stsPrincipal.Text = "Previa das Tarefas...";
        }
        private void btnCompromisso_Click(object sender, EventArgs e)
        {
            atualizaBotoesCompromisso();
            CarregarCompromissos();
            stsPrincipal.Text = "Previa dos Compromissos...";
        }
        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            FormDataBase dataBase = new FormDataBase();
            dataBase.ShowDialog();
        }
        #endregion

        #region Botões do Grid
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if(btnNovo.Text== "Novo Tarefa")
            {
                AtualizarTarefa atualizarTarefa = new AtualizarTarefa();
                atualizarTarefa.ShowDialog();
                RecarregaDataSet();
            }
            else if(btnNovo.Text == "Novo Contato")
            {
                AtualizarContato atualizarContato = new AtualizarContato();
                atualizarContato.ShowDialog();
                RecarregaDataSet();
            }
            else if (btnNovo.Text == "Novo Compromisso")
            {
                AtualizarCompromisso atualizarCompromisso = new AtualizarCompromisso();
                atualizarCompromisso.ShowDialog();
                RecarregaDataSet();
            }
        }

        private void btnOpcao_Click(object sender, EventArgs e)
        {
            if (btnOpcao.Text == "Opções de Tarefa")
            {

                FormTarefa tarefa = new FormTarefa();
                tarefa.ShowDialog();
                RecarregaDataSet();

            }
            else if (btnOpcao.Text == "Opções de Contato")
            {
                FormContato contato = new FormContato();
                contato.ShowDialog();
                RecarregaDataSet();

            }
            else if (btnOpcao.Text == "Opções de Compromisso")
            {
                FormCompromisso compromisso = new FormCompromisso();
                compromisso.ShowDialog();
                RecarregaDataSet();
            }
        }
        private void btnDetalhar_Click(object sender, EventArgs e)
        {
            if (btnDetalhar.Text == "Detalhar Contato")
            {
                EnviaContatoParaEditar();
            }
            else if (btnDetalhar.Text == "Detalhar Tarefa")
            {
                EnviaTarefaParaEditar();
            }
            else if (btnDetalhar.Text == "Detalhar Compromisso")
            {
                EnviaCompromissoParaEditar();
            }
        }
        #endregion

        #region Atualiza Botoes
        private void atualizaBotoesCompromisso()
        {
            btnDetalhar.Text = "Detalhar Compromisso";
            btnNovo.Text = "Novo Compromisso";
            gbxLista.Text = "Lista de Compromissos";
            btnOpcao.Text = "Opções de Compromisso";
            gbxLista.Enabled = true;
        }
        private void atualizaBotoesContato()
        {
            btnDetalhar.Text = "Detalhar Contato";
            btnNovo.Text = "Novo Contato";
            gbxLista.Text = "Lista de Contatos";
            btnOpcao.Text = "Opções de Contato";
            gbxLista.Enabled = true;
        }
        private void atualizaBotoesTarefa()
        {
            btnDetalhar.Text = "Detalhar Tarefa";
            btnNovo.Text = "Novo Tarefa";
            gbxLista.Text = "Lista de Tarefas";
            btnOpcao.Text = "Opções de Tarefa";
            gbxLista.Enabled = true;
        }
        #endregion

        #region Atualiza Grid
        private void atualizaGridParaContato()
        {
            dtsContato.Clear();
            dgvPrincipal.DataSource = dtsContato;
            dgvPrincipal.DataMember = tbContato.ToString();
            dgvPrincipal.Columns["Id"].Width = 40;
            dgvPrincipal.Columns["Nome"].Width = 190;
            dgvPrincipal.Columns["Telefone"].Width = 113;
            dgvPrincipal.Columns["Empresa"].Width = 130;
        }
        private void atualizaGridParaTarefa()
        {
            dtsTarefa.Clear();
            dgvPrincipal.DataSource = dtsTarefa;
            dgvPrincipal.DataMember = tbTarefa.ToString();
            dgvPrincipal.Columns["Id"].Width = 40;
            dgvPrincipal.Columns["Titulo"].Width = 255;
            dgvPrincipal.Columns["Prioridade"].Width = 178;
        }
        private void atualizaGridParaCompromisso()
        {
            dtsCompromisso.Clear();
            dgvPrincipal.DataSource = dtsCompromisso;
            dgvPrincipal.DataMember = tbCompromisso.ToString();
            dgvPrincipal.Columns["Id"].Width = 40;
            dgvPrincipal.Columns["Assunto"].Width = 233;
            dgvPrincipal.Columns["Data"].Width = 100;
            dgvPrincipal.Columns["HoraInicio"].Width = 100;
        }
        private void RecarregaDataSet()
        {
            dtsTarefa.Clear();
            CarregarTarefas();

            dtsContato.Clear();
            CarregarContatos();

            dtsCompromisso.Clear();
            CarregarCompromissos();
        }
        #endregion

        #region Carrega Grid
        private void CarregarContatos()
        {
            atualizaGridParaContato();
            List<Contato> contatos = controladorContato.SelecionarTodos();

            foreach (Contato item in contatos)
            {
                DataRow linha = tbContato.NewRow();
                linha["Id"] = item.Id;
                linha["Nome"] = item.Nome;
                linha["Telefone"] = item.Telefone;
                linha["Empresa"] = item.Empresa;
                tbContato.Rows.Add(linha);
            }
        }
        private void CarregarCompromissos()
        {
            atualizaGridParaCompromisso();
            List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();
            foreach (Compromisso item in compromissos)
            {
                DataRow linha = tbCompromisso.NewRow();
                linha["Id"] = item.Id;
                linha["Assunto"] = item.Assunto;
                linha["Data"] = item.Data.ToShortDateString();
                linha["HoraInicio"] = item.HoraInicio;
                tbCompromisso.Rows.Add(linha);
            }
        }
        private void CarregarTarefas()
        {
            atualizaGridParaTarefa();
            List<Tarefa> tarefas = controladorTarefa.SelecionarTodasTarefasPendentes();

            foreach (Tarefa item in tarefas)
            {
                DataRow linha = tbTarefa.NewRow();
                linha["Id"] = item.Id;
                linha["Titulo"] = item.Titulo;
                linha["Prioridade"] = item.Prioridade;
                tbTarefa.Rows.Add(linha);
            }
        }
        #endregion

        #region Edita Registros
        private void EnviaContatoParaEditar()
        {
            Contato contato = controladorContato.SelecionarPorId(Convert.ToInt32(dgvPrincipal.CurrentRow.Cells[0].Value));
            AtualizarContato atualizarContatoForm = new AtualizarContato(contato, "Detalhar");
            atualizarContatoForm.ShowDialog();
            dtsContato.Clear();
            CarregarContatos();
        }
        private void EnviaTarefaParaEditar()
        {
            Tarefa tarefa = controladorTarefa.SelecionarPorId(Convert.ToInt32(dgvPrincipal.CurrentRow.Cells[0].Value));
            AtualizarTarefa atualizarTarefaForm = new AtualizarTarefa(tarefa,"Detalhar");
            atualizarTarefaForm.ShowDialog();
            dtsTarefa.Clear();
            CarregarTarefas();
        }
        private void EnviaCompromissoParaEditar()
        {
            Compromisso compromisso = controladorCompromisso.SelecionarPorId(Convert.ToInt32(dgvPrincipal.CurrentRow.Cells[0].Value));
            AtualizarCompromisso atualizarCompromissoForm = new AtualizarCompromisso(compromisso, "Detalhar");
            atualizarCompromissoForm.ShowDialog();
            dtsCompromisso.Clear();
            CarregarContatos();
        }
        #endregion

    }
}
