using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
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
    public partial class FormTarefa : Form
    {
        ControladorTarefa controladorTarefa = new ControladorTarefa();
        public FormTarefa()
        {
            InitializeComponent();
            CarregarTarefasPendentes();
        }
        #region Botões Settings
        private void btnNovo_Click(object sender, EventArgs e)
        {
            AtualizarTarefa atualizarTarefa = new AtualizarTarefa();
            atualizarTarefa.ShowDialog();
            dtsTarefa.Clear();
            CarregarTarefasPendentes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = controladorTarefa.SelecionarPorId(Convert.ToInt32(dgvTarefa.CurrentRow.Cells[0].Value));
            AtualizarTarefa atualizarTarefaForm = new AtualizarTarefa(tarefa, "Editar");
            atualizarTarefaForm.ShowDialog();
            dtsTarefa.Clear();
            CarregarTarefasPendentes();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = controladorTarefa.SelecionarPorId(Convert.ToInt32(dgvTarefa.CurrentRow.Cells[0].Value));
            controladorTarefa.Excluir(tarefa.Id);
            dtsTarefa.Clear();
            CarregarTarefasPendentes();
            stsTarefa.Text = "Tarefa Excluída!";
        }
        #endregion


        #region Botões grid
        private void CarregarTarefasPendentes()
        {
            List<Tarefa> tarefas = controladorTarefa.SelecionarTodasTarefasPendentes();
            CarregarGrid(tarefas);
        }

        private void btnConcluidas_Click(object sender, EventArgs e)
        {
            gbxLista.Text = "Lista de Tarefas Concluídas";
            List<Tarefa> tarefas = controladorTarefa.SelecionarTodasTarefasConcluidas();
            CarregarGrid(tarefas);
        }
        private void btnPendentes_Click(object sender, EventArgs e)
        {
            gbxLista.Text = "Lista de Tarefas Pendentes";
            CarregarTarefasPendentes();
        }
        #endregion


        #region Grid
        private void CarregarGrid(List<Tarefa> Tarefas)
        {
            dtsTarefa.Clear();
            foreach (var item in Tarefas)
            {
                DataRow linha = tbTarefa.NewRow();
                linha["Id"] = item.Id;
                linha["Titulo"] = item.Titulo;
                linha["DataCriacao"] = item.DataCriacao.ToShortDateString();
                linha["Prioridade"] = item.Prioridade;
                linha["Percentual"] = item.Percentual;
                if (item.DataConclusao == null)
                    linha["DataConclusao"] = "Em Andamento";
                else
                    linha["DataConclusao"] = item.DataConclusao.Value.ToShortDateString();
                tbTarefa.Rows.Add(linha);
            }
        }
        #endregion

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            stsTarefa.Text = "Em construção, Aguardem...";
        }
    }
}
