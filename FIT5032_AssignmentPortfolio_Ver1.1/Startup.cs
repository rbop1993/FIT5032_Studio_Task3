﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032_AssignmentPortfolio_Ver1._1.Startup))]
namespace FIT5032_AssignmentPortfolio_Ver1._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
