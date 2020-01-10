using DAL.Interfaces;
using DAL.MailSender;
using DAL.QuestionSender;
using DAL.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Infrastucture
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IProductService>().To<ProductService>();
            kernel.Bind<IOrderService>().To<MailSender>();
            kernel.Bind<IQuestionSender>().To<QuestionSender>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}