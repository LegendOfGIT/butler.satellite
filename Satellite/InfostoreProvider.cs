using System;
using System.Collections.Generic;
using System.Linq;

using Data.Warehouse;

namespace Satellite
{
    public class InfostoreProvider : DataWarehouseProvider
    {
        public IEnumerable<Dictionary<string, IEnumerable<object>>> DigInformation(string question)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Leitet die aus dem Web gelesenen Informationen an den Infostore weiter.
        /// </summary>
        /// <param name="information"></param>
        public void StoreInformation(Dictionary<string, IEnumerable<object>> information)
        {
            try
            {
                Satellite.WarehouseClient.StoreInformation(information.ToDictionary(
                    entry => entry.Key, 
                    entry => entry.Value.ToArray()
                ));
            }
            catch (Exception) { }
        }
    }
}