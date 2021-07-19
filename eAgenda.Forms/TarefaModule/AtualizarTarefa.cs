using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms.TarefaModule
{
    public partial class AtualizarTarefa : Form
    {
        ControladorTarefa controladorTarefa = new ControladorTarefa();
        Tarefa tarefaParaEditar = new Tarefa();
        public AtualizarTarefa()
        {
            InitializeComponent();
            VisualizacaoDeFerramentasNovaTarefa();
        }
        private void VisualizacaoDeFerramentasNovaTarefa()
        {
            dtpDataAbertura.Enabled = false;
            dtpDataConclusao.Visible = false;
            gbxLista.Enabled = true;
            txtPercentual.Visible = false;
            lblDataConclusao.Visible = false;
        }
        public AtualizarTarefa(Tarefa tarefa, string tipo)
        {
            tarefaParaEditar = tarefa;
            InitializeComponent();
            CarregaEdicao();
            if (tipo == "Editar")
                HabilitaEdicao(tarefa);  
            else
                btnSalvar.Text = "Editar";

        }
        private void HabilitaEdicao(Tarefa tarefa)
        {
            if (tarefa.DataConclusao == null)
                lblDataConclusao.Visible = false;
            gbxLista.Enabled = true;
            btnSalvar.Text = "Atualizar";
            
        }
        private void CarregaEdicao()
        {
            txtTitulo.Text = tarefaParaEditar.Titulo;
            txtPercentual.Text = tarefaParaEditar.Percentual.ToString();
            dtpDataAbertura.Value = (DateTime)tarefaParaEditar.DataCriacao;
            if (tarefaParaEditar.DataConclusao == null)
                dtpDataConclusao.Visible = false;
            else
            {
                dtpDataConclusao.Value = (DateTime)tarefaParaEditar.DataConclusao;
                dtpDataConclusao.Visible = true;
                dtpDataConclusao.Enabled = false;
            }
        }
        #region Botões Settings
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Salvar")
                SalvarTarefa();
            else if (btnSalvar.Text == "Atualizar")
                EditarTarefa();
            else if (btnSalvar.Text == "Editar")
                HabilitaEdicao(tarefaParaEditar);
        }
        private void SalvarTarefa()
        {
            Tarefa novaTarefa = ObterTarefa();
            string resultadoValidacao = controladorTarefa.InserirNovo(novaTarefa);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                this.Close();
            }

            else
            {
                stsTarefa.Text = "Falha ao salvar tarefa. Tente novamente";
            }
        }
        private void EditarTarefa()
        {
            Tarefa tarefaEditada = ObterTarefaEditada(tarefaParaEditar);
            string resultadoValidacao = controladorTarefa.Editar(tarefaParaEditar.Id, tarefaEditada);

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
        #endregion

        private int radioButtonSelecionado()
        {
            int prioridade = 0;
            if (rbtBaixo.Checked == true)
                prioridade = 0;
            else if (rbtNormal.Checked == true)
                prioridade = 1;
            else if (rbtAlta.Checked == true)
                prioridade = 2;
            return prioridade;
        }
        private Tarefa ObterTarefaEditada(Tarefa tarefa)
        {
            
            string titulo = txtTitulo.Text;
            int prioridade = radioButtonSelecionado();
            Tarefa tarefaEditada = new Tarefa(titulo, tarefa.DataCriacao, (PrioridadeEnum)prioridade);
            tarefaEditada.AtualizarPercentual(Convert.ToInt32(txtPercentual.Text),DateTime.Now);
            tarefaEditada.Id = tarefa.Id;
            return tarefaEditada;
        }
        private Tarefa ObterTarefa()
        {
            string titulo = txtTitulo.Text;
            int prioridade = radioButtonSelecionado();

            return new Tarefa(titulo, DateTime.Now.Date, (PrioridadeEnum)prioridade);
        }

        private void rbtBaixo_Click(object sender, EventArgs e)
        {
            rbtAlta.Checked = false;
            rbtNormal.Checked = false;
        }

        private void rbtNormal_Click(object sender, EventArgs e)
        {
            rbtAlta.Checked = false;
            rbtBaixo.Checked = false;
        }

        private void rbtAlta_Click(object sender, EventArgs e)
        {
            rbtBaixo.Checked = false;
            rbtNormal.Checked = false;
        }
    }
}
