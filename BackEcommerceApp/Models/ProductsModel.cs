using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BackEcommerceApp.Models
{
    public partial class ProductsModel
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("brandId")]
        public string BrandId { get; set; }

        [JsonProperty("brandImageUrl")]
        public object BrandImageUrl { get; set; }

        [JsonProperty("linkText")]
        public string LinkText { get; set; }

        [JsonProperty("productReference")]
        public string ProductReference { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("productTitle")]
        public string ProductTitle { get; set; }

        [JsonProperty("metaTagDescription")]
        public string MetaTagDescription { get; set; }

        [JsonProperty("releaseDate")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonProperty("productClusters")]
        public Dictionary<string, string> ProductClusters { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("Cuidados de la prenda")]
        public string[] CuidadosDeLaPrenda { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }
    public partial class Item
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameComplete")]
        public string NameComplete { get; set; }

        [JsonProperty("complementName")]
        public string ComplementName { get; set; }

        [JsonProperty("ean")]
        public string Ean { get; set; }

        [JsonProperty("measurementUnit")]
        public string MeasurementUnit { get; set; }

        [JsonProperty("unitMultiplier")]
        public string UnitMultiplier { get; set; }

        [JsonProperty("modalType")]
        public object ModalType { get; set; }

        [JsonProperty("isKit")]
        public bool IsKit { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("Print color")]
        public string[] PrintColor { get; set; }

        [JsonProperty("Talla")]
        public string[] Talla { get; set; }

        [JsonProperty("Color")]
        public string[] Color { get; set; }

        [JsonProperty("variations")]
        public string[] Variations { get; set; }

        [JsonProperty("sellers")]
        public List<Seller> Sellers { get; set; }
    }
    public partial class Image
    {
        [JsonProperty("imageId")]
        public string ImageId { get; set; }

        [JsonProperty("imageLabel")]
        public object ImageLabel { get; set; }

        [JsonProperty("imageTag")]
        public string ImageTag { get; set; }

        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("imageText")]
        public string ImageText { get; set; }

        [JsonProperty("imageLastModified")]
        public DateTimeOffset ImageLastModified { get; set; }
    }
    public partial class Seller
    {
        [JsonProperty("commertialOffer")]
        public CommertialOffer CommertialOffer { get; set; }
    }
    public partial class CommertialOffer
    {
        [JsonProperty("Price")]
        public string Price { get; set; }

        [JsonProperty("ListPrice")]
        public string ListPrice { get; set; }

        [JsonProperty("PriceWithoutDiscount")]
        public string PriceWithoutDiscount { get; set; }

        [JsonProperty("RewardValue")]
        public string RewardValue { get; set; }

        [JsonProperty("PriceValidUntil")]
        public DateTimeOffset PriceValidUntil { get; set; }

        [JsonProperty("AvailableQuantity")]
        public string AvailableQuantity { get; set; }

        [JsonProperty("Tax")]
        public string Tax { get; set; }

        [JsonProperty("SaleChannel")]
        public string SaleChannel { get; set; }

        [JsonProperty("GetInfoErrorMessage")]
        public object GetInfoErrorMessage { get; set; }
    }
}
