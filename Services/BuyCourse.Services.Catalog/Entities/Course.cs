using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace BuyCourse.Services.Catalog.Entities
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedTime { get; set; }
        public Feature Feature { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        [BsonIgnore] // Collection'a satır olarak dahil etme, include'da kullanacağım( productları gösterirken kategorileri de göstermek içinkod içersinde göstericem)
        public Category Category { get; set; }

    }
}
