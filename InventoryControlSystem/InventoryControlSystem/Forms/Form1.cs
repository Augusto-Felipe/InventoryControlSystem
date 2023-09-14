using InventoryControlSystem.Entities;
using InventoryControlSystem.Repositories;

namespace InventoryControlSystem
{
    public partial class Form1 : Form
    {
        ProductRepository inventory = new ProductRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string productName = txt_name.Text;
            if (productName.Length > 0)
            {
                Product product = new Product(productName);
                //inventory.AddProduct(product);
                ProductRepository.Instance.AddProduct(product);
                MessageBox.Show("Item inserido com sucesso!");
            }
            else
            {
                MessageBox.Show("Nome deve ter mais de 1 caractere!");
            }

            txt_name.Text = "";
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            //List<Product> list = inventory.ListProducts();

            List<Product> list = ProductRepository.Instance.ListProducts();

            if (list.Count == 0)
            {
                MessageBox.Show("Adicione itens na lista!");
            }
            else
            {
                dataGridView1.DataSource = null;
                //dataGridView1.DataSource = inventory.ListProducts();
                dataGridView1.DataSource = ProductRepository.Instance.ListProducts();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            List<Product> list = ProductRepository.Instance.ListProducts();

            if (!string.IsNullOrEmpty(txt_name.Text))
            {
                int produtId = int.Parse(txt_name.Text);

                foreach (Product product in list)
                {
                    if (product.Id == produtId)
                    {
                        inventory.RemoveProduct(product);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ProductRepository.Instance.ListProducts();
                        MessageBox.Show("Produto excluído com sucesso!");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("ID não existe!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira o ID");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            EditProduct editForm = new EditProduct();
            editForm.ShowDialog();

            //List<Product> list = inventory.ListProducts();

            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    int selectedProductID = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;

            //    foreach (Product product in list)
            //    {
            //        if (product.Id == selectedProductID)
            //        {
            //            EditProduct editForm = new EditProduct(product);
            //            editForm.ShowDialog();
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Selecione um produto na tabela!");
            //}
        }
    }
}