using System;
using System.Windows.Forms;

namespace date_changer
{
    public partial class OverWriteForm : Form
    {
        public OverWriteForm()
        {
            InitializeComponent();

            //Apply shadow to borderless form
            (new Core.DropShadow()).ApplyShadows(this);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
