﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.BL.DataModel;

namespace IMS.BL.Repositories
{
    public interface IUserAccountRepo : IRepository<UserAccount>
    {
        List<UserAccount> UserAccountByUsername(string username);
    }
}
