using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Forms.CompromissoModule;
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
    public partial class FormCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        public FormCompromisso()
        {
            InitializeComponent();
            CarregarCompromissosFuturos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AtualizarCompromisso atualizarCompromisso = new AtualizarCompromisso();
            atualizarCompromisso.ShowDialog();
            dtsCompromisso.Clear();
            CarregarCompromissosFuturos();

        }

        private void CarregarCompromissosFuturos()
        {
            List<Compromisso> Compromissos = controladorCompromisso.SelecionarCompromissosFuturos(DateTime.Now,DateTime.Now.AddDays(7));
            CarregarGrid(Compromissos);
            gbxLista.Text = "Lista de compromissos para a próxima semana";
        }
        private void CarregarCompromissosPassados()
        {
            List<Compromisso> Compromissos = controladorCompromisso.SelecionarCompromissosPassados(DateTime.Now.AddDays(-7));
            CarregarGrid(Compromissos);
            gbxLista.Text = "Lista de compromissos passados da última semana";
        }
        private void CarregarGrid(List<Compromisso> compromissos)
        {
            dtsCompromisso.Clear();
            foreach (Compromisso item in compromissos)
            {
                DataRow linha = tbCompromisso.NewRow();
                linha["Id"] = item.Id;
                linha["Assunto"] = item.Assunto;
                linha["Data"] = item.Data.ToShortDateString();
                linha["HoraInicio"] = item.HoraInicio;
                linha["HoraTermino"] = item.HoraTermino;
                if (item.Contato == null)
                    linha["Contato"] = "Contato não cadastrado";
                else
                    linha["Contato"] = item.Contato.Nome;
                tbCompromisso.Rows.Add(linha);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = controladorCompromisso.SelecionarPorId(Convert.ToInt32(dgvCompromisso.CurrentRow.Cells[0].Value));
            AtualizarCompromisso atualizarCompromisso = new AtualizarCompromisso(compromisso, "Editar");
            atualizarCompromisso.ShowDialog();
            dtsCompromisso.Clear();
            CarregarCompromissosFuturos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAnteriores_Click(object sender, EventArgs e)
        {
            CarregarCompromissosPassados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = controladorCompromisso.SelecionarPorId(Convert.ToInt32(dgvCompromisso.CurrentRow.Cells[0].Value));
            controladorCompromisso.Excluir(compromisso.Id);
            dtsCompromisso.Clear();
            CarregarCompromissosFuturos();
            stsCompromisso.Text = "Compromisso excluído";
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            List<Compromisso> Compromissos = controladorCompromisso.SelecionarTodos();
            CarregarGrid(Compromissos);
            gbxLista.Text = "Lista de todos os compromissos";
        }

        private void btnProximos_Click(object sender, EventArgs e)
        {
            CarregarCompromissosFuturos();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            stsCompromisso.Text = "Em construção, Aguardem...";
        }
    }
}
