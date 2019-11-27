using AutoMapper;
using InventorySalesDomain.Factory;
using KnockoutMVCApplication.Product;
using KnockoutMVCApplication.ProductImage.Model;
using KnockoutMVCCommons;
using KnockoutMVCCommons.HttpRequest.RequestPost;

namespace KnockoutMVCApplication.ProductImage.Command.AddProductImageCommand
{
    public class AddProductImageCommand : IAddProductImageCommand
    {
        private readonly IProductImageDomainFactory productImageDomainFactory;
        private readonly IHttpRequestPost httpRequestPost;
        private readonly IMapper mapper;

        public AddProductImageCommand(IProductImageDomainFactory productImageDomainFactory, IHttpRequestPost httpRequestPost)
        {
            this.productImageDomainFactory = productImageDomainFactory;
            this.httpRequestPost = httpRequestPost;
            mapper = ProductMapping.MapConfig.CreateMapper();
        }

        public string ExecuteAddProductImage(AddProductImageModel addProductImageModel)
        {
            string url = ApplicationSettings.Url + "ProductImage/AddProductImage";
            string key = "";

            var ProductImageDomain = productImageDomainFactory.CreateProductImageDomain();

            mapper.Map(addProductImageModel, ProductImageDomain);

            string result = httpRequestPost.ExecutePost(url, key, ProductImageDomain);
            return result;
        }
    }
}
