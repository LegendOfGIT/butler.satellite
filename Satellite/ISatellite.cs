using System.Collections.Generic;
using System.ServiceModel;
using System.Xml.Linq;

namespace Satellite
{
    [ServiceContract]
    public interface ISatellite
    {        
        [OperationContract]
        void Process(string template, Dictionary<string, string> parameters);
    }

    public class Storage
    {
        public virtual void Store(KeyValuePair<string, Dictionary<string, List<string>>> kvpInfos, XDocument xdTemplate) { }
    }
}
