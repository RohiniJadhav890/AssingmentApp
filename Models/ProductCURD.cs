using Microsoft.Data.SqlClient;

namespace AssingmentApp.Models
{
    public class ProductCURD
    {
        //SqlConnection con;
        //SqlCommand cmd;
        //SqlDataReader reader;
        //IConfiguration configuration;
        //public ProductCURD(IConfiguration configuration)
        //{
        //    this.configuration = configuration;
        //    con = new SqlConnection(this.configuration.GetConnectionString("DefaultConnection"));
        //}
        ////1>Get All product list
        //public List<Products> GetProducts()
        //{
        //    List<Products> products = new List<Products>();
        //    cmd = new SqlCommand("select p.ProductId,p.ProductName, c.CategoryId, c.CategoryName from Product p join Category c on p.CategoryId=c.CategoryId", con);
        //    con.Open();
        //    reader = cmd.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Products product = new Products();
        //            product.ProductId = Convert.ToInt32(reader["productid"]);
        //            product.ProductName = reader["productname"].ToString();
        //            product.CategoryId = Convert.ToInt32(reader["categoryid"]);
        //          //  product.CategoryName = reader["categoryname"].ToString();
        //            products.Add(product);
        //        }
        //    }
        //    con.Close();
        //    return products;
        //}
        ////2.Add product
        //public int AddProduct(Products product)
        //{
        //    int result = 0;
        //    string qry = "insert into Product (productname,categoryid) values(@productname, @categoryid)";
        //    cmd = new SqlCommand(qry, con);
        //    cmd.Parameters.AddWithValue("@productname", product.ProductName);
        //    cmd.Parameters.AddWithValue("@categoryid", product.CategoryId);
        //    con.Open();
        //    result = cmd.ExecuteNonQuery();
        //    con.Close();
        //    return result;
        //}
        ////3  get category by id
        //public Products GetProductById(int productid)
        //{
        //    Products product = new Products();
        //    cmd = new SqlCommand("select p.ProductId,p.ProductName, c.CategoryId, c.CategoryName from Product p join Category c on p.CategoryId=c.CategoryId where p.productid=@productid", con);
        //    cmd.Parameters.AddWithValue("@productid", productid);
        //    con.Open();
        //    reader = cmd.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            product.ProductId = Convert.ToInt32(reader["productid"]);
        //            product.ProductName = reader["productname"].ToString();
        //            product.CategoryId = Convert.ToInt32(reader["categoryid"]);
        //          //  product.CategoryName = ["categoryname"].ToString();
        //           // product.CategoryName = reader["productname"].ToString();
        //        }
        //    }
        //    con.Close();
        //    return product;
        //}
        ////4>update product
        //public int UpdateProduct(Products product)
        //{
        //    int result = 0;
        //    string qry = "update Product set productname =@productname, categoryid=@categoryid where productid =@productid";
        //    cmd = new SqlCommand(qry, con);
        //    cmd.Parameters.AddWithValue("@productname", product.ProductName);
        //    cmd.Parameters.AddWithValue("@categoryid", product.CategoryId);
        //    cmd.Parameters.AddWithValue("productid", product.ProductId);
        //    con.Open();
        //    result = cmd.ExecuteNonQuery();
        //    con.Close();
        //    return result;
        //}
        ////5>Delete Product
        //public int DeleteProduct(int id)
        //{
        //    int result = 0;
        //    string qry = "delete from Product where productid=@productid";
        //    cmd = new SqlCommand(qry, con);
        //    cmd.Parameters.AddWithValue("@productid", id);
        //    con.Open();
        //    result = cmd.ExecuteNonQuery();
        //    con.Close();
        //    return result;
        //}
    }
}
