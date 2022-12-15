using System;
using System.Windows.Forms;

namespace lb2
{
    public partial class CompareMerge : Form
    {
        public CompareMerge()
        {
            InitializeComponent();
        }
        public int index1 = -1, index2 = -1;
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;            
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            index1 = lbFirst.SelectedIndex;
            index2 = lbSecond.SelectedIndex;
            this.DialogResult = DialogResult.OK;
        }
    }
}
