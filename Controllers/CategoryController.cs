using CuaHangMayTinh.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Controllers
{
    public class CategoryController
    {
        private static CategoryController instance;

        public static CategoryController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryController();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private CategoryController() { }

        private string connectionString = @"Data Source=TIENLV;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        string script = @"";

        // CÁC PHƯƠNG THỨC HIỆN CÓ - GIỮ NGUYÊN
        public void FillCategoryComboBox(string script, ComboBox DropDownName)
        {
            DataTable dt = new DataTable();

            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(script, conn))
                {
                    conn.Open();

                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Lỗi " + e.ToString());
                    }
                }
            }

            DropDownName.DataSource = dt;
            DropDownName.ValueMember = dt.Columns[0].ColumnName;
            DropDownName.DisplayMember = dt.Columns[1].ColumnName;
        }

        public List<Category> GetCategory()
        {
            List<Category> list = new List<Category>();

            script = @"EXEC usp_GetDanhMuc";

            DataTable dt = DataProvider.Instance.ExecuteQuery(script);

            foreach (DataRow item in dt.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }

        public void LoadCategory(DataGridView dataGridViewName)
        {
            script = @"EXEC usp_GetDanhMuc";
            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
        }

        // THÊM CÁC PHƯƠNG THỨC MỚI - KHÔNG THAY ĐỔI CẤU TRÚC HIỆN CÓ

        /// <summary>
        /// Lấy danh mục theo ID
        /// </summary>
        public Category GetCategoryById(int maDanhMuc)
        {
            try
            {
                script = @"EXEC usp_GetDanhMucById @MaDanhMuc";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { maDanhMuc });

                if (dt.Rows.Count > 0)
                {
                    return new Category(dt.Rows[0]);
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh mục: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Thêm danh mục mới
        /// </summary>
        public bool AddCategory(string tenDanhMuc, string moTa, int danhMucCha = 0)
        {
            try
            {
                script = @"EXEC usp_AddDanhMuc @TenDanhMuc, @MoTa, @DanhMucCha";
                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { tenDanhMuc, moTa, danhMucCha });
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm danh mục: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Cập nhật danh mục
        /// </summary>
        public bool UpdateCategory(int maDanhMuc, string tenDanhMuc, string moTa, int danhMucCha = 0)
        {
            try
            {
                script = @"EXEC usp_UpdateDanhMuc @MaDanhMuc, @TenDanhMuc, @MoTa, @DanhMucCha";
                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maDanhMuc, tenDanhMuc, moTa, danhMucCha });
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật danh mục: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Xóa danh mục (soft delete)
        /// </summary>
        public bool DeleteCategory(int maDanhMuc)
        {
            try
            {
                script = @"EXEC usp_DeleteDanhMuc @MaDanhMuc";
                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maDanhMuc });
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa danh mục: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Tìm kiếm danh mục theo tên
        /// </summary>
        public List<Category> SearchCategory(string keyword)
        {
            List<Category> list = new List<Category>();

            try
            {
                script = @"EXEC usp_SearchDanhMuc @Keyword";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { "%" + keyword + "%" });

                foreach (DataRow item in dt.Rows)
                {
                    Category category = new Category(item);
                    list.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm danh mục: " + ex.Message);
            }

            return list;
        }

        /// <summary>
        /// Lấy danh sách danh mục cha (cho ComboBox)
        /// </summary>
        public List<Category> GetParentCategories()
        {
            List<Category> list = new List<Category>();

            try
            {
                script = @"EXEC usp_GetDanhMucCha";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script);

                foreach (DataRow item in dt.Rows)
                {
                    Category category = new Category(item);
                    list.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh mục cha: " + ex.Message);
            }

            return list;
        }

        /// <summary>
        /// Kiểm tra danh mục có tồn tại không
        /// </summary>
        public bool CategoryExists(string tenDanhMuc)
        {
            try
            {
                script = @"SELECT COUNT(*) FROM DanhMuc WHERE TenDanhMuc = @TenDanhMuc AND TrangThai = 1";
                int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script, new object[] { tenDanhMuc }));
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra danh mục: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Đếm số sản phẩm trong danh mục
        /// </summary>
        public int CountProductsInCategory(int maDanhMuc)
        {
            try
            {
                script = @"SELECT COUNT(*) FROM SanPham WHERE MaDanhMuc = @MaDanhMuc AND TrangThai = 1";
                return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script, new object[] { maDanhMuc }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đếm sản phẩm: " + ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Lấy tất cả danh mục (alias cho GetCategory để tương thích)
        /// </summary>
        public List<Category> GetAllCategories()
        {
            return GetCategory();
        }

        /// <summary>
        /// Load danh mục vào ComboBox (phiên bản đơn giản)
        /// </summary>
        public void LoadCategoriesToComboBox(ComboBox comboBox)
        {
            try
            {
                var categories = GetCategory();
                comboBox.DataSource = categories;
                comboBox.DisplayMember = "TenDanhMuc";
                comboBox.ValueMember = "MaDanhMuc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load danh mục: " + ex.Message);
            }
        }

        public bool HasCategories()
        {
            try
            {
                script = @"SELECT COUNT(*) FROM DanhMuc WHERE TrangThai = 1";
                int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script));
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra danh mục: " + ex.Message);
                return false;
            }
        }
    }
}