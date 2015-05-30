namespace WcfServiceREST
{
    public class ProductService : IProductService
    {
        public Product GetProduct(string id)
        {
            return new Product
            {
                Id = int.Parse(id),
                Name = string.Format("Product{0}", id)
            };
        }

        public void SaveProduct(Product product)
        {
            //save
        }
    }
}