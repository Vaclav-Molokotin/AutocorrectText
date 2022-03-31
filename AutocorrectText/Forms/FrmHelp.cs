using System;
using System.Windows.Forms;


namespace AutocorrectText
{
    /// <summary>
    /// Форма выводит справку по программе. 
    /// </summary>
    public partial class FrmHelp : Form
    {
        /// <summary>
        /// Инициализирует все объекты на форме.
        /// </summary>
        public FrmHelp()
        {
            InitializeComponent();
            labelText.Text = Properties.Resources.StringHelp;
        }
    }
}
