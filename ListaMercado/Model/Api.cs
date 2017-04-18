using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    // Produtos
    public class Api
    {
        [JsonProperty("results")]
        public Result[] results { get; set; }
        [JsonProperty("messages")]
        public string[] messages { get; set; }
    }

    public class Result
    {
        [JsonProperty("Image")]
        public string Image { get; set; }
        [JsonProperty("ProductUpdates")]
        public Productupdate[] ProductUpdates { get; set; }
        [JsonProperty("IsBiologic")]
        public bool IsBiologic { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("IsGlutenFree")]
        public bool IsGlutenFree { get; set; }
        [JsonProperty("IsLactoseFree")]
        public bool IsLactoseFree { get; set; }
        [JsonProperty("IsInPromotions")]
        public bool IsInPromotion { get; set; }
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Brand")]
        public string Brand { get; set; }
        [JsonProperty("IsGourmet")]
        public bool IsGourmet { get; set; }
        [JsonProperty("ImageProvider")]
        public string ImageProvider { get; set; }
        [JsonProperty("SalePackage")]
        public string SalePackage { get; set; }
    }

    public class Productupdate
    {
        public float DiscountRate { get; set; }
        public string BaseUnit { get; set; }
        public Productprovider ProductProvider { get; set; }
        public float SalePrice { get; set; }
        public Provider Provider { get; set; }
        public bool InPromotion { get; set; }
        public bool IsBestPrice { get; set; }
        public int Id { get; set; }
        public string SalePackage { get; set; }
        public string SaleUnit { get; set; }
        public float PromotionValue { get; set; }
        public float BasePrice { get; set; }
        public DateTime PromotionStartDate { get; set; }
        public DateTime PromotionEndDate { get; set; }
    }

    public class Productprovider
    {
        public int ProviderId { get; set; }
        public string URL { get; set; }
    }

    public class Provider
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }


    // Moedas

    public class ApiMoeda
    {
        public string _base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
    }

    public class Rates
    {
        public float BRL { get; set; }
    }


}
