using System.Collections.Generic;
using System.Threading.Tasks;

using Satellite.DataWarehouse;
using System.Net;

namespace Satellite
{
    public class Satellite : ISatellite
    {
        public static DataWarehouseClient WarehouseClient = new DataWarehouseClient();

        public void Process(string template, Dictionary<string, string> parameters)
        {
            new Task(
                () => {
                    Kernel.Process(
                        template, 
                        parameters
                    );
                }
            ).Start();
        }
    }
}
