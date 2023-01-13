using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tourism_office_app.Resources;

namespace tourism_office_app
{
    public partial class Form1 : Form
    {
        private Form CurrentActiveForm = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure You Want To Exit?";
            string title = "Exit Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
                Application.Exit();

        }

        private void TrvNav_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Form frm = null;
            TreeNode node = e.Node;
            if (node.Name == "NodeProfile")
                frm = new frmUserProfile();
            else if (node.Name == "NodeOffers")
                frm = new frmOffers();
            else if (node.Name == "NodeNewTrip")
                frm = new frmNewTrip();
            else if (node.Name == "NodeBestHottels")
                frm = new frmBestHottels();

            if (frm != null)
            {
                if (CurrentActiveForm != null && CurrentActiveForm != frm)
                {
                    CurrentActiveForm.Close();
                    pnlContent.Controls.Remove(CurrentActiveForm);
                }
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.BackColor = Color.White;
                CurrentActiveForm = frm;

                pnlContent.Controls.Add(frm);
                frm.Show();
            }
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
