using System;
using Xunit;
using Rosbridge.Client;

namespace Rosbridge.Tests
{
    public class ServiceClientConnectionTest
    {
        [Fact]
        public async void Should_be_able_to_connect_and_disconnect_to_rosbridge_server()
        {
            var md = new MessageDispatcher(
                new Socket(new Uri("ws://192.168.0.135:9090")),
                new MessageSerializerV2_0());

            Console.WriteLine($"Status: {md.CurrentState}");
            Console.WriteLine("Starting message dispatcher...");            
            await md.StartAsync();

            Console.WriteLine($"Status: {md.CurrentState}");        
            Console.WriteLine("Stoppign message dispatcher...");
            await md.StopAsync();

            Console.WriteLine($"Status: {md.CurrentState}");
        }
    }
}