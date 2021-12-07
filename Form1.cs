using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSC240_10_04_ViewInvoices_bpc
{
    public partial class Form1 : Form
    {
        const char DELIM = ',';
        const string FILENAME = @"C:\CSharp\Chapter14\Invoices.txt";
        string recordIn;
        string[] fields;
        static FileStream file = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UxViewButton_Click(object sender, EventArgs e)
        {
            try{
                recordIn = reader.ReadLine();
                fields = recordIn.Split(DELIM);
                UxInvoiceBox.Text = fields[0];
                UxNameBox.Text = fields[1];
                UxAmountBox.Text = fields[2];
            }
            catch (NullReferenceException)
            {
                UxViewTitleLabel.Text = "You have viewed\nall the records";
                UxViewButton.Enabled = false;
            }
        }
    }
}
