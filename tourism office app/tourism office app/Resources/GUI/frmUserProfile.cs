using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tourism_office_app.Resources.GUI;

namespace tourism_office_app.Resources
{
    public partial class frmUserProfile : Form
    {
        private Form CurrentForm = null;
        public frmUserProfile()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Form frm = null;

            TreeNode node = e.Node;

            if (node.Name == "NodeChangePersonalData")
                frm = new frmChangePersonalData();
            else if (node.Name == "NodeChangePaymentMethod")
                frm = new frmChangePaymentMethod();
            else if (node.Name == "NodeLastTrips")
                frm = new frmLastTrips();


            if(frm != null)
            {
                if(CurrentForm != null && CurrentForm != frm)
                {
                    CurrentForm.Close();
                    panel3.Controls.Remove(CurrentForm);
             
                }

                frm.FormBorderStyle = FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.BackColor = Color.White;
                panel3.Controls.Add(frm);
                frm.Show();
                CurrentForm = frm;





            }

        }
    }
}
