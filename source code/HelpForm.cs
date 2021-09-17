using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace date_changer
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            //Apply shadow to borderless form
            (new Core.DropShadow()).ApplyShadows(this);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void redditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/r/CrackSupport/comments/pjeksm/star_wars_jedi_fallen_order_new_date_fix/?utm_source=share&utm_medium=web2x&context=3");
        }

        private void gitRepoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/DogFoxX/date-changer");
        }
    }
}
