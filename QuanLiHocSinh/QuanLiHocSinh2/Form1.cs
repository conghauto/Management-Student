using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLiHocSinh2
{
    public partial class fmQuanLiHocSinh : Form
    {
        public fmQuanLiHocSinh()
        {
            InitializeComponent();
        }

        int iMaHS;
        DataView dv;
        DataSet ds;
        SqlDataAdapter daHocSinh;
        SqlDataAdapter daLopHoc;
        SqlDataAdapter daHocSinh_LopHoc;
        private void Form1_Load(object sender, EventArgs e)
        {
            // tạo chuỗi kết nối
            string connection = @"Data Source=DESKTOP-JFCSOM4;Initial Catalog=QUANLIHOCSINH;Integrated Security=True";
            // tạo chuỗi truy vấn
            string query = @"Select*From HocSinh";
            // khoi tao DataSet
            ds = new DataSet("dsQuanLiHocSinh");
            daHocSinh = new SqlDataAdapter(query, connection);

            // do du lieu vao 1 bang trong DataSet
            daHocSinh.Fill(ds,"tblHocSinh");
            dv = new DataView(ds.Tables["tblHocSinh"]);
            dgvDanhSachHocSinh.DataSource = dv;

            // Dat ten lai cho cac cot trong DataGirdView
            dgvDanhSachHocSinh.Columns["MAHS"].HeaderText = "Mã HS";
            dgvDanhSachHocSinh.Columns["HOTEN"].HeaderText = "Họ tên";
            dgvDanhSachHocSinh.Columns["GIOITINH"].HeaderText = "Giới tính";
            dgvDanhSachHocSinh.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            dgvDanhSachHocSinh.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvDanhSachHocSinh.Columns["MALOP"].HeaderText = "Mã lớp";

            // Dat lai do rong cho cac cot trong DataGirdView
            dgvDanhSachHocSinh.Columns["MAHS"].Width = 70;
            dgvDanhSachHocSinh.Columns["HOTEN"].Width =120;
            dgvDanhSachHocSinh.Columns["GIOITINH"].Width = 80;
            dgvDanhSachHocSinh.Columns["NGAYSINH"].Width = 80;
            dgvDanhSachHocSinh.Columns["DIACHI"].Width = 150;

            // Dua danh sach lop vao Combobox
            // chuoi truy van
            string queryLopHoc = @"Select*From LOP";
            // Khoi tao du lieu SQLDataAdapter de lay du lieu tu DataBase ve
            daLopHoc = new SqlDataAdapter(queryLopHoc, connection);

            // do du lieu vao DataSet
            daLopHoc.Fill(ds, "tblLop");
            cmbLop.DataSource = ds.Tables["tblLop"];
            cmbLop.DisplayMember = "TENLOP";
           cmbLop.ValueMember = "MALOP";

            //        //1. tao chuoi truy van lay thong tin cua 2 cot
            //        string sSelectHocSinh_LopHoc = @"Select HocSinh.*,Lop.TENLOP From HocSinh,Lop Where 
            //HocSinh.MALOP=LOP.MALOP";

            //        // khoi tao doi tuong SQLDatAdapter de lay du lieu tu DataBase
            //        daHocSinh_LopHoc = new SqlDataAdapter(sSelectHocSinh_LopHoc, connection);
            //        daHocSinh_LopHoc.Fill(ds, "tblHocSinh_LopHoc");

            //        dgvDanhSachHocSinh.DataSource = ds.Tables["tblHocSinh_LopHoc"];
            //        dgvDanhSachHocSinh.Columns["TENLOP"].HeaderText = "Tên lớp";

            //        // Ẩn cột Mã lớp
            //        dgvDanhSachHocSinh.Columns["MALOP"].Visible = false;

            // 2. Tạo một cột trên DataGirdView
            DataGridViewColumn clLopHoc = new DataGridViewColumn();
            DataGridViewCell cell =new DataGridViewTextBoxCell();

            clLopHoc.CellTemplate = cell;
            clLopHoc.Name = "TenLop";
            clLopHoc.HeaderText = "Lớp học";
            dgvDanhSachHocSinh.Columns.Add(clLopHoc);

            for(int i=0;i<dgvDanhSachHocSinh.RowCount;i++)
            {
                dgvDanhSachHocSinh.Rows[i].Cells["TenLop"].Value = LayTenLopHoc(dgvDanhSachHocSinh.Rows[i].Cells["MaLop"].Value.ToString());
            }

            dgvDanhSachHocSinh.Columns["MALOP"].Visible = false;


            // Chưa có gì kết nối giữa ứng dụng với cơ sở dữ liệu của mình
            // 1. Tạo chức năng thêm cho ứng dụng

            // tạo đối tượng kết nối 
            SqlConnection con = new SqlConnection(connection);// truyền vào chuỗi kết nối
            // Tạo đối tượng commnad thực thi truy vấn

            // 1a. Tạo chuỗi truy vấn (trước khi tạo đối tượng commnad phải có chuỗi truy vấn)
            string sThemHS = @"Insert Into HocSinh(HoTen,GioiTinh,NgaySinh,DiaChi,MaLop) Values(@HoTen,@GioiTinh,@NgaySinh,@DiaChi,@MaLop)";
            SqlCommand cmThemHS = new SqlCommand(sThemHS,con);

            cmThemHS.Parameters.Add("@HoTen",SqlDbType.NVarChar,50,"HoTen");
            cmThemHS.Parameters.Add("@GioiTinh", SqlDbType.Char, 5, "GioiTinh");
            cmThemHS.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 10, "NgaySinh");
            cmThemHS.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50, "DiaChi");
            cmThemHS.Parameters.Add("@MaLop", SqlDbType.Int, 10, "MaLop");

            daHocSinh.InsertCommand = cmThemHS;


            // 1b. Tạo đối tượng Command thực thi câu lệnh truy vấn Update
            string sSuaHS = @"Update HocSinh Set HoTen=@HoTen,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,MaLop=@MaLop Where MaHS=@MaHS";
            SqlCommand cmSuaHS = new SqlCommand(sSuaHS,con);

            cmSuaHS.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50, "HoTen");
            cmSuaHS.Parameters.Add("@GioiTinh", SqlDbType.Char, 5, "GioiTinh");
            cmSuaHS.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 10, "NgaySinh");
            cmSuaHS.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50, "DiaChi");
            cmSuaHS.Parameters.Add("@MaLop", SqlDbType.Int,10, "MaLop");

            cmSuaHS.Parameters.Add("@MaHS", SqlDbType.Int, 5, "MaHS");

            daHocSinh.UpdateCommand = cmSuaHS;

            // 1c. Tạo command xóa dữ liệu
            string sXoaHS = @"Delete From HocSinh Where MAHS=@MAHS";
            SqlCommand cmXoaHS = new SqlCommand(sXoaHS, con);

            cmXoaHS.Parameters.Add("@MAHS", SqlDbType.Int, 5, "MAHS");
            daHocSinh.DeleteCommand = cmXoaHS;
        }

        public void LayMaHSCuoiCungTruocKhiThem()
        {
            // tạo chuỗi kết nối

            string connection = @"Data Source=DESKTOP-JFCSOM4;Initial Catalog=QUANLIHOCSINH;Integrated Security=True";
            // tạo chuỗi truy vấn
            string sMaHSCuoiCung = @"Select MaHS From HocSinh";
            SqlDataAdapter daTenLop = new SqlDataAdapter(sMaHSCuoiCung, connection);

            DataTable dt = new DataTable();
            daTenLop.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                // lấy chỉ số phần tử dòng cuối cùng
                int iDongCuoi = dt.Rows.Count - 1;
                iMaHS = int.Parse(dt.Rows[iDongCuoi][0].ToString());
            }
            
        }
        public string LayTenLopHoc(String MaLop)
        {
            // tạo chuỗi kết nối

            string connection = @"Data Source=DESKTOP-JFCSOM4;Initial Catalog=QUANLIHOCSINH;Integrated Security=True";
            // tạo chuỗi truy vấn
            string query = @"Select TenLop From LOP Where MaLop="+MaLop;
            SqlDataAdapter daTenLop = new SqlDataAdapter(query, connection);

            DataTable dt = new DataTable();
            daTenLop.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
                return "";

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của đầu vào dữ liệu
            if (txbHoTen.Text == "" || txbDiaChi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            // Thêm vào dòng vào tblHocSinh
            DataRow r = ds.Tables["tblHocSinh"].NewRow();

            // Nhập giá trị các trường tương ứng trên DataRow
            r["HoTen"] = txbHoTen.Text;

            if (rbNam.Checked == true)
            {
                r["GioiTinh"] = "NAM";
            }
            else
            {
                r["GioiTinh"] = "NU";
            }

            r["NgaySinh"] = dtpNgaySinh.Text;
            r["DiaChi"] = txbDiaChi.Text;
            r["MaLop"] = cmbLop.SelectedValue;

            if (iMaHS == 0)
            {
                LayMaHSCuoiCungTruocKhiThem();
            }
            iMaHS++;
            r["MaHS"] = iMaHS;

            // Add vào tblHocSinh=> DataSet thay đổi => DataGirdView thay đổi(chưa cập nhật dữ liệu ở Database)
            ds.Tables["tblHocSinh"].Rows.Add(r);
            // Thêm tên lớp vào DataGirdView 
            dgvDanhSachHocSinh.Rows[dgvDanhSachHocSinh.RowCount - 1].Cells["TenLop"].Value = LayTenLopHoc(cmbLop.SelectedValue.ToString());
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daHocSinh.Update(ds,"tblHocSinh");
                MessageBox.Show("Lưu thành công !", "Thông báo");
            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Bạn có muốn thoát hay không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                this.Close();
            }

           
            //Application.Exit();
        }

        private void fmQuanLiHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(MessageBox.Show("Bạn thật sự muốn thoát phải không?","Thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvDanhSachHocSinh.SelectedRows[0];
                dgvDanhSachHocSinh.Rows.Remove(dr);
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }


        }

        private void dgvDanhSachHocSinh_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDanhSachHocSinh.SelectedRows[0];
           
            txbMaHS.Text = dr.Cells["MAHS"].Value.ToString();
            txbHoTen.Text = dr.Cells["HoTen"].Value.ToString();

            if(dr.Cells["GioiTinh"].Value.ToString()=="Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked =true;
            }

           
            txbDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            cmbLop.SelectedValue = dr.Cells["MaLop"].Value.ToString();

            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDanhSachHocSinh.SelectedRows[0];
            dgvDanhSachHocSinh.BeginEdit(true);
            dr.Cells["MaHS"].Value = txbMaHS;
            dr.Cells["HoTen"].Value = txbHoTen.Text;
            if (rbNam.Checked == true)
            {
                dr.Cells["GioiTinh"].Value = "Nam";
            }
            else
            {
                dr.Cells["GioiTinh"].Value = "Nữ";
            }
            dr.Cells["NgaySinh"].Value = dtpNgaySinh.Text;
            dr.Cells["DiaChi"].Value = txbDiaChi.Text;
            dr.Cells["MaLop"].Value = cmbLop.SelectedValue;

            dgvDanhSachHocSinh.EndEdit();
            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblHocSinh"].RejectChanges();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //dv.RowFilter = "HoTen like '%" + txtTimKiem.Text + "%'";
            dv.RowFilter = String.Format("HoTen like '%{0}%'", txtTimKiem.Text);
        }
    }
}
