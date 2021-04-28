﻿using BankSystem.DataAccess.Abstract;
using BankSystem.Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.DataAccess.Concrete.EntityFramework
{
   public class EfEmployeeDal:EfEntityRepositoryBase<Employee,BankContext>,IEmployeeDal
    {
    }
}
