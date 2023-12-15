using System;
using System.Windows.Forms;
using DataSource;

namespace StoreInventory
{

    public partial class Form1 : Form
    {

        private StoreInventoryDB db;

        public Form1()
        {
            InitializeComponent();
            db = new StoreInventoryDB(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

            inventoryList.MouseDoubleClick += inventoryList_MouseDoubleClick;
            productList.MouseDoubleClick += productList_MouseDoubleClick;
            storeList.SelectedIndexChanged += storeList_SelectedIndexChanged;
            fill_form();
        }

        private void fill_form()
        {
            #region storeList
            var store_data = db.getStoreData();
            storeList.Items.Clear();
            foreach (var item in store_data)
            {
                storeList.Items.Add(item);
            }
            #endregion
            
            #region productList
            var products = db.getProductData();
            productList.Items.Clear();
            foreach (var item in products)
            {  
                productList.Items.Add(item); 
            }
            #endregion

            #region inventoryList
            var selectedStore = storeList.SelectedItem as StoreObject;
            if (selectedStore != null)
            {
                var inventory = db.getInventoryData(selectedStore.id);
                inventoryList.Items.Clear();
                foreach (var item in inventory)
                {
                    inventoryList.Items.Add(item);
                }
            }
            #endregion
        }

        private void AddStoreButton_Click(object sender, EventArgs e)
        {
            var item = new StoreObject
            {
                Name = StoreNameTextBox.Text,
                Street = StoreStreetTextBox.Text,
                City = StoreCityTextBox.Text,
                State = StoreStateTextBox.Text,
                Zip = StoreZipTextBox.Text
            };

            string error = db.Add(item);

            if (error == null)
            {
                fill_form();
                ClearStoreFields();
            }
            else
            {
                MessageBox.Show("Nie można dodać sklepu: " + error, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var item = new ProductObject
            {
                Manufacturer = ProductManufacturerTextBox.Text,
                Brand = ProductBrandTextBox.Text
            };

            string error = db.Add(item);

            if (error == null)
            {
                var products = db.getProductData();
                productList.Items.Clear();
                foreach (var item2 in products)
                {
                    productList.Items.Add(item2);
                }
                ClearProductFields();

            }
            else
            {
                MessageBox.Show("Nie można dodać produktu: " + error, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddInventoryButton_Click(object sender, EventArgs e)
        {
            var storeItem = storeList.SelectedItem as StoreObject;
            var productItem = productList.SelectedItem as ProductObject;
            if (storeItem != null && productItem != null)
            {
                string error = db.Add(new InventoryObject
                {
                    StoreId = storeItem.id,
                    ProductId = productItem.id,
                    Manufacturer = productItem.Manufacturer,
                    Brand = productItem.Brand
                });
                
                if (error == null)
                {
                    storeList_SelectedIndexChanged(sender, e);
                    MessageBox.Show("Dodano produkt do asortymentu sklepu.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                else
                {
                    MessageBox.Show("Nie można dodać produktu do asortymentu sklepu: " + error, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteStoreButton_Click(object sender, EventArgs e)
        {
            if (storeList.SelectedIndex >= 0)
            {
                var item = storeList.SelectedItem as StoreObject;
                if (item != null)
                {
                    string error = db.Delete(item);

                    if (error == null)
                    {
                        storeList_SelectedIndexChanged(sender, e);
                        fill_form();
                    }
                    else
                    {
                        MessageBox.Show("Nie można usunąć sklepu." + error, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (productList.SelectedIndex >= 0)
            {
                var item = productList.SelectedItem as ProductObject;
                if (item != null)
                {
                    string error = db.Delete(item);

                    if (error == null)
                    {
                        storeList_SelectedIndexChanged(sender, e);
                        var products = db.getProductData();
                        productList.Items.Clear();
                        foreach (var item2 in products)
                        {
                            productList.Items.Add(item2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie można usunąć produktu." + error, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteInventoryButton_Click(object sender, EventArgs e)
        {
            if (inventoryList.SelectedIndex >= 0)
            {
                var item = inventoryList.SelectedItem as InventoryObject;

                if (item != null)
                {
                    string error = db.Delete(item);
                    if (error == null)
                    {
                        storeList_SelectedIndexChanged(sender, e);
                    }

                    else
                    {
                        MessageBox.Show("Nie można usunąć pozycji z asortymentu: " + error, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void inventoryList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (inventoryList.SelectedIndex >= 0)
            {
                var item = inventoryList.SelectedItem as InventoryObject;

                if (item != null)
                {
                    string error = db.Delete(item);
                    if (error == null)
                    {
                        storeList_SelectedIndexChanged(sender, e);
                    }

                    else
                    {
                        MessageBox.Show("Nie można usunąć pozycji z asortymentu: " + error, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void productList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (productList.SelectedIndex >= 0)
            {
                var item = productList.SelectedItem as ProductObject;
                if (item != null)
                {
                    string error = db.Delete(item);

                    if (error == null)
                    {
                        storeList_SelectedIndexChanged(sender, e);
                        var products = db.getProductData();
                        productList.Items.Clear();
                        foreach (var item2 in products)
                        {
                            productList.Items.Add(item2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie można usunąć produktu." + error, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void storeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (storeList.SelectedIndex >= 0)
            {
                var selectedStore = storeList.SelectedItem as StoreObject;
                if (selectedStore != null)
                {
                    var inventory = db.getInventoryData(selectedStore.id);
                    inventoryList.Items.Clear();
                    foreach (var item in inventory)
                    {
                        inventoryList.Items.Add(item);
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void ClearStoreFields()
        {
            StoreNameTextBox.Text = "";
            StoreStreetTextBox.Text = "";
            StoreCityTextBox.Text = "";
            StoreStateTextBox.Text = "";
            StoreZipTextBox.Text = "";
        }

        private void ClearProductFields()
        {
            ProductManufacturerTextBox.Text = "";
            ProductBrandTextBox.Text = "";
        }
    }
}
