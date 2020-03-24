using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CovidSharp;

namespace Covid_19Sharp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoronavirusData data = new CoronavirusData();

            txtResults.Text = "";

            txtResults.Text += DateTime.Now.ToString();
            txtResults.Text += "\r\n";
            txtResults.Text += "\r\n";

            txtResults.Text += "Global";
            txtResults.Text += "\r\n";
            txtResults.Text += "~~~~~~";
            txtResults.Text += "\r\n";
            txtResults.Text += "Confirmed: ";
            txtResults.Text += data.LatestConfirmed() + "\r\n";

            txtResults.Text += "Recovered: ";
            txtResults.Text += data.LatestRecovered() + "\r\n";

            txtResults.Text += "Deaths: ";
            txtResults.Text += data.LatestDeaths() + "\r\n";


            txtResults.Text += "\r\n";

            txtResults.Text += comboBox1.SelectedItem.ToString();
            txtResults.Text += " Confirmed: ";
            txtResults.Text += data.FromCountryConfirmed(comboBox1.SelectedItem.ToString()) + "\r\n";


            txtResults.Text += comboBox1.SelectedItem.ToString();
            txtResults.Text += " Recovered: ";
            txtResults.Text += data.FromCountryRecovered(comboBox1.SelectedItem.ToString()) + "\r\n";


            txtResults.Text += comboBox1.SelectedItem.ToString();
            txtResults.Text += " Deaths: ";
            txtResults.Text += data.FromCountryDeaths(comboBox1.SelectedItem.ToString()) + "\r\n";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lineOfContents = File.ReadAllLines("countries.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                comboBox1.Items.Add(tokens[0]);
            }

            comboBox1.SelectedIndex = comboBox1.FindStringExact("GR");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
