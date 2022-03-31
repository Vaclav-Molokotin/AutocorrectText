using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AutocorrectText
{
    public partial class FrmHome : Form
    {
        public string originalText = String.Empty;  //исходный текст
        public string replacedText = String.Empty;  //текст с произведённой автозаменой
        public string path = String.Empty;          //путь к файлу
        private static bool textReplaced = false;   //Произведена ли автозамена.
        public FrmHome()
        {
            InitializeComponent();
            openFileDialog.Filter = "Текстовый документ (*.txt)|*.txt";
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (textReplaced)
                rollback();
            else
                replace();
        }

        private void btnResetClick(object sender, EventArgs e)
        {
            originalText = tbSearch.Text = tbReplace.Text = tbText.Text = tbPath.Text = String.Empty;
            rollback();
        }

        private void replace()
        {
            if (tbSearch.Text == String.Empty || tbText.Text == String.Empty)
            {
                MessageBox.Show($"Заполните поля:\n" +
                $"{(tbSearch.Text == String.Empty ? labSearch.Text : String.Empty)}\n" +
                $"{(tbText.Text == String.Empty ? labText.Text : String.Empty)}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int count = (tbText.Text.Length - tbText.Text.Replace(tbSearch.Text, "").Length)
                    / tbSearch.Text.Length;

            replacedText = tbText.Text.Replace(tbSearch.Text, tbReplace.Text);
            tbText.Text = replacedText;

            MessageBox.Show($"Осуществлено замен: {count}.",
                            "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            labText.Text = "Изменённый текст";
            btnReplace.Text = "Назад";
            btnOpenOrSaveFile.Text = "Сохранить в файл";

            tbText.ReadOnly = true;
            tbSearch.Enabled = false;
            tbReplace.Enabled = false;
            tbPath.Enabled = false;

            textReplaced = true;
        }
        private void rollback()
        {
            labText.Text = "Исходный текст";
            btnReplace.Text = "Заменить";
            btnOpenOrSaveFile.Text = "Выбрать";
            tbText.Text = originalText;

            tbText.ReadOnly = false;
            tbSearch.Enabled = true;
            tbReplace.Enabled = true;
            tbPath.Enabled = true;

            btnReplace.Visible = true;
            btnOpenOrSaveFile.Visible = true;

            textReplaced = false;
        }

        private void btnOpenOrSaveFile_Click(object sender, EventArgs e)
        {
            if (textReplaced)
                saveToFile();
            else
                openFile();
        }
        private void openFile()
        {
            openFileDialog.FileName = String.Empty;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == String.Empty)
                return;
            tbPath.Text = openFileDialog.FileName; 
            readFile();
        }
        private void saveToFile()
        {
            saveFileDialog.FileName = String.Empty;
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName == String.Empty)
                return;
            using (StreamWriter f = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.GetEncoding(1251)))
            {
                f.Write(replacedText);
                f.Close();
            }
        }
        private void readFile()
        {
            try
            {
                if(tbPath.Text.)
                using (StreamReader reader = new StreamReader(tbPath.Text, Encoding.GetEncoding(1251)))
                {
                    tbText.Text = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                if (tbPath.Text == String.Empty)
                    return;
                MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            path = tbPath.Text;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FrmHelp f = new FrmHelp();
            f.ShowDialog();
        }

        private void tbText_OriginalTextChanged(object sender, EventArgs e)
        {
            if (!textReplaced)
            {
                originalText = tbText.Text;
            }
            
        }

        private void tbPath_EnterKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                readFile();
        }

        private void tbReplace_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void formHome_Load(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            FrmAbout d = new FrmAbout();
            d.ShowDialog();
        }
    }
}
