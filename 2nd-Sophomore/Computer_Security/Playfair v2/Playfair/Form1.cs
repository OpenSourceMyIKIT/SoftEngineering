using System;
using System.Windows.Forms;

namespace Playfair
{
    public partial class Form1 : Form
    {
        private PlayFairSettings ps = new PlayFairRu56();
        private PlayFair pf;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            pf = new PlayFair(ps, tbKey.Text);
            
            tbOutput.Text = pf.Crypt(tbInput.Text, true);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (pf == null) return;
            tbOutput.Text = pf.Crypt(tbInput.Text, false);
        }
    }
}
