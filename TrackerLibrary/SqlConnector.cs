using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        ///    Saves a new prize to the database
        /// </summary>
        /// <param name="model">Prize info</param>
        /// <returns>the prize info, including its id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
