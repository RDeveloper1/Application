using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactApp.WebAPI.Models
{
    public class Title
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("ReleaseYear")]
        public Int32 ReleaseYear { get; set; }

        [BsonElement("Genres")]
        public List<string> Genres { get; set; }
        public List<TitleNameTypeObject> OtherNames { get; set; }

        public List<StoryLines> Storylines { get; set; }


        public List<Participant> Participants { get; set; }
        public List<Award> Awards { get; set; }
        [BsonElement("TitleName")]
        public string TitleName { get; set; }

        public string TitleNameSortable { get; set; }
        public Int32 TitleId { get; set; }

        [BsonElement("Keywords")]
        public List<string> Keywords { get; set; }

        [BsonElement("KeyGenres")]
        public List<string> KeyGenres { get; set; }
    }
}