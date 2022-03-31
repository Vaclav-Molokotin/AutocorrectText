using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AutocorrectText
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class FrmHome : Form
    {
        private string originalText = String.Empty;  //исходный текст
        private string replacedText = String.Empty;  //текст с произведённой автозаменой
        private string path = String.Empty;          //путь к файлу
        private static bool textReplaced = false;   //Произведена ли автозамена.

        /// <summary>
        /// Инициализирует все объекты на формеи задаёт начальные установки. 
        /// </summary>
        public FrmHome()
        {
            InitializeComponent();
            openFileDialog.Filter = "Текстовый документ (*.txt)|*.txt";
            btnReset.Enabled = false;
        }
        private void btnOpenOrSaveFile_Click(object sender, EventArgs e)
        {
            if (textReplaced)
                saveToFile();
            else
                openFile();
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (textReplaced)
                rollback();
            else
                replace();
        }
        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            FrmHelp help = new FrmHelp();
            help.ShowDialog();
        }
        private void tbText_OriginalTextChanged(object sender, EventArgs e)
        {
            if (!textReplaced)
            {
                originalText = tbText.Text;
                btnReset.Enabled = true;
            }
        }
        private void tbPath_EnterKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!(tbPath.Text == String.Empty))
                {
                    readFile();
                    btnReset.Enabled = true;
                }
            }
        }
        private void pbLogo_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
        }
        private void tbReplace_TextChanged(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            originalText = tbSearch.Text = tbReplace.Text = tbText.Text = tbPath.Text = String.Empty;
            rollback();
            btnReset.Enabled = false;
        }

        #region replaceText
        /// <summary>
        /// Процедура замены символов.
        /// </summary>
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

        /// <summary>
        /// Процедура возврата исходного текста. 
        /// </summary>
        private void rollback()
        {
            labText.Text = "Исходный текст";
            btnReplace.Text = "Заменить";
            btnOpenOrSaveFile.Text = "Выбрать файл";
            tbText.Text = originalText;

            tbText.ReadOnly = false;
            tbSearch.Enabled = true;
            tbReplace.Enabled = true;
            tbPath.Enabled = true;

            btnReplace.Visible = true;
            btnOpenOrSaveFile.Visible = true;

            textReplaced = false;
        }
        #endregion

        #region fileProcessing
        /// <summary>
        /// Процедура для считывания файла и записи содержимого в текстовое поле.
        /// </summary>
        private void readFile()
        {
            try
            {
                if (Path.GetExtension(tbPath.Text) != ".txt")
                    MessageBox.Show("Файл должен иметь расширение \".txt\"!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>
        /// Процедура открытия файла.
        /// </summary>
        private void openFile()
        {
            openFileDialog.FileName = String.Empty;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == String.Empty)
                return;
            tbPath.Text = openFileDialog.FileName;
            readFile();
        }
        /// <summary>
        /// Процедура сохранения файла.
        /// </summary>
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
        #endregion
    }
}
