using MongoDB.Bson;

namespace Demo.Domain
{
    public class User
    {
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}
