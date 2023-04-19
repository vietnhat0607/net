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
        bool addnew=false;
        bool faddnew = false;
        public quanly()
        {
            InitializeComponent();
        }
        private void setenable(bool check )
        {
            txtid.Enabled =check;
            txtname.Enabled = check;
            txtdanhmuc.Enabled = check ;
            txtgia .Enabled = check;
            btnaddnew.Enabled = !check;
            btndelete.Enabled = !check;
            btnEdit.Enabled = !check ;    
            btnsave.Enabled = check;
            dgvdisplay.Enabled = !check;
            btnexit.Enabled = !check;

                txtids.Enabled = check;
                txtfullname.Enabled = check;
                txtusername.Enabled = check;
                txtpass.Enabled = check;
                txtemail.Enabled = check;
                btnadd.Enabled = !check;
                btnsua.Enabled = !check;
                btnexits.Enabled = !check;
                btnsaves.Enabled = check;
                btndeletes.Enabled = !check;
                dgvuser.Enabled = !check;

          
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
            load();
           
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
            addnew =true;
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
           string id = txtid.Text.Trim();
            string fn = txtname.Text;
           
            string dm = txtdanhmuc.Text;
            int gi= Convert.ToInt32(txtgia.Text);
            if(addnew) 
            {
                string sql = string.Format("INSERT INTO food VALUES ({0},N'{1}',{2},{3})", id,fn,dm,gi);

                DBServices db = new DBServices();
                db.runQuery(sql);
                laydulieu();
            }
            else
            {
               // string id = txtid.Text.Trim();
                /*string sql = string.Format("UPDATE food SET " +
                    "names=N'{0}'," +
                    " idcategory=N'{1}'," +
                    " gia=N'{2}'," +
                    " WHERE ID={3}", fn,dm,gi, id);*/
                string sql = string.Format("UPDATE food SET names=N'{0}', idcategory=N'{1}',gia=N'{2} WHERE id={3}", fn, dm,gi, id);

                DBServices db = new DBServices();
                db.runQuery(sql);
                laydulieu();
            }

           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                addnew =false;
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

       private void btndelete_Click(object sender, EventArgs e)
        {
            string id=txtid.Text;
            string sql = string.Format("DELETE FROM food where id={0}", id);
            DBServices db = new DBServices();
            db.runQuery(sql);
            laydulieu();
        }

        private void tptaikhoan_Click(object sender, EventArgs e)
        {

        }

        private void tpmon_Click(object sender, EventArgs e)
        {

        }
       private void load()
        {
            DBServices db = new DBServices();
            string sql = "select* from  account ";
            dgvuser.DataSource = db.getData(sql);
            setenable(false);
        }

        private void dgvdisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            faddnew = true;
            setenable(true);
            txtids.Clear();
            txtfullname.Clear();
            txtusername.Clear();
            txtpass.Clear();
            txtemail.Clear();

        }

        private void btnsaves_Click(object sender, EventArgs e)
        {

            if (txtfullname.Text.Trim() == "")
            {
                MessageBox.Show("name không được để trống ", "thông báo ");
                txtname.Focus();
                return;
            }
            if (txtids.Text.Trim() == "")
             {
                 MessageBox.Show("id không được để trống ", "thông báo ");
                 txtname.Focus();
                 return;
             }
            if (txtusername.Text.Trim() == "")
            {
                MessageBox.Show("username không được để trống ", "thông báo ");
                txtname.Focus();
                return;
            }
            if (txtpass.Text.Trim() == "")
            {
                MessageBox.Show("pass không được để trống ", "thông báo ");
                txtname.Focus();
                return;
            }
            if (txtemail.Text.Trim() == "")
            {
                MessageBox.Show("email không được để trống ", "thông báo ");
                txtname.Focus();
                return;
            }
            string ids = txtids.Text.Trim();
            string fname = txtfullname.Text;
            string un=txtusername.Text;
            string p=txtpass.Text;
            string em =txtemail.Text;

            if (faddnew)
            {
                string sql = string.Format("INSERT INTO account VALUES ({0},N'{1}', {2},{3},N'{4}')", ids, fname, un, p,em);

                DBServices db = new DBServices();
                db.runQuery(sql);
                load();
            }
            else
            {
                // string id = txtid.Text.Trim();
                /*string sql = string.Format("UPDATE food SET " +
                    "names=N'{0}'," +
                    " idcategory=N'{1}'," +
                    " gia=N'{2}'," +
                    " WHERE ID={3}", fn,dm,gi, id);*/
                string sql = string.Format("UPDATE account SET fullname=N'{0}', UserName=N'{1}',Passwords=N'{2}',Email=N'{3} WHERE id={4}", fname , un, p, em,ids);

                DBServices db = new DBServices();
                db.runQuery(sql);
                load();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            faddnew = false;
            setenable(true);
        }

        private void btndeletes_Click(object sender, EventArgs e)
        {
            string ids = txtids.Text;
            string sql = string.Format("DELETE account  where id={0}", ids);
            DBServices db = new DBServices();
            db.runQuery(sql);
            load();
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
