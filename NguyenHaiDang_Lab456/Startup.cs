﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenHaiDang_Lab456.Startup))]
namespace NguyenHaiDang_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
