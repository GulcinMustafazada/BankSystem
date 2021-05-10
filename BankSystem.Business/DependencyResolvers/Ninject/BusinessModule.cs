using BankSystem.Business.Abstract;
using BankSystem.Business.Concrete;
using BankSystem.DataAccess.Abstract;
using BankSystem.DataAccess.Concrete;
using BankSystem.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();
            Bind<IEmployeeService>().To<EmployeeManager>().InSingletonScope();
            Bind<IEmployeeDal>().To<EfEmployeeDal>().InSingletonScope();
            Bind<IDirectorService>().To<DirectorManager>().InSingletonScope();
            Bind<IDirectorDal>().To<EfDirectorDal>().InSingletonScope();
            Bind<ILoanService>().To<LoanManager>().InSingletonScope();
            Bind<ILoanDal>().To<EfLoanDal>().InSingletonScope();
        }
    }
}
