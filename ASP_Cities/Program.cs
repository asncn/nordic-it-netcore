using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using NLog.Web;

namespace L22_C01_empty_asp_net_core_app
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var logger = NLogBuilder
				.ConfigureNLog("nlog.config")
				.GetCurrentClassLogger();

			try
			{
				logger.Debug("init main");
				CreateHostBuilder(args).Build().Run();
			}
			catch (Exception e)
			{
				logger.Error(e, "Stopped program because of exception");
				throw;
			}
			finally
			{
				NLog.LogManager.Shutdown();
			}
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				})
				.ConfigureLogging(logging =>
				{
					//logging.ClearProviders();
					logging.SetMinimumLevel(LogLevel.Trace);
				})
				.UseNLog();  // NLog: Setup NLog for Dependency injection;
	}
}

