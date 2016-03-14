using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Bradley Erickson--CIS199-01
 * assignment 3: This assignment will allow users to put items from an electronics store into a shopping cart for them to purchase.
 * Created: 3/18/2014
 */
namespace BradleyErickson_Assignment3
{
    public partial class Form1 : Form
    {
        private List<string> productsSelected;

        public Form1()
        {
            InitializeComponent();
            cboShippingOptions.SelectedIndex = 3;
            productsSelected = new List<string>();
        }

        private void AddItemsToCart(string aTablet)
        {
            productsSelected.Add(aTablet);
            PopulateListBox(productsSelected);
        }

        private void PopulateListBox(List<string> aList)
        {
            lstProductsSelected.Items.Clear();

            foreach (string productsSelected in aList)
            {
                lstProductsSelected.Items.Add(productsSelected);
            }
        }

        private void RemoveTablet(int index)
        {
            productsSelected.RemoveAt(index);
            PopulateListBox(productsSelected);
        }


        private string DisplayDetailsOfProduct(int index)
        {
            const int MICROSOFTSURFACEPRO_INDEX = 0;
            const int APPLEIPADAIR_INDEX = 1;
            const int SAMSUNGGALAXYTAB3_INDEX = 2;
            const int GOOGLENEXUS7_INDEX = 3;
            const int AMAZONKINDLEFIREHD_INDEX = 4;

            string productDeatils = txtProductDetails.Text;

            switch (index)
            {
                case 0:
                    productDeatils = "Product name: Microsoft surface Pro" + Environment.NewLine + "Screen size: 10.6"
                        + Environment.NewLine + "Storage Capacity: 128 GB" + Environment.NewLine + "Price: $999.99";
                    break;
                case 1:
                    productDeatils = "Product name: Apple iPad Air" + Environment.NewLine + "Screen size: 9.7"
                        + Environment.NewLine + "Storage capacity: 16 GB" + Environment.NewLine + "Price: $479.99";
                    break;
                case 2:
                    productDeatils = "Product name: Samsung Galaxy Tab 3" + Environment.NewLine + "Screen Size: 10.1"
                        + Environment.NewLine + "Storage capacity: 16 GB" + Environment.NewLine + "Price: $349.99";
                    break;
                case 3:
                    productDeatils = "Product name: Google Nexus 7" + Environment.NewLine + "Screen size: 7"
                        + Environment.NewLine + "Storage capacity: 16 GB" + Environment.NewLine + "Price: $229.99";
                    break;
                case 4:
                    productDeatils = "Product name: Amazon Kindle fire HD" + Environment.NewLine + "Screen size: 7"
                        + Environment.NewLine + "Storage capacity: 16 GB" + Environment.NewLine + "Price: $149.99";
                    break;
            }
            return productDeatils;
        }


        private string DisplayShippingDate(int index)
        {

            string shippingDate = cboShippingOptions.Text;
            DateTime oneDay = DateTime.Today.AddDays(1);
            DateTime twoDay = DateTime.Today.AddDays(2);
            DateTime oneWeek = DateTime.Today.AddDays(7);
            DateTime twoWeek = DateTime.Today.AddDays(14);

            switch (index)
            {
                case 0:
                    shippingDate = "Delivery in 1 day(s): " + oneDay.ToString("MM/d/yyyy");
                    break;
                case 1:
                    shippingDate = "Delivery in 2 day(s): " + twoDay.ToString("MM/d/yyyy");
                    break;
                case 2:
                    shippingDate = "Delivey in 7 day(s): " + oneWeek.ToString("MM/d/yyyy");
                    break;
                case 3:
                    shippingDate = "Delivery in 14 day(s): " + twoWeek.ToString("MM/d/yyyy");
                    break;
            }
            return shippingDate;
        }

        private DateTime GetShippingDate(int index)
        {
            DateTime shippingDate= DateTime.Today;

            const int ONEDAY_INDEX = 0;
            const int TWODAY_INDEX = 1;
            const int ONEWEEK_INDEX = 2;
            const int TWOWEEK_INDEX = 3;

            DateTime oneDay = DateTime.Today.AddDays(1);
            DateTime twoDay = DateTime.Today.AddDays(2);
            DateTime oneWeek = DateTime.Today.AddDays(7);
            DateTime twoWeek = DateTime.Today.AddDays(14);

            switch (index)
            {
                case ONEDAY_INDEX:
                    shippingDate = oneDay;
                    break;
                case TWODAY_INDEX:
                    shippingDate = twoDay;
                    break;
                case ONEWEEK_INDEX:
                    shippingDate = oneWeek;
                    break;
                case TWOWEEK_INDEX:
                    shippingDate = twoWeek;
                    break;
            }
            return shippingDate;
        }

