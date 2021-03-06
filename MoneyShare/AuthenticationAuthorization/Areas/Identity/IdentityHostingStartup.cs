﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoneyShare.Core.DAL.Context;
using MoneyShare.Core.DAL.Models;
using System;

[assembly: HostingStartup(typeof(AuthenticationAuthorization.Areas.Identity.IdentityHostingStartup))]

namespace AuthenticationAuthorization.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}