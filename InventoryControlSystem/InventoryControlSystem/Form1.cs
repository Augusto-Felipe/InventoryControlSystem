using InventoryControlSystem.Entities;

namespace InventoryControlSystem
{
    public partial class Form1 : Form
    {
        Inventory inventory = new Inventory();

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
                inventory.AddProduct(product);
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
            List<Product> list = inventory.ListProducts();

            if (list.Count == 0)
            {
                MessageBox.Show("Adicione itens na lista!");
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = inventory.ListProducts();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            List<Product> list = inventory.ListProducts();

            if (!string.IsNullOrEmpty(txt_name.Text))
            {
                int produtId = int.Parse(txt_name.Text);

                foreach (Product product in list)
                {
                    if (product.Id == produtId)
                    {
                        inventory.RemoveProduct(product);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = inventory.ListProducts();
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
    }
}