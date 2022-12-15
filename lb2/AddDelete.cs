using System;
using System.Windows.Forms;

namespace lb2
{
    public partial class AddDelete : Form
    {
        public AddDelete()
        {
            InitializeComponent();
        }

        public string selectedItem;
        public uint number;
        private void btApply_Click(object sender, EventArgs e)
        {
            number = Convert.ToUInt16(numUpDown.Value);
            if (rbStuds.Checked)
                selectedItem = "rbStuds";
            if (rbTeachs.Checked)
                selectedItem = "rbTeachs";
            if (rbEngins.Checked)
                selectedItem = "rbEngins";
            if (rbLecs.Checked)
                selectedItem = "rbLecs";
            if (rbLabs.Checked)
                selectedItem = "rbLabs";

            this.DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
