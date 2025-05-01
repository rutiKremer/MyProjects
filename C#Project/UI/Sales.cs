
using BlApi;
using BO;

namespace UI
{
    public partial class Sales : Form
    {
        private static IBl _bl = BlApi.Factory.Get();
        private static List<BO.Sale> sales = _bl.Sale.ReadAll(readAll)!;

        public Sales()
        {
            InitializeComponent();
            IsTheSaleForEverybody.Items.Add("v");
            IsTheSaleForEverybody.Items.Add("x");
            isForS.Items.Add("v");
            isForS.Items.Add("x");
            idList.DataSource = sales.Select(s => s.Id).ToList();
            id.DataSource = sales.Select(s => s.Id).ToList();
            allSales.DataSource = sales.Select(s => s.ToStringProperty()).ToList();
            oneSale.DataSource = sales.Select(s => s.Id).ToList();
            filter.Items.Add("מבצעים שעדיין בתוקף");
            filter.Items.Add("מבצעים שהם לכלל הלקוחות");
            filter.Items.Add("מבצעים שהכמות לקבלת המבצע גדולה מ-5");
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idProduct.Text);
                int amount = int.Parse(AmountForSale.Text);
                double priceInSale = double.Parse(IncludingPriceInSale.Text);
                bool isTheSaleForEverybody = IsTheSaleForEverybody.SelectedItem.Equals("v");
                DateTime dateBegin = dateBeginSale.Value;
                DateTime dateEnd = dateEndSale.Value;
                BO.Sale sale = new BO.Sale(0, id, amount, priceInSale, isTheSaleForEverybody, dateBegin, dateEnd);
                _bl.Sale.Create(sale);
                MessageBox.Show("המבצע נוסף בהצלחה");
                idProduct.Clear();
                //AmountForSale.; // מנקה את שדה הטקסט של כמות למכירה
                //IncludingPriceInSale.Clear(); // מנקה את שדה הטקסט של המחיר במבצע
                //IsTheSaleForEverybody.SelectedIndex = null; // מבטל את הבחירה בשדה האם המבצע לכולם
                dateBeginSale.Value = dateBeginSale.MinDate;
                dateEndSale.Value = dateEndSale.MinDate;
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
                int id = (int)idList.SelectedItem;
                _bl.Sale.Delete(id);
                MessageBox.Show("המבצע נמחק בהצלחה");
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
                int idS = (int)id.SelectedItem;
                int idProduct = int.Parse(idP.Text);
                int amount = int.Parse(amountS.Text);
                double priceInSale = double.Parse(priceS.Text);
                bool isTheSaleForEverybody = isForS.SelectedItem.Equals("v");
                DateTime dateBegin = dateBeginS.Value;
                DateTime dateEnd = dateEndS.Value;
                BO.Sale sale = new BO.Sale(idS, idProduct, amount, priceInSale, isTheSaleForEverybody, dateBegin, dateEnd);
                _bl.Sale.Update(sale);
                MessageBox.Show("המבצע עודכן בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool readAll(BO.Sale s)
        {
            if (s != null)
                return true;
            return false;
        }

        private void allS_Click(object sender, EventArgs e)
        {
            allSales.DataSource = sales.Select(s => s.ToStringProperty()).ToList();
        }

        private void find_Click(object sender, EventArgs e)
        {
            BO.Sale s = _bl.Sale.Read(int.Parse(oneSale.Text))!;
            allSales.DataSource = null;
            allSales.DataSource = new List<string>() { s.ToStringProperty() }.ToList();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string fil = filter.Text;
            if (fil.Equals("מבצעים שעדיין בתוקף"))
                filterByStillExist();
            if (fil.Equals("מבצעים שהם לכלל הלקוחות"))
                filterByForAllCustomers();
            if (fil.Equals("מבצעים שהכמות לקבלת המבצע גדולה מ-5"))
                filterByAmountToGet();
        }

        public void filterByStillExist()
        {
            allSales.DataSource = _bl.Sale.ReadAll(s => s.DateEndSale <= DateTime.Now).Select(c => c.ToStringProperty()).ToList();
        }

        public void filterByForAllCustomers()
        {
            allSales.DataSource = _bl.Sale.ReadAll(s => s.IsTheSaleForEverybody).Select(c => c.ToStringProperty()).ToList();
        }

        public void filterByAmountToGet()
        {
            allSales.DataSource = _bl.Sale.ReadAll(s => s.AmountForSale > 5).Select(c => c.ToStringProperty()).ToList();
        }
    }
}


