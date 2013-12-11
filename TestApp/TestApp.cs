using System;
using System.Diagnostics;
using System.Configuration;
using System.Collections;
using System.Data.SqlTypes;

using OrmLib;
using dbMantenimientoBiz;

namespace TestApp
{
	/// <summary>
	/// This test app can be used to test your new Biz object.
	/// Please make sure that the test app is set as the startup Project.
	/// </summary>
	class TestApp
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//
			// TODO: Add code to start application here
			//
			DataManager dm = new DataManager(Config.Dsn);
		}
	}
}
