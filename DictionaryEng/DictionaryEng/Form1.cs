using DictionaryEnglishToVietnamese;
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

namespace DictionaryEng
{
    public partial class frmTuDien : Form
    {
        EnglishVietnameseDictionary dictionary = new EnglishVietnameseDictionary();
        DataTable dt = new DataTable();
        public frmTuDien()
        {
            InitializeComponent();
        }
       
        void loadAgain()
        {
            string filePath = "C:\\Users\\Administrator\\Desktop\\C# Projects\\DictionaryEng\\DictionaryEng\\test.txt";
            DataTable inputDataTable = new DataTable();
            inputDataTable.Columns.Add("Word");
            inputDataTable.Columns.Add("PartOfSpeech");
            inputDataTable.Columns.Add("Meaning");
            inputDataTable.Columns.Add("Example");

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                inputDataTable.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
            }
            dictionary = EnglishVietnameseDictionary.ConvertToDictionary(inputDataTable);
            dgvDictionary.DataSource = inputDataTable;
        }
        void readFile()
        {
            DataTable inputDataTable = new DataTable();
            inputDataTable.Columns.Add("Word");
            inputDataTable.Columns.Add("PartOfSpeech");
            inputDataTable.Columns.Add("Meaning");
            inputDataTable.Columns.Add("Example");

            string[] lines = File.ReadAllLines("C:\\Users\\Administrator\\Desktop\\C# Projects\\DictionaryEng\\DictionaryEng\\test.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                inputDataTable.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
            }

            dictionary = EnglishVietnameseDictionary.ConvertToDictionary(inputDataTable);

            DataTable outputDataTable = EnglishVietnameseDictionary.ConvertToDataTable(dictionary);
            dgvDictionary.DataSource = outputDataTable;
        }
        void convert()
        {
            dt = dictionary.ConvertToDataTable();

            StringBuilder textBuilder = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                string word = row["Word"].ToString();
                string partOfSpeech = row["PartOfSpeech"].ToString();
                string meaning = row["Meaning"].ToString();
                string example = row["Example"].ToString();

                string formattedEntry = $"{word}:{partOfSpeech}:{meaning}:\"{example}\"";
                textBuilder.AppendLine(formattedEntry);
            }

            string filePath = "C:\\Users\\Administrator\\Desktop\\C# Projects\\DictionaryEng\\DictionaryEng\\test.txt";
            File.WriteAllText(filePath, textBuilder.ToString());

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadAgain();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTu.Text == "" || cboLoaiTu.Text == "" || txtNghia.Text == "" || txtViDu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ!");
            }
            else
            {
                dictionary.AddEntry(txtTu.Text, cboLoaiTu.Text, txtNghia.Text, txtViDu.Text);
                loadAgain();
            }
        }

        private void dgvDictionary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0) { 
                txtTu.Text = dgvDictionary.Rows[index].Cells[0].Value.ToString();
                cboLoaiTu.Text = dgvDictionary.Rows[index].Cells[1].Value.ToString();
                txtNghia.Text = dgvDictionary.Rows[index].Cells[2].Value.ToString();
                txtViDu.Text = dgvDictionary.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if(Excel.baoCaoThongKeTuDien("Từ Điển", EnglishVietnameseDictionary.ConvertToDataTable(dictionary)))
            {

            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ!");
            }
            else
            {
                dictionary.RemoveEntry(txtTu.Text);
                convert();
                loadAgain();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            convert();
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            readFile();
        }

       
    }
}
