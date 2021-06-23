using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class DataAccess
    {
        private readonly IConfiguration config;

        public DataAccess(IConfiguration _config)
        {
            config = _config;
        }
    }
}
