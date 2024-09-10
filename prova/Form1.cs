using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova
{
    public partial class Form1 : Form
    {
        double tottal;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentCell.RowIndex);
                MessageBox.Show("Produto exclúido com sucesso", "Exlcusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTotal.Text = dgvProdutos.RowCount.ToString();
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dgvProdutos.RowCount = 0;
            double valor = double.Parse(txtqtnd.Text);
            double quantidade = double.Parse(txtvalor.Text);

           
            dgvProdutos.Rows.Add(txtproduto.Text, txtqtnd.Text, txtvalor.Text);
            tottal += quantidade * valor;
            lblTotal.Text = tottal.ToString("C");

           

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtalterar.Text != "")
            {
                dgvProdutos.CurrentRow.Cells["column1"].Value = txtalterar.Text;

                MessageBox.Show("Produto alterado com sucesso", "Exlusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void dgvProdutos_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProdutos.RowCount >0)
            {
                txtalterar.Text = dgvProdutos.CurrentRow.Cells["column1"].Value.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Clear();
            int venda =+ 1;
            lblvenda.Text = venda.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtvalor.Clear();
            txtqtnd.Clear();
            txtproduto.Clear();
            txtalterar.Clear();
        }
    }
}
