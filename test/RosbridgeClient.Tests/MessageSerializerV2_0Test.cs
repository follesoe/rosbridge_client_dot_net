using System;
using Xunit;
using Rosbridge.Client;

namespace Rosbridge.Tests
{
    public class MessageSerializerV2_0Test
    {
        [Fact]
        public void Should_be_able_to_serialize_and_deserialize_message() 
        {
            dynamic message = new System.Dynamic.ExpandoObject();
            message.name = "Jon Doe";
            message.age = 30;

            var serializer = new MessageSerializerV2_0();
            var serializedMsg = serializer.Serialize(message);
            var deSerializedMsg = serializer.Deserialize(serializedMsg);

            Assert.Equal(message.name.ToString(), deSerializedMsg.name.ToString());
        }
    }
}