﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthTest2.Startup))]
namespace AuthTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
