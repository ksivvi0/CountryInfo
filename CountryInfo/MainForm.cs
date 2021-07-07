using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryInfo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        EventHandler<string> StatusBarUpdateText;
        

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CountryTextBox.Text) || string.IsNullOrWhiteSpace(CountryTextBox.Text))
            {
                
            }
                
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Подтвердить завершение?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ILogger logger = new Logger("country_info.log");

            ISearcher searcher = new Searcher("");
        }

        private void SetText(string text)
        {

        }
    }
}
