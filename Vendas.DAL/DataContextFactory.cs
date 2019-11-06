using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.DAL
{
    public class DataContextFactory
    {
        private static VendasDataContext contextData;

        public static VendasDataContext ContextData
        {
            get
            {
                if (contextData == null)
                {
                    contextData = new VendasDataContext();
                }
                return contextData;

            }
        }
    }
}
