﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wubbalubbadubzork.Startup))]
namespace Wubbalubbadubzork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
