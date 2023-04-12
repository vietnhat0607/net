using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class quanly : Form
    {
        bool update=false;
        public quanly()
        {
            InitializeComponent();
        }
        private void setenable(bool check )
        {
            txtid.Enabled = check;
            txtname.Enabled = check;
            txtdanhmuc.Enabled = check ;
            txtgia .Enabled = check;
            btnUpdate.Enabled = !check;
           // btnDelete.Enabled = !check;
            btnEdit.Enabled = !check ;    
            btnsave.Enabled = check;
            dgvdisplay.Enabled = !check;
            btnexit.Enabled = !check;
        }
        private void laydulieu ()
        {
            DBServices db= new DBServices();
            string sql = "select* from food ";
            dgvdisplay.DataSource = db.getData(sql);
            setenable(false );
        }
        private void quanly_Load(object sender, EventArgs e)
        {
            laydulieu();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvdisplay_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update=false;
            setenable(true);
            txtid.Clear();
            txtname.Clear();
            txtdanhmuc.Clear();
           txtgia.Clear();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtname.Text.Trim()=="")
            {
                MessageBox.Show("name không được để trống ", "thông báo ");
                txtname.Focus();
                return;
            }
            if (txtid.Text.Trim() == "")
            {
                MessageBox.Show("id không được để trống ", "thông báo ");
                txtname.Focus();
                return;
            }
            if (txtdanhmuc.Text.Trim() == "")
            {
                MessageBox.Show("danh mục không được để trống ", "thông báo ");
                txtname.Focus();
                return;
            }
            if (txtgia.Text.Trim() == "")
            {
                MessageBox.Show("giá không được để trống ", "thông báo ");
                txtname.Focus();
                return;
            }
            string fn = txtname.Text;
           
            string dm = txtdanhmuc.Text;
            int gi= Convert.ToInt32(txtgia.Text);
            if(update) 
            {
                string sql = string.Format("INSERT INTO food VALUES (N'{0}',N'{1}',{3})", fn,dm,gi);

                DBServices db = new DBServices();
                db.runQuery(sql);
                laydulieu();
            }
            else
            {
                string id = txtid.Text;
                string sql = string.Format("UPDATE food SET " +
                    "names=N'{0}'," +
                    " idcategory=N'{1}'" +
                    " gia=N'{2}'" +
                    " WHERE ID={3}", fn,dm,gi, id);

                DBServices db = new DBServices();
                db.runQuery(sql);
                laydulieu();
            }

           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                update=false;
            setenable(true);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
