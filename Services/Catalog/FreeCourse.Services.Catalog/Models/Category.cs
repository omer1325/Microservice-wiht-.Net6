using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FreeCourse.Services.Catalog.Models
{
    public class Category
    {
        //For it to be detected as an ID by MongoDb
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