        private double GetShippingCost(int index)
        {
            const int ONEDAY_INDEX = 0;
            const int TWODAY_INDEX = 1;
            const int ONEWEEK_INDEX = 2;
            const int TWOWEEK_INDEX = 3;

            const double ONEDAYPRICE = 24.99;
            const double TWODAYPRICE = 19.99;
            const double ONEWEEKPRICE = 14.99;
            const double TWOWEEKPRICE = 5.99;

            double shippingPrice = 0;

            switch (index)
            {
                case ONEDAY_INDEX:
                    shippingPrice = ONEDAYPRICE;
                    break;
                case TWODAY_INDEX:
                    shippingPrice = TWODAYPRICE;
                    break;
                case ONEWEEK_INDEX:
                    shippingPrice = ONEWEEKPRICE;
                    break;
                case TWOWEEK_INDEX:
                    shippingPrice = TWOWEEKPRICE;
                    break;
            }
            return shippingPrice;
        }

        private void lstSelectProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProductDetails.Text = DisplayDetailsOfProduct(lstSelectProducts.SelectedIndex).ToString();
        }

        private void lstSelectProducts_DoubleClick(object sender, EventArgs e)
        {
            lstProductsSelected.Items.Add(lstSelectProducts.SelectedItem);
            AddItemsToCart(lstSelectProducts.Text);
        }

        private void cboShippingOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDeliveryDate.Text = DisplayShippingDate(cboShippingOptions.SelectedIndex).ToString();
            lblShippingCost.Text = GetShippingCost(cboShippingOptions.SelectedIndex).ToString();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

            if (!(lstProductsSelected.Items.Count > 0))
            {
                MessageBox.Show("You must first select a product", "Missing Selection Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                double subTotal = 0;
                double discount = 0;
                double total = 0;
                double salesTax;
                double shippingCost;
                const double SALES_TAX_RATE = .06;

                shippingCost = GetShippingCost(cboShippingOptions.SelectedIndex);

                const string MICROSOFTSURFACEPRO = "Microsoft Surface Pro";
                const string APPLEIPADAIR = "Apple iPad Air";
                const string SAMSUNGGALAXYTAB3 = "Samsung Galaxy Tab 3";
                const string GOOGLENEXUS7 = "Google Nexus 7";
                const string AMAZONKINDLEFIREHD = "Amazon Kindle Fire HD";

                const double MICROSOFTSURFACEPRO_PRICE = 999.99;
                const double APPLEIPADAIR_PRICE = 479.99;
                const double SAMSUNGGALAXYTAB3_PRICE = 349.99;
                const double GOOGLENEXUS7_PRICE = 229.99;
                const double AMAZONKINDLEFIREHD_PRICE = 149.99;

                foreach (string product in lstProductsSelected.Items)
                {
                    switch (product)
                    {
                        case MICROSOFTSURFACEPRO:
                            subTotal += MICROSOFTSURFACEPRO_PRICE;
                            break;
                        case APPLEIPADAIR:
                            subTotal += APPLEIPADAIR_PRICE;
                            break;
                        case SAMSUNGGALAXYTAB3:
                            subTotal += SAMSUNGGALAXYTAB3_PRICE;
                            break;
                        case GOOGLENEXUS7:
                            subTotal += GOOGLENEXUS7_PRICE;
                            break;
                        case AMAZONKINDLEFIREHD:
                            subTotal += AMAZONKINDLEFIREHD_PRICE;
                            break;
                    }
                }

                if (subTotal > 800)
                {
                    discount = subTotal * .25;
                }
                else if (subTotal > 600)
                {
                    discount = subTotal * .1;
                }

                salesTax = subTotal * SALES_TAX_RATE;
                total = (subTotal + salesTax + shippingCost) - discount;

                lblSubtotal.Text = subTotal.ToString("c");
                lblSalesTax.Text = (subTotal * SALES_TAX_RATE).ToString("c");
                lblDiscount.Text = discount.ToString("c");
                lblTotal.Text = total.ToString("c");

                calShippingCalender.SetDate(GetShippingDate(cboShippingOptions.SelectedIndex));

            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lstProductsSelected.Items.Clear();
            lblSubtotal.Text = "";
            lblSalesTax.Text = "";
            lblDiscount.Text = "";
            lblTotal.Text = "";

            cboShippingOptions.SelectedIndex = 3;
            tabControl1.SelectedIndex = 0;
            productsSelected.Clear();

            calShippingCalender.SetDate(DateTime.Today);
        }

        private void lstProductsSelected_DoubleClick(object sender, EventArgs e)
        {
            if (lstProductsSelected.SelectedIndex != -1)
            {
                RemoveTablet(lstProductsSelected.SelectedIndex);
            }
        }
    }
}
        


                   
         
            

    

