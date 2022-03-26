using System;
using System.Windows.Forms;


namespace Autocorrect
{
    public partial class formHelp : Form
    {
        public formHelp()
        {
            InitializeComponent();
            labelText.Text = Properties.Resources.StringHelp;
        }

        private void labelText_Click(object sender, EventArgs e)
        {

        }
    }
}
