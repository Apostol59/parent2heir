using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace parent2heir.jsonNet
{
    public class ParentConverter
    {
        public static THeir ToHeir<TParent, THeir>(TParent parent) where THeir : TParent
        {
            var serializer = new JsonSerializer();
            using (var memoryStream = new MemoryStream())
            using (var bsonWriter = new BsonDataWriter(memoryStream))
            {
                serializer.Serialize(bsonWriter, parent);
                memoryStream.Seek(0, SeekOrigin.Begin);
                using (var bsonReader = new BsonDataReader(memoryStream))
                {
                    return serializer.Deserialize<THeir>(bsonReader);
                }
            }
        }
    }
}