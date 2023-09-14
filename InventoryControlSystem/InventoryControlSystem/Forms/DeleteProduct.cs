using InventoryControlSystem.Entities;
using InventoryControlSystem.Repositories;

namespace InventoryControlSystem
{
    public partial class DeleteProduct : Form
    {
        public EventHandler DataDeleted;

        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int produtId = int.Parse(txt_id.Text);

            List<Product> list = ProductRepository.Instance.ListProducts();

            foreach (Product product in list)
            {
                if (product.Id == produtId)
                {
                    ProductRepository.Instance.RemoveProduct(product);
                    DataDeleted?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Produto excluído com sucesso!");
                    break;
                }
                else
                {
                    MessageBox.Show("ID não existe!");
                }
            }
        }
    }
}
