﻿global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using SmartBin.Infrastructure.Domain.Models.Person;
global using SmartBin.Infrastructure.Domain.Context.Configurations;
global using SmartBin.Infrastructure.Domain.Models.Bin;
global using SmartBin.Infrastructure.Domain.Models.Histories;
global using SmartBin.Infrastructure.Domain.Context;
global using SmartBin.Infrastructure.Repositories;
global using SmartBin.Infrastructure.Repositories.UnitOfWork;
global using SmartBin.Infrastructure.Services.Users;
global using SmartBin.Infrastructure.Domain.Resources.Users;
global using SmartBin.Infrastructure.Repositories.Users;
global using SmartBin.Infrastructure.Domain.Mapping;
global using SmartBin.Infrastructure.Services.Point;
global using SmartBin.Infrastructure.Domain.Resources.Points;
global using SmartBin.Infrastructure.Services.Bins;
global using SmartBin.Infrastructure.Repositories.Bins;
global using SmartBin.Infrastructure.Domain.Resources.BinUnits;
global using SmartBin.Infrastructure.Domain.Resources.Bins;
global using SmartBin.Infrastructure.Repositories.BinUnits;
global using SmartBin.Infrastructure.Repositories.Points;
global using SmartBin.Infrastructure.Services.BinUnits;
global using SmartBin.Infrastructure.Domain.Resources.CollectedHistories;
global using SmartBin.Infrastructure.Domain.Resources.Admins;
global using SmartBin.Infrastructure.Services.Admins;
global using SmartBin.Infrastructure.Repositories.Admins;
global using SmartBin.Infrastructure.MqttClients;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Newtonsoft.Json;
global using Microsoft.Extensions.Configuration;
global using SmartBin.Host.Hosting;
global using SmartBin.Infrastructure.Services.Routes;
global using SmartBin.Infrastructure.Domain.Resources.FindRoute;
