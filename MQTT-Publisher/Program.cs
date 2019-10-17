using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
namespace MQTT_Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            MqttClient client = new MqttClient("127.0.0.1");
            client.Connect("mingkyme");
            client.Publish("work/mingkyme",Encoding.UTF8.GetBytes("HTTPS://MINGKY.ME"));
            
        }

        
    }
}
