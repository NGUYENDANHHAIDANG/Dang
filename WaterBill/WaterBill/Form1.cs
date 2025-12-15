using System.Xml.Linq;

namespace WaterBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lvCustomer.SelectedItems.Count == 0) return;

            ListViewItem item = lvCustomer.SelectedItems[0];
            int index = item.Index;

            if (index == 0) return;

            lvCustomer.Items.RemoveAt(index);
            lvCustomer.Items.Insert(index - 1, item);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                string name = tbCustomerName.Text.Trim();
                string type = cbbCustomerType.Text.Trim();
                double thisMonth, lastMonth;


                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type) || !double.TryParse(tbThisMonthRead.Text, out thisMonth) || !double.TryParse(tbLastMonthRead.Text, out lastMonth))
                {
                    MessageBox.Show("Plase enter entity.");
                    return;
                }


                double consumption = thisMonth - lastMonth;
                if (consumption < 0)
                {
                    MessageBox.Show("This Month's Reading >= Last Month's Reading.");
                    return;
                }


                tbWaterConsumtion.Text = consumption.ToString();


                double totalBill = CalculateWaterBill(type, consumption);


                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(type);
                item.SubItems.Add(thisMonth.ToString());
                item.SubItems.Add(lastMonth.ToString());
                item.SubItems.Add(consumption.ToString());
                item.SubItems.Add(totalBill.ToString());

                lvCustomer.Items.Add(item);

            }



        }

        private double CalculateWaterBill(string customerType, double consumption)
        {
            double rate;

            if (customerType.ToLower() == "household")
            {

                int numberOfPeople = 1;


                if (consumption <= 10 * numberOfPeople)
                {
                    return 5.973 * consumption; ;
                }
                else if (consumption <= 20 * numberOfPeople)
                {
                    return 7.052 * consumption; ;
                }
                else if (consumption <= 30 * numberOfPeople)
                {
                    return 8.699 * consumption; ;
                }
                else
                {
                    return 15.929 * consumption; ;
                }
            }
            else if (customerType.ToLower() == "administrative")
            {

                return 9.955 * consumption;
            }
            else if (customerType.ToLower() == "production")
            {
                return 11.615 * consumption; ;
            }
            else if (customerType.ToLower() == "business services")
            {
                return 22.068 * consumption; ;
            }
            else
            {
                throw new ArgumentException("Invalid customer type.");
            }
        }

        static double GetEnvironmentalProtectionFee(string customerType, double consumption)
        {
            if (customerType.ToLower() == "household")
            {
                if (consumption <= 10)
                {
                    return 597.30;
                }
                else if (consumption <= 20)
                {
                    return 705.20;
                }
                else if (consumption <= 30)
                {
                    return 866.90;
                }
                else
                {
                    return 1592.90;
                }
            }
            else if (customerType.ToLower() == "administrative")
            {
                return 995.50;
            }
            else if (customerType.ToLower() == "production")
            {
                return 1161.50;
            }
            else if (customerType.ToLower() == "business services")
            {
                return 2206.80;
            }
            else
            {
                throw new ArgumentException("Invalid customer type.");
            }


            return consumption;
        }

        private void lvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbWaterConsumtion_TextChanged(object sender, EventArgs e)
        {

            int lastMonthRead, thisMonthRead;
            if (int.TryParse(tbLastMonthRead.Text, out lastMonthRead) && int.TryParse(tbThisMonthRead.Text, out thisMonthRead))
            {
                tbWaterConsumtion.Text = (thisMonthRead - lastMonthRead).ToString();
            }
            else
            {
                tbWaterConsumtion.Text = string.Empty;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvCustomer.SelectedItems.Count > 0)
            {
                lvCustomer.Items.Remove(lvCustomer.SelectedItems[0]);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                string keyword = tbSearch.Text.Trim().ToLower();

                if (keyword == "")
                {
                    MessageBox.Show("Plase Enter Entity");
                    return;
                }

                bool found = false;

                foreach (ListViewItem item in lvCustomer.Items)
                {
                    if (item.Text.ToLower().Contains(keyword))
                    {
                        item.Selected = true;
                        lvCustomer.Focus();
                        found = true;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Not Found!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvCustomer.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvCustomer.SelectedItems[0];

            double thisMonth, lastMonth;
            if (double.TryParse(tbThisMonthRead.Text, out thisMonth) && double.TryParse(tbLastMonthRead.Text, out lastMonth))
            {
                double consumption = thisMonth - lastMonth;
                item.SubItems[0].Text = tbCustomerName.Text;
                item.SubItems[1].Text = cbbCustomerType.Text;
                item.SubItems[2].Text = tbThisMonthRead.Text;
                item.SubItems[3].Text = tbLastMonthRead.Text;
                item.SubItems[4].Text = consumption.ToString();
                item.SubItems[5].Text = CalculateWaterBill(cbbCustomerType.Text, consumption).ToString();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
