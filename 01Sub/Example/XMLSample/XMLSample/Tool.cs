﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSample
{
	public static class XmlTool
	{
		public static object MessageBox { get; private set; }

		public static bool WriteXmlClass<T>( T clss , string dirpath , string name ) where T : class
		{
			try
			{
				using ( StreamWriter wr = new StreamWriter( Path.Combine( dirpath , name ) ) )
				{
					XmlSerializer xs = new XmlSerializer( typeof(T) );
					xs.Serialize( wr , clss );
				}
				return true;
			}
			catch ( Exception ex )
			{
				return false;
			}
		}

		public static T ReadXmlClas<T>( T clsDefulat , string dirpath , string name ) where T : class
		{
			try //  이 트라이캐치를 Either로 처리할 수 있을까? 
			{
				string fullpath = Path.Combine( dirpath , name );

				if ( File.Exists( fullpath ) )
				{
					using ( var rd = new StreamReader( fullpath ) )
					{
						XmlSerializer xs = new XmlSerializer( typeof(T) );
						T output = xs.Deserialize(rd) as T;
						return output;
					}
				}
				else
				{
					return clsDefulat;
				}
			}
			catch ( Exception ex )
			{
				return clsDefulat;
			}
		}



	}
}
