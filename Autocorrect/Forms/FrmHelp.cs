using System;
using System.Windows.Forms;


namespace AutocorrectText
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
            labelText.Text = Properties.Resources.StringHelp;
        }

        private void labelText_Click(object sender, EventArgs e)
        {

        }
    }
}
