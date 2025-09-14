using CuaHangMayTinh.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CuaHangMayTinh.Controllers
{
    public class ProductController
    {
        private static ProductController instance;

        public static ProductController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductController();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private ProductController() { }

        private string script = @"";

        #region BASIC CRUD OPERATIONS

        public List<Product> GetProduct()
        {
            List<Product> list = new List<Product>();

            try
            {
                script = @"EXEC usp_GetSanPham";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script);

                foreach (DataRow item in dt.Rows)
                {
                    Product product = new Product(item);
                    list.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách sản phẩm: " + ex.Message);
            }

            return list;
        }

        public Product GetProductById(int productId)
        {
            try
            {
                script = @"EXEC usp_GetSanPhamByID @MaSP";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { productId });

                if (dt.Rows.Count > 0)
                {
                    return new Product(dt.Rows[0]);
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy sản phẩm ID {productId}: " + ex.Message);
                return null;
            }
        }

        public bool AddProduct(string tenSP, int maDanhMuc, int maNCC, string moTa,
                             int baoHanh, decimal giaNhap, decimal giaBan, int soLuongTon)
        {
            try
            {
                script = @"EXEC usp_AddSanPham @TenSP, @MaDanhMuc, @MaNCC, @MoTa, 
                         @BaoHanh, @GiaNhap, @GiaBan, @SoLuongTon";

                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[]
                {
                    tenSP, maDanhMuc, maNCC, moTa, baoHanh, giaNhap, giaBan, soLuongTon
                });

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
                return false;
            }
        }

        public bool UpdateProduct(int maSP, string tenSP, int maDanhMuc, int maNCC, string moTa,
                                int baoHanh, decimal giaNhap, decimal giaBan, int soLuongTon)
        {
            try
            {
                script = @"EXEC usp_UpdateSanPham @MaSP, @TenSP, @MaDanhMuc, @MaNCC, 
                         @MoTa, @BaoHanh, @GiaNhap, @GiaBan, @SoLuongTon";

                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[]
                {
                    maSP, tenSP, maDanhMuc, maNCC, moTa, baoHanh, giaNhap, giaBan, soLuongTon
                });

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sản phẩm ID {maSP}: " + ex.Message);
                return false;
            }
        }

        public bool DeleteProduct(int productId)
        {
            try
            {
                script = @"EXEC usp_DeleteSanPham @MaSP";
                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { productId });
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sản phẩm ID {productId}: " + ex.Message);
                return false;
            }
        }

        #endregion

        #region INVENTORY MANAGEMENT

        public int GetTotalProduct()
        {
            try
            {
                script = @"EXEC usp_CountSanPham";
                return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đếm tổng sản phẩm: " + ex.Message);
                return 0;
            }
        }

        public int GetOutOfStockProduct()
        {
            try
            {
                script = @"EXEC usp_CountSanPhamHetHang";
                return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đếm sản phẩm hết hàng: " + ex.Message);
                return 0;
            }
        }

        public int GetLowStockProduct(int threshold = 5)
        {
            try
            {
                script = @"EXEC usp_CountSanPhamSapHetHang @SoLuongTon";
                return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script, new object[] { threshold }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đếm sản phẩm sắp hết hàng: " + ex.Message);
                return 0;
            }
        }

        public bool UpdateProductStock(int productId, int quantity)
        {
            try
            {
                script = @"EXEC usp_UpdateProductStock @MaSP, @SoLuongTon";
                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { productId, quantity });
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật tồn kho sản phẩm ID {productId}: " + ex.Message);
                return false;
            }
        }

        #endregion

        #region SEARCH AND FILTER

        public List<Product> GetProductsByCategory(int categoryId)
        {
            List<Product> list = new List<Product>();

            try
            {
                script = @"EXEC usp_GetSanPhamByMaDanhMuc @MaDanhMuc";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { categoryId });

                foreach (DataRow item in dt.Rows)
                {
                    Product product = new Product(item);
                    list.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy sản phẩm theo danh mục {categoryId}: " + ex.Message);
            }

            return list;
        }

        public List<Product> GetProductsByStockRange(int minStock, int maxStock)
        {
            List<Product> list = new List<Product>();

            try
            {
                script = @"EXEC usp_GetSanPhamByStockRange @MinStock, @MaxStock";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { minStock, maxStock });

                foreach (DataRow item in dt.Rows)
                {
                    Product product = new Product(item);
                    list.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy sản phẩm theo khoảng tồn kho: " + ex.Message);
            }

            return list;
        }

        public List<Product> SearchProducts(string keyword)
        {
            List<Product> list = new List<Product>();

            try
            {
                script = @"EXEC usp_SearchProduct @Keyword";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { "%" + keyword + "%" });

                foreach (DataRow item in dt.Rows)
                {
                    Product product = new Product(item);
                    list.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm sản phẩm: " + ex.Message);
            }

            return list;
        }

        #endregion

        #region DATA BINDING

        public void LoadProduct(DataGridView dataGridViewName)
        {
            try
            {
                script = @"EXEC usp_GetSanPham";
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm: " + ex.Message);
            }
        }

        public void LoadProductByIDCategory(DataGridView dataGridViewName, int categoryId)
        {
            try
            {
                script = @"EXEC usp_GetSanPhamByMaDanhMuc @MaDanhMuc";
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { categoryId });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm theo danh mục: " + ex.Message);
            }
        }

        public void LoadProductOnlyStock(DataGridView dataGridViewName, int minStock, int maxStock)
        {
            try
            {
                script = @"EXEC usp_GetSanPhamByStockRange @MinStock, @MaxStock";
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { minStock, maxStock });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm theo khoảng tồn: " + ex.Message);
            }
        }

        public void LoadProductByIDCategoryAndStock(DataGridView dataGridViewName, int categoryId, int minStock, int maxStock)
        {
            try
            {
                script = @"EXEC usp_GetSanPhamByCategoryAndStock @MaDanhMuc, @MinStock, @MaxStock";
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { categoryId, minStock, maxStock });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm theo danh mục và khoảng tồn: " + ex.Message);
            }
        }

        #endregion

        #region COMBOBOX METHODS

        public void FillProductComboBox(string script, ComboBox DropDownName)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = DataProvider.Instance.ExecuteQuery(script);
                DropDownName.DataSource = dt;
                DropDownName.ValueMember = dt.Columns[0].ColumnName;
                DropDownName.DisplayMember = dt.Columns[1].ColumnName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổ dữ liệu vào combobox: " + ex.Message);
            }
        }


        public bool HasProducts()
        {
            try
            {
                script = @"SELECT COUNT(*) FROM SanPham WHERE TrangThai = 1";
                int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script));
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra sản phẩm: " + ex.Message);
                return false;
            }
        }
        #endregion
    }
}