using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            laydulieu();
        }
        private void laydulieu()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-21HGRUOS\HP001;Initial Catalog=manager;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtdangnhap.Text;
                string mk = txtpass.Text;
                string sql = "select UserName,Passwords from account where UserName='" + tk + "' and Passwords='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    tablefood tf=new tablefood();
                     this.Hide();
                     tf.ShowDialog();
                     this.Show();
                    

                }
                else
                {
                    MessageBox.Show("sai rùi làm lại đê ","thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối ");
                    }
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
         
        }
    }
}
