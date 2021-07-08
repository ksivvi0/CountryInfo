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

        public MainForm()
        {
            InitializeComponent();
        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInputText(CountryTextBox.Text))
                {
                    var country = await searcher.DoRequest(CountryTextBox.Text.Trim());
                    UpdateResults(ref country);
                }
            }
            catch (Exception ex)
            {
                logger.WriteLogAsync(ex.Message);
                ShowError(ex.Message);
            }
        }

        private async void ShowAllBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var countries = await searcher.DoRequest("ALL");
                UpdateResults(ref countries);
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

                searcher.OnError += ShowError;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckInputText(string text)
        {
            return !(string.IsNullOrEmpty(text) && string.IsNullOrWhiteSpace(text));
        }

        private void ShowError(string text)
        {
            MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateResults(ref CountryInfo[] data)
        {
            try
            {
                if (data.Length > 0)
                {
                    ResultsGrid.DataSource = data;
                    ExportBtn.Visible = true;
                }
                else
                    ShowError("Нет данных");
            }
            catch (Exception ex)
            {
                logger.WriteLogAsync(ex.Message);
            }
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            throw new Exception("обработчика пока нет...");
        }
    }
}
