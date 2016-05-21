using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Express
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            LEprintDocument.Print();
        } 
        /* private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            ev.Graphics.DrawString(txtName.Text.ToString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 20, 100);
        }
            */
        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TNameTextBox.Clear();
            TCompanyTextBox.Clear();
            TAptTextBox.Clear();
            TStreetTextBox.Clear();
            TCityTextBox.Clear();
            TStTextBox.Clear();
            TZipTextBox.Clear();
            SpecialTextBox.Clear();
            ShipDateComboBox.Text = "";
            LblSizeComboBox.Text = "";
            //SampleCheckBox.Clear();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            LEPrintPreviewDialog.Document = LEprintDocument;
            LEPrintPreviewDialog.ShowDialog();
        }

        private void LEprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Sender: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString(FNameTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 125));
            e.Graphics.DrawString("Company: " + FCompanyTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 145));
            e.Graphics.DrawString(FStreetTextBox.Text + " Aptmt: " + FAptTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 165));
            e.Graphics.DrawString(FCityTextBox.Text +  ", " + FStTextBox.Text + " " + FZipTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 185));

            e.Graphics.DrawString("Recipient: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(155, 220));
            e.Graphics.DrawString(TNameTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(155, 245));
            e.Graphics.DrawString("Company: " + TCompanyTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(155, 265));
            e.Graphics.DrawString(TStreetTextBox.Text + " Aptmt: " + TAptTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(155, 285));
            e.Graphics.DrawString(TCityTextBox.Text + ", " + TStTextBox.Text + " " + TZipTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(155, 305));
        }

        private void FZipTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
          
        }
       
    }
}
