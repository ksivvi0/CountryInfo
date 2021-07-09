using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryInfo
{
    public partial class MainForm : Form
    {
        private ILogger logger;
        private ISearcher searcher;
        private IStore store;
        private Config config;

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

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                config = await CreateNewConfig("config.json");
                logger = new Logger("country_info.log");

                searcher = new Searcher("https://restcountries.eu/rest/v2");
                store = new Store($"UID={config.Username};Password={config.Passwd};Server={config.ServerName}");

                searcher.OnError += ShowError;
                store.SQLResult += Store_SQLResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Store_SQLResult(Dictionary<string, bool> obj)
        {
            throw new NotImplementedException();
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

        private async Task<Config> CreateNewConfig(string path)
        {
            if (!File.Exists(path))
                throw new Exception("некорректный файл конфигурации");
            using (var file = File.OpenRead(path))
            {
                var cfg = await JsonSerializer.DeserializeAsync<Config>(file);
                return cfg;
            }
        }
    }
}
