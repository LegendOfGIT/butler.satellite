using System;
using System.Collections.Generic;
using System.Text;

using Data.Warehouse;

using Newtonsoft.Json;
using RabbitMQ.Client;

namespace Satellite.Provider
{
  public class InfostoreQueueProvider : DataWarehouseProvider
  {
    private IModel Channel { get; set; }

    public InfostoreQueueProvider()
    {
      this.Channel = CreateConnection();
    }

    public IEnumerable<Dictionary<string, IEnumerable<object>>> DigInformation(string question)
    {
      throw new NotImplementedException();
    }

    public void StoreInformation(Dictionary<string, IEnumerable<object>> information)
    {
      information = information.PrepareInformation();

      var queue = "Store Information";

      var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(information));

      this.Channel.QueueDeclare(
            queue: queue,
            durable: false,
            exclusive: false,
            autoDelete: false,
            arguments: null);

      this.Channel.BasicPublish(
              exchange: string.Empty,
              routingKey: queue,
              basicProperties: null,
              body: body);
    }

    /// <summary>
    /// 
    /// </summary>
    private IModel CreateConnection()
    {
      var factory = CreateConnectionFactory();
      var connection = factory.CreateConnection();

      return connection.CreateModel();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private ConnectionFactory CreateConnectionFactory()
    {
      var factory = new ConnectionFactory()
      {
        VirtualHost = "/",
        HostName = "127.0.0.1",
        Port = AmqpTcpEndpoint.UseDefaultPort
      };
      factory.UserName = "guest";
      factory.Password = "guest";
      return factory;
    }
  }
}
