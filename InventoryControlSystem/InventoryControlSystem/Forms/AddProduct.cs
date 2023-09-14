using InventoryControlSystem.Entities;
using InventoryControlSystem.Repositories;

namespace InventoryControlSystem.Forms
{
    public partial class AddProduct : Form
    {
        public AddProduct()
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
                this.Close();
            }
            else
            {
                MessageBox.Show("Nome deve ter mais de 1 caractere!");
            }
        }
    }
}
