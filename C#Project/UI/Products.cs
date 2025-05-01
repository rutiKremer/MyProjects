using BlApi;
using BO;

namespace UI
{
    public partial class Products : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        private static List<BO.Product> products = _bl.Product.ReadAll(readAll)!;

        public Products()
        {
            InitializeComponent();
            category.Items.Add("שולחן_ואירוח");
            category.Items.Add("מטבח");
            category.Items.Add("חדר_שינה");
            category.Items.Add("חדר_רחצה");
            category.Items.Add("דקורציה_ופנאי");
            ////////////////////////////////////
            categoryP.Items.Add("מטבח");
            categoryP.Items.Add("שולחן_ואירוח");
            categoryP.Items.Add("חדר_שינה");
            categoryP.Items.Add("חדר_רחצה");
            categoryP.Items.Add("דקורציה_ופנאי");
            ///////////////////////////////
            allProduct.DataSource = products.Select(p => p.ToStringProperty()).ToList();
            productList.DataSource = products.Select(p => p.NameProduct).ToList();
            productForUpdate.DataSource = products.Select(p => p.NameProduct).ToList();
            oneProduct.DataSource = products.Select(p => p.IdProduct).ToList();
            filter.Items.Add("מוצרים שבמלאי");
            filter.Items.Add("מוצרים שמחירם קטן מ40 שקלים");
            //filter.Items.Add("מוצרים שקיימים עבורם מבצעים");
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameProduct.Text;
                string categoryP = category.SelectedItem.ToString()!;
                BO.Categories categorySelected = (BO.Categories)Enum.Parse(typeof(BO.Categories), categoryP);
                double priceP = (double)price.Value;
                int amount = (int)stockAmount.Value;
                BO.Product product = new BO.Product(0, name, categorySelected, priceP, amount);
                _bl.Product.Create(product);
                MessageBox.Show("המוצר נוסף בהצלחה");
                nameProduct.Clear();
                category.SelectedItem = null;
                price.Value = price.Minimum;
                stockAmount.Value = stockAmount.Minimum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string name = (string)productList.SelectedItem;
                var product = products.First(p => p.NameProduct == name);
                _bl.Product.Delete(product.IdProduct);
                MessageBox.Show("המוצר נמחק בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string nameSelected = productForUpdate.SelectedItem.ToString()!;
                var productSelected = products.First(p => p.NameProduct == nameSelected);
                string name = pName.Text;
                string categoryPro = categoryP.SelectedItem.ToString()!;
                BO.Categories categorySelected = (BO.Categories)Enum.Parse(typeof(BO.Categories), categoryPro);
                double pricePro = (double)priceP.Value;
                int amountPro = (int)amount.Value;
                BO.Product product = new BO.Product(productSelected.IdProduct, name, categorySelected, pricePro, amountPro);
                _bl.Product.Update(product);
                MessageBox.Show("המוצר עודכן בהצלחה");
                //productForUpdate.Items.Clear();
                //pName.Clear();
                //categoryP.Items.Clear();
                //priceP.Refresh();
                //amount.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            BO.Product p = _bl.Product.Read(int.Parse(oneProduct.Text))!;
            allProduct.DataSource = null;
            allProduct.DataSource = new List<string>() { p.ToStringProperty() }.ToList();
        }

        public static bool readAll(BO.Product p)
        {
            if (p != null)
                return true;
            return false;
        }

        private void allP_Click(object sender, EventArgs e)
        {
            allProduct.DataSource = products.Select(p => p.ToStringProperty()).ToList();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string fil = filter.Text;
            if (fil.Equals("מוצרים שבמלאי"))
                filterByExistProduct();
            if (fil.Equals("מוצרים שמחירם קטן מ40 שקלים"))
                filterByCheapProduct();   
        }

        private void filterByExistProduct()
        {
            allProduct.DataSource = _bl.Product.ReadAll(p => p.StockAmount > 0).Select(p => p.ToStringProperty()).ToList();
        }

        private void filterByCheapProduct()
        {
            allProduct.DataSource = _bl.Product.ReadAll(p => p.Price < 40).Select(p => p.ToStringProperty()).ToList();
        }


    }
}
