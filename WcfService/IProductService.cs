using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfServiceREST
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        [WebGet(UriTemplate = "Product/{id}")]
        [Description("get product by Id")]
        Product GetProduct(string id);

        [OperationContract]
        [WebInvoke(Method = "POST")]
        [Description("save product")]
        void SaveProduct(Product product);
    }
}