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
        private ILogger logger;
        private ISearcher searcher;
        public event EventHandler<CountryInfo[]> OnCountryLoaded;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInputText(CountryTextBox.Text))
                {
                    try
                    {
                        searcher.DoRequest(CountryTextBox.Text.Trim());
                    }
                    catch(Exception reqErr)
                    {
                        logger.WriteLogAsync(reqErr.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.WriteLogAsync(ex.Message);
                ShowError(ex.Message);
            }
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            try
            {
                searcher.DoRequest("ALL");
            }
            catch (Exception ex)
            {
                logger.WriteLogAsync(ex.Message);
                ShowError(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Подтвердить завершение?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                logger = new Logger("country_info.log");
                searcher = new Searcher("https://restcountries.eu/rest/v2");
                searcher.OnDataLoad += Searcher_OnDataLoad;
                searcher.OnError += Searcher_OnError;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Searcher_OnError(string data)
        {
            StatusBar.ResetText();
            StatusBar.Text = data;
        }

        private void Searcher_OnDataLoad(CountryInfo[] countries)
        {
            ResultsBox.Clear();
            ResultsBox.Text = countries[0].Name;
        }

        private bool CheckInputText(string text)
        {
            return !(string.IsNullOrEmpty(text) && string.IsNullOrWhiteSpace(text));
        }

        private void ShowError(string text)
        {
            MessageBox.Show(text);
        }
    }
}
