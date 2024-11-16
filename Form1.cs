namespace Sort_a_student_s_grades
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>
            {
            new Product("Shirt", 15.99, "Clothing"),
            new Product("Shoes", 49.99, "Footwear"),
            new Product("Coffee Maker", 80.50, "Electronics"),
            new Product("Pants", 22.75, "Clothing"),
            new Product("Microphone", 60.00, "Electronics"),
            new Product("Chair", 35.00, "Furniture")
            };

            // Initialize the DataGridView
            dataGridView1.DataSource = products;
        }

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            BubbleSortByPrice(products);
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = products; 
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            BubbleSortByName(products);
            dataGridView1.DataSource = null;  
            dataGridView1.DataSource = products;
        }

        private void BubbleSortByPrice(List<Product> products)
        {
            int n = products.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (products[j].Price > products[j + 1].Price)
                    {
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }
        }

        private void BubbleSortByName(List<Product> products)
        {
            int n = products.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(products[j].Name, products[j + 1].Name) > 0)
                    {
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }
        }
    }
}
