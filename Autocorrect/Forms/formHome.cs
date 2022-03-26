using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Autocorrect
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        public string originalText = String.Empty;  //исходный текст
        public string replacedText = String.Empty;  //текст с произведённой автозаменой
        public string path = String.Empty;          //путь к файлу

        private static bool textReplaced = false;   //Произведена ли автозамена.

        //Обработка нажатия кнопки "Заменить"
        private void buttonChange_Click(object sender, EventArgs e)
        {
            //Если текстовые поля "Введите символы для поиска" и "Исходный текст" не заполнены,
            //То выводится сообщение об ошибке. 
            if (textBoxSearch.Text == String.Empty || textBox.Text == String.Empty)
            {
                MessageBox.Show($"Заполните поля:\n" +
                $"{(textBoxSearch.Text == String.Empty ? labelSearch.Text : String.Empty)}\n" +
                $"{(textBox.Text == String.Empty ? labelText.Text : String.Empty)}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Произведена автозамена
            textReplaced = true;

            //Подсчёт количества вхождений по формуле.
            int count = (textBox.Text.Length - textBox.Text.Replace(textBoxSearch.Text, "").Length)
                        / textBoxSearch.Text.Length;

            //Автозамена символов
            replacedText = textBox.Text.Replace(textBoxSearch.Text, textBoxReplace.Text);
            textBox.Text = replacedText;

            //Вывод сообщения о количестве автозамен.
            MessageBox.Show($"Осуществлено замен: {count}.",
                            "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Изменение заголовка поля "Исходный текст".
            labelText.Text = "Изменённый текст";

            //Изменение свойств текстовых полей:
            //"Изменённый текст", "Введите символы для автозамены",
            //"Введите символы для замены", "Путь к файлу".
            textBox.ReadOnly = true;
            textBoxSearch.Enabled = false;
            textBoxReplace.Enabled = false;
            textBoxPath.Enabled = false;

            //Изменение свойств кнопок:
            //"Заменить", "Назад", "Выбрать файл", "Сохранить в файл".
            buttonReplace.Visible = false;
            buttonBack.Visible = true;
            buttonOpenFile.Visible = false;
            buttonFileSave.Visible = true;
        }

        //Обработка нажатия кнопки "Назад".
        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Вызов функции для приведения формы к начальному виду.
            rollback();
        }

        //Обработка нажатия кнопки "Сброс".
        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Очищение содержимого всех полей и занчения исходного текста.
            originalText = textBoxSearch.Text = textBoxReplace.Text = textBox.Text = String.Empty;
            //Вызов функции для приведения формы к начальному виду.
            rollback();
        }

        //Функция, возвращающая форму к первоначальному виду.
        private void rollback()
        {
            //Изменение имени текстового поля "Изменённый текст".
            labelText.Text = "Исходный текст";
            //Отображение исходного текста в поле "Исходный текст".
            textBox.Text = originalText;

            //Изменение свойств текстовых полей:
            //"Изменённый текст", "Введите символы для автозамены", "Введите символы для замены", "Путь к файлу".
            textBox.ReadOnly = false;
            textBoxSearch.Enabled = true;
            textBoxReplace.Enabled = true;
            textBoxPath.Enabled = true;

            //Изменение свойств кнопок:
            //"Заменить", "Назад", "Выбрать файл", "Сохранить в файл".
            buttonReplace.Visible = true;
            buttonBack.Visible = false;
            buttonOpenFile.Visible = true;
            buttonFileSave.Visible = false;

            //Автозамена не произведена.
            textReplaced = false;
        }

        //Обработка нажатия кнопки "Выбрать файл".
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = String.Empty;
            //Отображение диалогового окна на экране.
            openFileDialog.ShowDialog();
            //Если пользователь не выбрал файл - выход из функции.
            if (openFileDialog.FileName == "openFileDialog")
                return;
            //Отображение полного пути выбранного файла в текстовом поле "Путь к файлу".
            textBoxPath.Text = openFileDialog.FileName;
            //Вызов функции для чтения данных из файла.
            readFile();
        }

        //Функция, считывающая данные из файла.
        private void readFile()
        {
            //Создание потока для чтения данных из файла
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
                //Если текстовое поле "Путь к файлу" не было пустым на момент чтения,
                //То выводится сообщение об ошибке.
                if (textBoxPath.Text == String.Empty)
                    return;
                MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Обновление значения полного пути к файлу.
        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
        }

        //Обработка нажатия кнопки "Сохранить в файл".
        private void buttonFileSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = String.Empty;
            saveFileDialog.ShowDialog();
            //Если пользователь не выбрал файл - выход из функции.
            if (openFileDialog.FileName == "openFileDialog")
                return;
            using (StreamWriter f = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.GetEncoding(1251)))
            {
                f.Write(replacedText);
                f.Close();
            }
        }

        //Обработка нажатия кнопки "Помощь" для вызова справки.
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            formHelp f = new formHelp();
            f.ShowDialog();
        }

        //Обновление значения исходного текста.
        private void textBox_OriginalTextChanged(object sender, EventArgs e)
        {
            //Если автозамены не было
            if (!textReplaced)
            {
                //исходный текст обновляется
                originalText = textBox.Text;
            }
            
        }

        //Обработка нажатия клавиши Enter в текстовом поле "Путь к файлу".
        private void textBoxPath_EnterKeyPressed(object sender, KeyPressEventArgs e)
        {
            //Если нажатая клавиша - Enter,
            //То считывается файл.
            if (e.KeyChar == 13)
                readFile();
        }

        private void textBoxReplace_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
