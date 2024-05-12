using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Danhmuchanghoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tblhanghoa;
        private void load_datagrid()
        {
            string sql;
            sql = "select * from tblHanghoa";
            tblhanghoa = Function.GetDatatoTable(sql);
            dgvdanhmuchanghoa.DataSource = tblhanghoa;
            dgvdanhmuchanghoa.Columns[0].HeaderText = "Mã hàng";
            dgvdanhmuchanghoa.Columns[1].HeaderText = "Tên hàng";
            dgvdanhmuchanghoa.Columns[2].HeaderText = "Mã màu";
            dgvdanhmuchanghoa.Columns[3].HeaderText = "Số lượng";
            dgvdanhmuchanghoa.Columns[4].HeaderText = "Thời gian bảo hành";
            dgvdanhmuchanghoa.Columns[0].Width = 100;
            dgvdanhmuchanghoa.Columns[1].Width = 150;
            dgvdanhmuchanghoa.Columns[2].Width = 100;
            dgvdanhmuchanghoa.Columns[3].Width = 100;
            dgvdanhmuchanghoa.Columns[4].Width = 100;
            dgvdanhmuchanghoa.AllowUserToAddRows = false;
            dgvdanhmuchanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyhanghoaDataSet.tblMausac' table. You can move, or remove it, as needed.
            this.tblMausacTableAdapter.Fill(this.quanlyhanghoaDataSet.tblMausac);
            Function.ketnoi();
            load_datagrid();
        }
        private void ResetValues()
        {
            tbmahang.Text = "";
            tbtenhang.Text = "";
            cbmamau.Text = "";
            tbsoluong.Text = "";
            tbthoigian.Text = "";
            tbmahang.Focus();
            tbmahang.Enabled = true;
        }
        private void dgvdanhmuchanghoa_Click(object sender, EventArgs e)
        {
            if (btthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbmahang.Focus();
                return;
            }
            if (tblhanghoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tbmahang.Text = dgvdanhmuchanghoa.CurrentRow.Cells["Mahang"].Value.ToString();
            tbtenhang.Text = dgvdanhmuchanghoa.CurrentRow.Cells["Tenhang"].Value.ToString();
            cbmamau.Text = dgvdanhmuchanghoa.CurrentRow.Cells["Mamau"].Value.ToString();
            tbsoluong.Text = dgvdanhmuchanghoa.CurrentRow.Cells["Soluong"].Value.ToString();
            tbthoigian.Text = dgvdanhmuchanghoa.CurrentRow.Cells["Thoigianbaohanh"].Value.ToString();
            tbmahang.Enabled = false;
        }
        private void btdong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btboqua_Click(object sender, EventArgs e)
        {

            ResetValues();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblhanghoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbmahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblHanghoa WHERE Mahang=N'" + tbmahang.Text.Trim() + "'";
                Function.RunSqlDel(sql);
                load_datagrid();
                ResetValues();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblhanghoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbmahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbtenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbtenhang.Focus();
                return;
            }
            if (cbmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbmamau.Focus();
                return;
            }
            if (tbsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbsoluong.Focus();
                return;
            }
            if (tbthoigian.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbtenhang.Focus();
                return;
            }
            sql = $"UPDATE tblHanghoa SET Tenhang = N'{tbtenhang.Text.Trim()}', Mamau = N'{cbmamau.Text.Trim()}', Soluong = {float.Parse(tbsoluong.Text.Trim())}, Thoigianbaohanh = {float.Parse(tbthoigian.Text.Trim())} WHERE Mahang=N'{tbmahang.Text}'";
            Function.RunSql(sql);
            load_datagrid();
            ResetValues();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbmahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmahang.Focus();
                return;
            }
            if (tbtenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbtenhang.Focus();
                return;
            }
            if (cbmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbmamau.Focus();
                return;
            }
            if (tbsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbsoluong.Focus();
                return;
            }
            if (tbthoigian.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbthoigian.Focus();
                return;
            }

                sql = "SELECT Mahang FROM tblHanghoa WHERE Mahang=N'" + tbmahang.Text.Trim() + "'";
                if (Function.CheckKey(sql))
                {
                    MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbmahang.Focus();
                    if(tbmahang.Enabled==true)
                    {
                        tbmahang.Text = "";
                    }
                    return;
                }
                sql = $"insert into tblHanghoa (Mahang, Tenhang, Mamau, Soluong, Thoigianbaohanh) values (N'{tbmahang.Text}',N'{tbtenhang.Text}',N'{cbmamau.Text}',{float.Parse(tbsoluong.Text)},{float.Parse(tbthoigian.Text)})";
                Function.RunSql(sql);
                load_datagrid();
                ResetValues();
            }
        }
 }
