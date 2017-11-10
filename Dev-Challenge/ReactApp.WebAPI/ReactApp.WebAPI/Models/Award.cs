using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactApp.WebAPI.Models
{
    public class Award
    {
        public bool AwardWon { get; set; }
        public Int32 AwardYear { get; set; }
        public List<string> Participants { get; set; }

        [BsonElement("Award")]
        public string AwardName { get; set; }
        public string AwardCompany { get; set; }
    }
}