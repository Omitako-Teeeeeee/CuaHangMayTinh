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
        public static ProductController Instance => instance ?? (instance = new ProductController());

        private ProductController() { }

        #region BASIC CRUD OPERATIONS

        public List<Product> GetAllProducts()
        {
            try
            {
                string script = @"EXEC usp_GetSanPham";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script);
                return ConvertDataTableToList(dt);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy danh sách sản phẩm", ex);
            }
        }

        public Product GetProductById(int productId)
        {
            try
            {
                string script = @"EXEC usp_GetSanPhamByID @MaSP";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { productId });
                return dt.Rows.Count > 0 ? new Product(dt.Rows[0]) : null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Lỗi khi lấy sản phẩm ID {productId}", ex);
            }
        }

        public bool AddProduct(Product product)
        {
            try
            {
                string script = @"EXEC usp_AddSanPham @TenSP, @MaDanhMuc, @MaNCC, @MoTa, 
                                @BaoHanh, @GiaNhap, @GiaBan, @SoLuongTon";

                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[]
                {
                    product.TenSP, product.MaDanhMuc, product.MaNCC, product.MoTa,
                    product.BaoHanh, product.GiaNhap, product.GiaBan, product.SoLuongTon
                });

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi thêm sản phẩm", ex);
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                string script = @"EXEC usp_UpdateSanPham @MaSP, @TenSP, @MaDanhMuc, @MaNCC, 
                                @MoTa, @BaoHanh, @GiaNhap, @GiaBan, @SoLuongTon";

                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[]
                {
                    product.MaSP, product.TenSP, product.MaDanhMuc, product.MaNCC, product.MoTa,
                    product.BaoHanh, product.GiaNhap, product.GiaBan, product.SoLuongTon
                });

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Lỗi khi cập nhật sản phẩm ID {product.MaSP}", ex);
            }
        }

        public bool DeleteProduct(int productId)
        {
            try
            {
                string script = @"EXEC usp_DeleteSanPham @MaSP";
                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { productId });
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Lỗi khi xóa sản phẩm ID {productId}", ex);
            }
        }

        #endregion

        #region INVENTORY MANAGEMENT

        public int GetTotalProductCount()
        {
            try
            {
                string script = @"EXEC usp_CountSanPham";
                return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script));
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi đếm tổng sản phẩm", ex);
            }
        }

        public int GetOutOfStockCount()
        {
            try
            {
                string script = @"EXEC usp_CountSanPhamHetHang";
                return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script));
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi đếm sản phẩm hết hàng", ex);
            }
        }

        public int GetLowStockCount(int threshold = 5)
        {
            try
            {
                string script = @"EXEC usp_CountSanPhamSapHetHang @SoLuongTon";
                return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script, new object[] { threshold }));
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi đếm sản phẩm sắp hết hàng", ex);
            }
        }

        public bool UpdateProductStock(int productId, int quantity)
        {
            try
            {
                string script = @"EXEC usp_UpdateProductStock @MaSP, @SoLuongTon";
                int result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { productId, quantity });
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Lỗi khi cập nhật tồn kho sản phẩm ID {productId}", ex);
            }
        }

        #endregion

        #region SEARCH AND FILTER

        public List<Product> GetProductsByCategory(int categoryId)
        {
            try
            {
                string script = @"EXEC usp_GetSanPhamByMaDanhMuc @MaDanhMuc";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { categoryId });
                return ConvertDataTableToList(dt);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Lỗi khi lấy sản phẩm theo danh mục {categoryId}", ex);
            }
        }

        public List<Product> GetProductsByStockRange(int minStock, int maxStock)
        {
            try
            {
                string script = @"EXEC usp_GetSanPhamByStockRange @MinStock, @MaxStock";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { minStock, maxStock });
                return ConvertDataTableToList(dt);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy sản phẩm theo khoảng tồn kho", ex);
            }
        }

        public List<Product> SearchProducts(string keyword)
        {
            try
            {
                string script = @"EXEC usp_SearchProduct @Keyword";
                DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { $"%{keyword}%" });
                return ConvertDataTableToList(dt);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi tìm kiếm sản phẩm", ex);
            }
        }

        #endregion

        #region DATA BINDING

        public void BindProductsToGrid(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = GetAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BindProductsToGridByCategory(DataGridView dataGridView, int categoryId)
        {
            try
            {
                dataGridView.DataSource = GetProductsByCategory(categoryId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region PRIVATE METHODS

        private List<Product> ConvertDataTableToList(DataTable dt)
        {
            List<Product> products = new List<Product>();
            foreach (DataRow row in dt.Rows)
            {
                products.Add(new Product(row));
            }
            return products;
        }

        #endregion
    }
}