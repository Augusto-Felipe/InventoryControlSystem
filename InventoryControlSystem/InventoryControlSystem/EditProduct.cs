using InventoryControlSystem.Entities;

namespace InventoryControlSystem
{
    public partial class EditProduct : Form
    {
        Product Product;

        public EditProduct(Product product)
        {
            InitializeComponent();
            Product = product;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_newName.Text))
            {
                string newProductName = text_newName.Text;
                Product.Name = newProductName;
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite um nome");
            }
        }
    }
}
