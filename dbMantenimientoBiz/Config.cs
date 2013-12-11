/* (ORM.NET)
 * This is a one time generated class skeleton by ORM.NET.
 * Please add your business logic for the class here.
 * Please do not remove these comments as they are required by ORM.NET to function correctly.
 */using System;
using System.Configuration;

namespace dbMantenimientoBiz
{
	/// <summary>
	/// Wraps the app.config file by exposing it's key/value pairs
	/// as static properties.
	/// </summary>
	/// <example>
	/// For example, instead of using
	/// <code>DataManager dm = new DataManager(ConfigurationSettings.AppSettings["dsn"]);</code>
	/// the wrapped static method can be used:
	/// <code>DataManager dm = new DataManager(Config.Dsn);</code>
	/// </example>
	public class Config
	{
		private Config(){}

		/// <summary>
		/// Wraps the 'dsn' entry in the app.config file.
		/// </summary>
		/// <value>
		/// Data source name.
		/// </value>
		public static string Dsn { get { lock( typeof(Config) )	{ return ConfigurationSettings.AppSettings["dsn"]; } } }
	}
}
