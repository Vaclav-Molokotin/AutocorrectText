using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutocorrectText
{
    /// <summary>
    /// Форма выводит информацию о программе.
    /// </summary>
    public partial class FrmAbout : Form
    {
        /// <summary>
        /// Инициализирует все объекты на форме
        /// </summary>
        public FrmAbout()
        {
            InitializeComponent();
            lbText.Text = Properties.Resources.StringAbout;
        }
    }
}
