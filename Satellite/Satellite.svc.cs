using System.Collections.Generic;
using System.Threading.Tasks;

namespace Satellite
{
    public class Satellite : ISatellite
    {
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
