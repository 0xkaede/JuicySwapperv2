using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Juicy_Swapper_v2.Classes.API
{
    class ItemShopAPI
    {
        private readonly WebClient _webClient;

        private struct Endpoints
        {
            public const string Base = "https://fortnite-api.com/";
            public const string Shop = Base + "v2/shop/br";
        }

        public ItemShopAPI()
        {
            _webClient = new WebClient();
        }

        public async Task<FortniteAPIShop> GetBRShop()
        {
            string data = await _webClient.DownloadStringTaskAsync(Endpoints.Shop);
            return JsonConvert.DeserializeObject<FortniteAPIShop>(data);
        }
    }

    class FortniteAPIShop
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data")]
        public FortniteAPIShopData Data { get; set; }
    }

    class FortniteAPIShopData
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("featured")]
        public FortniteAPIShopElement Featured { get; set; }

        [JsonProperty("daily")]
        public FortniteAPIShopElement Daily { get; set; }

        [JsonProperty("specialFeatured")]
        public FortniteAPIShopElement SpecialFeatured { get; set; }

        [JsonProperty("specialDaily")]
        public FortniteAPIShopElement SpecialDaily { get; set; }
    }

    class FortniteAPIShopElement
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entries")]
        public List<FortniteAPIShopEntry> Entries { get; set; }
    }

    class FortniteAPIShopEntry
    {
        [JsonProperty("finalPrice")]
        public int FinalPrice { get; set; }

        [JsonProperty("items")]
        public List<FortniteAPIShopItem> Items { get; set; }
    }

    class FortniteAPIShopItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("images")]
        public FortniteAPIShopImages Images { get; set; }

        [JsonProperty("rarity")]
        public FortniteAPIShopRarities Rarity { get; set; }
    }

    class FortniteAPIShopImages
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("featured")]
        public string Featured { get; set; }
    }

    class FortniteAPIShopRarities
    {
        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }
}
