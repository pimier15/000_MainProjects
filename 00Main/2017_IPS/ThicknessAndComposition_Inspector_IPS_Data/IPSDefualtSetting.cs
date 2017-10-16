﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLib.Data;
using SpeedyCoding;

namespace ThicknessAndComposition_Inspector_IPS_Data
{
	public class IPSDefualtSetting
	{
		public IPSDefualtSetting() { }

		// -- Configs config --
		public string BaseDirPath { get { return AppDomain.CurrentDomain.BaseDirectory + "\\" + "config"; } set { } }
		public string StartupConfigName { get { return "SettedConfig.xml"; } set { } }

		
		// -- HW Config --
		// Spetrometer
		public int Boxcar { get { return 5; } set { } }
		public int Scan2Avg { get { return 50; } set { } }
		public int IntegrationTime { get { return 8; } set { } }
		public int SpectrumWaitTime { get { return 500; } set { } }

		// Stage
		public int Port { get { return 4; } set { } }
		public int XStgSpeed { get { return 50000; } set { } }
		public int RStgSpeed { get { return 100000; } set { } }

		//
		public double Weight { get { return -1.9897; } set { } }
		//public double Weight { get { return -0.5277; } set { } }
		public double Bias { get { return 3517.2; } set { } }
		//public double Bias { get { return 1838.9; } set { } }
		public double IntglStart { get { return 440; } set { } }
		//public double IntglStart { get { return 0; } set { } }
		public double IntglEnd { get { return 470; } set { } }
		//public double IntglEnd { get { return 0; } set { } }
	}

	public static class ConfigExt
	{
		public static IPSConfig ToConfig(
		this IPSDefualtSetting src )
		{
			var res = new IPSConfig();
			res.BaseDirPath			=	src.BaseDirPath			;	
			res.StartupConfigName	=	src.StartupConfigName	;
			res.Port				=   src.Port			    ;
			res.Boxcar				=	src.Boxcar				;
			res.Scan2Avg			=	src.Scan2Avg			;
			res.IntegrationTime		=	src.IntegrationTime		;
			res.SpectrumWaitTime = src.SpectrumWaitTime;
			res.XStgSpeed			=	src.XStgSpeed			;
			res.RStgSpeed			=	src.RStgSpeed			;
			res.Weight				=	src.Weight				;
			res.Bias				=	src.Bias				;
			res.IntglStart			=	src.IntglStart			;
			res.IntglEnd			=	src.IntglEnd;
			return res;
		}
	}
}
