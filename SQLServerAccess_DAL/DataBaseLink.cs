﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateOnlineJudge.Entity;

namespace CalculateOnlineJudge.SQLServerAccess_DAL
{
    public partial class DataBaseAccess : CalculateOnlineJudge.DataBaseAccessFactory_DAL.IDataBaseAccess
    {
        private static readonly string ConnectionString =
            @"
                Data Source=172_27_0_17;
                Initial Catalog = WebServerDataBase; 
                User ID = sa; 
                Password=1236zccg99326SA;
                Connect Timeout = 30; 
                Encrypt=False;
                TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False
            ";
    }
}
