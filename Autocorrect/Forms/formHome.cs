using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Autocorrect
{
    public partial class formHome : Form
    {
        public string originalText = String.Empty;  //исходный текст
        public string replacedText = String.Empty;  //текст с произведённой автозаменой
        public string path = String.Empty;          //путь к файлу
        private static bool textReplaced = false;   //Произведена ли автозамена.
        public formHome()
        {
            InitializeComponent();
        }

        

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == String.Empty || textBox.Text == String.Empty)
            {
                MessageBox.Show($"Заполните поля:\n" +
                $"{(textBoxSearch.Text == String.Empty ? labelSearch.Text : String.Empty)}\n" +
                $"{(textBox.Text == String.Empty ? labelText.Text : String.Empty)}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            textReplaced = true;

            int count = (textBox.Text.Length - textBox.Text.Replace(textBoxSearch.Text, "").Length)
                        / textBoxSearch.Text.Length;

            replacedText = textBox.Text.Replace(textBoxSearch.Text, textBoxReplace.Text);
            textBox.Text = replacedText;

            MessageBox.Show($"Осуществлено замен: {count}.",
                            "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            labelText.Text = "Изменённый текст";

            textBox.ReadOnly = true;
            textBoxSearch.Enabled = false;
            textBoxReplace.Enabled = false;
            textBoxPath.Enabled = false;

            buttonReplace.Visible = false;
            buttonBack.Visible = true;
            buttonOpenFile.Visible = false;
            buttonFileSave.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            rollback();
        }

        private void btnResetClick(object sender, EventArgs e)
        {
            originalText = textBoxSearch.Text = textBoxReplace.Text = textBox.Text = textBoxPath.Text = String.Empty;
            rollback();
        }

        private void rollback()
        {
            labelText.Text = "Исходный текст";
            textBox.Text = originalText;

            textBox.ReadOnly = false;
            textBoxSearch.Enabled = true;
            textBoxReplace.Enabled = true;
            textBoxPath.Enabled = true;

            buttonReplace.Visible = true;
            buttonBack.Visible = false;
            buttonOpenFile.Visible = true;
            buttonFileSave.Visible = false;

            textReplaced = false;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = String.Empty;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == "openFileDialog")
                return;
            textBoxPath.Text = openFileDialog.FileName;
            readFile();
        }

        private void readFile()
        {
            try
            {
                using (StreamReader f = new StreamReader(textBoxPath.Text, Encoding.GetEncoding(1251)))
                {
                    textBox.Text = f.ReadToEnd();
                    f.Close();
                }
            }
            catch (Exception)
            {
                if (textBoxPath.Text == String.Empty)
                    return;
                MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
        }

        private void btnFileSave_Click(object sender, EventArgs e)
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            formHelp f = new formHelp();
            f.ShowDialog();
        }

        private void tbText_OriginalTextChanged(object sender, EventArgs e)
        {
            if (!textReplaced)
            {
                originalText = textBox.Text;
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
    }
}
