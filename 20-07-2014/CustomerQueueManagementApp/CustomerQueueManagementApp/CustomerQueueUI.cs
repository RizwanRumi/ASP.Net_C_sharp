using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementApp
{
    public partial class CustomerQueueUI : Form
    {
        private Queue<Customer> customerInQueueList = new Queue<Customer>();
        public int tokenNumber = 1;
        public int enqueueSerialNumber;
        public CustomerQueueUI()
        {
            InitializeComponent();
        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {

            if (enqueueNameTextBox.Text != "" && enqueueComplainTextBox.Text != "")
            {
                Customer aCustomerInfo = new Customer();
                aCustomerInfo.customerName = enqueueNameTextBox.Text;
                aCustomerInfo.customerComplain = enqueueComplainTextBox.Text;
                aCustomerInfo.serialNo = Convert.ToString(tokenNumber++);

                customerInQueueList.Enqueue(aCustomerInfo);

                clearEnqueueTextFields();
                MessageBox.Show(aCustomerInfo.GetName());
                serialLbel.Text = "Serial No :   " + (tokenNumber);

                showlistView.Items.Clear();

                foreach (Customer aCustomer in customerInQueueList)
                {
                    ListViewItem aListViewItem = new ListViewItem();
                    aListViewItem.Text = aCustomer.serialNo;
                    aListViewItem.SubItems.Add(aCustomer.customerName);
                    aListViewItem.SubItems.Add(aCustomer.customerComplain);
                    showlistView.Items.Add(aListViewItem);
                }
            }
            else
            {
                MessageBox.Show("please Fill up the info. textfields");
                enqueueNameTextBox.Text = "";
                enqueueComplainTextBox.Text = "";
            }
        }

        private void clearEnqueueTextFields()
        {
            enqueueNameTextBox.Text = string.Empty;
            enqueueComplainTextBox.Text = string.Empty;
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            int total;

            total = customerInQueueList.Count;

            if (total != 0)
            {
                showlistView.Items[0].Remove();

                Customer aCustomerInfo = new Customer();
                aCustomerInfo = (Customer) customerInQueueList.Dequeue();
                serialNoTextBox.Text = aCustomerInfo.serialNo;
                dequeueNameTextBox.Text = aCustomerInfo.customerName;
                dequeueComplainTextBox.Text = aCustomerInfo.customerComplain;


            }
            else
            {
                MessageBox.Show("There are no person in queue");
                serialNoTextBox.Text = string.Empty;
                dequeueNameTextBox.Text = string.Empty;
                dequeueComplainTextBox.Text = string.Empty;
            }

        }

       
      

    }
}
