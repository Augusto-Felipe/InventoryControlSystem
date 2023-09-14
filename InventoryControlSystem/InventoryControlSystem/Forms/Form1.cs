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
            List<Product> list = ProductRepository.Instance.ListProducts();

            if (list.Count == 0)
            {
                MessageBox.Show("Adicione itens na lista!");
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ProductRepository.Instance.ListProducts();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteForm = new DeleteProduct();
            deleteForm.DataDeleted += DataChanged;
            deleteForm.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditProduct editForm = new EditProduct();
            editForm.DataEdited += DataChanged;
            editForm.ShowDialog();
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductRepository.Instance.ListProducts();
        }

        private void DataChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}