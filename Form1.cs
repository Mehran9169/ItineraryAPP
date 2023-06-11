using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Entities myEn = new Entities();

                myEn.FlightDate = dateTimePicker1.Value;

                myEn.ReturnDate = dateTimePicker2.Value;
                myEn.ChildCount = ChildCount.Value;
                myEn.AdultCount = AdultCount.Value;
                myEn.InfantCount = InfantCount.Value;
                myEn.Origin = originTextBox.Text;
                myEn.Destination = destinationTextBox.Text;

                MessageBox.Show("بلیط صادر گردید");

            } catch (Exception ex) { 
            
                MessageBox.Show(ex.Message);
            
             }
            
        }

        private void InfantCount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
