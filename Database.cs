using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Database
{
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataAdapter da;
    private DataTable dt;

    public Database(string servername, string database)
    {
        try
        {
            conn = new SqlConnection("Data Source = " + servername + "; Initial Catalog =" + database + ";Integrated Security=true");
            conn.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally { conn.Close(); }
    }

    /// <summary>
    /// Lấy danh sách các thành phần của table
    /// </summary>
    /// <param name="tableID">
    ///     0:Khách hàng </br>
    ///     1:Khu vực </br>
    ///     2:Nhân viên </br>
    ///     3:Hóa đơn </br>
    ///     4:Sản phẩm </br>
    ///     5:Nhà cung cấp </br>
    ///     6:Tài khoản </br>
    ///     7:Chi tiết hóa đơn </br>
    ///     8:Chi tiết cung cấp </br>
    /// </param>
    /// <returns>danh sách dưới dạng DataTable</returns>
    public DataTable LayDanhSach(int tableID)
    {
        try
        {
            conn.Open();
            string msg = "";
            switch (tableID)
            {
                case 0:
                    msg = "sp_khachhang_layDanhSach";
                    break;
                case 1:
                    msg = "sp_khuvuc_layDanhSach";
                    break;
                case 2:
                    msg = "sp_nhanvien_layDanhSach";
                    break;
                case 3:
                    msg = "sp_hoadon_layDanhSach";
                    break;
                case 4:
                    msg = "sp_sanpham_layDanhSach";
                    break;
                case 5:
                    msg = "sp_nhacungcap_layDanhSach";
                    break;
                case 6:
                    msg = "sp_taikhoan_layDanhSach";
                    break;
                case 7:
                    msg = "sp_chitiethd_layDanhSach";
                    break;
                case 8:
                    msg = "sp_chitietcc_layDanhSach";
                    break;
                case 9:
                    msg = "sp_chinhanh_layDanhSach";
                    break;
                case 10:
                    msg = "sp_khuyenmai_layDanhSach";
                    break;
            }
            cmd = new SqlCommand();
            cmd.CommandText = msg;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn.Close();
        }
        return dt;
    }
    /// <summary>
    /// Thêm mục vào danh sách
    /// </summary>
    /// <param name="tableID">
    ///     0:Khách hàng </br>
    ///     1:Khu vực </br>
    ///     2:Nhân viên </br>
    ///     3:Hóa đơn </br>
    ///     4:Sản phẩm </br>
    ///     5:Nhà cung cấp </br>
    ///     6:Tài khoản </br>
    ///     7:Chi tiết hóa đơn </br>
    ///     8:Chi tiết cung cấp </br>
    /// </param>
    /// <param name="parameters"> Các biến cần thiết cho mục đã chọn</param>
    /// <returns>
    ///     true:Thêm thành công </br>
    ///     false:Thêm thất bại
    /// </returns>
    public bool Them(int tableID, SqlParameter[] parameters)
    {
        bool flag = false;
        try
        {
            string msg = "";
            switch (tableID)
            {
                case 0:
                    msg = "sp_khachhang_them";
                    break;
                case 1:
                    msg = "sp_khuvuc_them";
                    break;
                case 2:
                    msg = "sp_nhanvien_them";
                    break;
                case 3:
                    msg = "sp_hoadon_them";
                    break;
                case 4:
                    msg = "sp_sanpham_them";
                    break;
                case 5:
                    msg = "sp_nhacungcap_them";
                    break;
                case 6:
                    msg = "sp_taikhoan_them";
                    break;
                case 7:
                    msg = "sp_chitiethd_them";
                    break;
                case 8:
                    msg = "sp_chitietcc_them";
                    break;
            }
            cmd = new SqlCommand();
            cmd.CommandText = msg;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            flag = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn.Close();
        }
        return flag;
    }
    /// <summary>
    /// Xóa mục khỏi danh sách
    /// </summary>
    /// <param name="tableID">
    ///     0:Khách hàng </br>
    ///     1:Khu vực </br>
    ///     2:Nhân viên </br>
    ///     3:Hóa đơn </br>
    ///     4:Sản phẩm </br>
    ///     5:Nhà cung cấp </br>
    ///     6:Tài khoản </br>
    ///     7:Chi tiết hóa đơn </br>
    ///     8:Chi tiết cung cấp </br>
    /// </param>
    /// <param name="ma">Mã của bảng tương ứng</param>
    /// <returns>
    ///     true: Xóa thành công
    ///     false: Xóa thất bại
    /// </returns>
    public bool Xoa(int tableID, SqlParameter[] parameters)
    {
        bool flag = false;
        try
        {
            conn.Open();
            string msg = "";
            switch (tableID)
            {
                case 0:
                    msg = "sp_khachhang_xoa";
                    break;
                case 1:
                    msg = "sp_khuvuc_xoa";
                    break;
                case 2:
                    msg = "sp_nhanvien_xoa";
                    break;
                case 3:
                    msg = "sp_hoadon_xoa";
                    break;
                case 4:
                    msg = "sp_sanpham_xoa";
                    break;
                case 5:
                    msg = "sp_nhacungcap_xoa";
                    break;
                case 6:
                    msg = "sp_taikhoan_xoa";
                    break;
            }
            cmd = new SqlCommand();
            cmd.CommandText = msg;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            flag = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn.Close();
        }
        return flag;
    }
    public bool Xoa_ChitietHD(int style, SqlParameter[] parameters)
    {
        bool flag = false;
        string msg = "";
        switch (style)
        {
            case 0:
                msg = "sp_chitiethd_xoa_hoadon";
                break;
            case 1:
                msg = "sp_chitiethd_xoa_sanpham";
                break;
        }
        try
        {
            conn.Open();

            cmd = new SqlCommand();
            cmd.CommandText = msg;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            flag = true;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally { conn.Close(); }
        return flag;

    }
    public bool Xoa_ChitietCC(int style, SqlParameter[] parameters)
    {
        bool flag = false;
        string msg = "";
        switch (style)
        {
            case 0:
                msg = "sp_chitietcc_xoa_nhacungcap";
                break;
            case 1:
                msg = "sp_chitietcc_xoa_sanpham";
                break;
        }
        try
        {
            conn.Open();

            cmd = new SqlCommand();
            cmd.CommandText = msg;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            flag = true;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally { conn.Close(); }
        return flag;

    }
    /// <summary>
    /// Sủa thông tin của 1 mục có sẵn trên bảng cơ sở dữ liệu
    /// </summary>
    /// <param name="tableID">
    ///      0:Khách hàng </br>
    ///     1:Khu vực </br>
    ///     2:Nhân viên </br>
    ///     3:Hóa đơn </br>
    ///     4:Sản phẩm </br>
    ///     5:Nhà cung cấp </br>
    ///     6:Tài khoản </br>
    /// </param>
    /// <param name="parameters">Truyền các biến tương ứng với bảng cần sửa</param>
    /// <returns>
    ///     true: Sửa thành công
    ///     false: Sửa thất bại
    /// </returns>
    public bool Sua(int tableID, SqlParameter[] parameters)
    {
        bool flag = false;
        try
        {
            conn.Open();
            string msg = "";
            switch (tableID)
            {
                case 0:
                    msg = "sp_khachhang_sua";
                    break;
                case 1:
                    msg = "sp_khuvuc_sua";
                    break;
                case 2:
                    msg = "sp_nhanvien_sua";
                    break;
                case 3:
                    msg = "sp_hoadon_sua";
                    break;
                case 4:
                    msg = "sp_sanpham_sua";
                    break;
                case 5:
                    msg = "sp_nhacungcap_sua";
                    break;
                case 6:
                    msg = "sp_taikhoan_sua";
                    break;
            }
            cmd = new SqlCommand();
            cmd.CommandText = msg;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            flag = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn.Close();
        }
        return flag;
    }
    /// <summary>
    /// Tìm kiếm mục theo từ khóa
    /// </summary>
    /// <param name="tableID">
    ///      0:Khách hàng </br>
    ///     1:Khu vực </br>
    ///     2:Nhân viên </br>
    ///     3:Hóa đơn </br>
    ///     4:Sản phẩm </br>
    ///     5:Nhà cung cấp </br>
    ///     6:Tài khoản </br>
    ///     7:Chi tiết hóa đơn </br>
    ///     8:Chi tiết cung cấp </br>
    /// </param>
    /// <param name="tukhoa">Chuỗi bất kỳ</param>
    /// <returns>Trả về Datatable nếu thành công. Trả về null nếu không tìm thấy mục nào</returns>
    public DataTable TimKiem(int tableID, string tukhoa)
    {
        dt = null;
        try
        {
            string msg = "";
            switch (tableID)
            {
                case 0:
                    msg = "sp_khachhang_timkiem";
                    break;
                case 1:
                    msg = "sp_khuvuc_timkiem";
                    break;
                case 2:
                    msg = "sp_sanpham_timkiem_maSP";
                    break;
            }
            cmd = new SqlCommand();
            cmd.CommandText = msg;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter parameter = new SqlParameter("@key", tukhoa);
            cmd.Parameters.Add(parameter);

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            conn.Close();
        }
        return dt;
    }
    public DataTable TimCNTheoMaKV(string maKV)
    {
        dt = null;

        try
        {
            conn.Open();

            cmd = new SqlCommand();
            cmd.CommandText = "sp_chinhanh_timTheoKV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter parameter = new SqlParameter("@maKV", maKV);
            cmd.Parameters.Add(parameter);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally { conn.Close(); }

        return dt;
    }
    public DataTable TimKiem_NhanVien_Ma(string maKV)
    {
        dt = null;

        try
        {
            conn.Open();

            cmd = new SqlCommand();
            cmd.CommandText = "sp_chinhanh_timTheoKV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter parameter = new SqlParameter("@maKV", maKV);
            cmd.Parameters.Add(parameter);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally { conn.Close(); }

        return dt;
    }
}

