using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CoByTu.Data.Models;

namespace CoByTu
{
    class Root
    {
        [JsonProperty("dania")]
        public IEnumerable<Meal> Meals { private set; get; }

        [JsonProperty("next")]
        public int Next { private set; get; }

        [JsonProperty("total")]
        public List<Meal> Total { private set; get; }

        [JsonProperty("batches")]
        public int Batches { private set; get; }

        [JsonProperty("currentBatch")]
        public int CurrentBatch { private set; get; }

        public Root() { }
    }
}
