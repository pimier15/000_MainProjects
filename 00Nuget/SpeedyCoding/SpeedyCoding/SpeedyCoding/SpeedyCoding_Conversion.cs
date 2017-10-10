﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyCoding
{
	public static class SpeedyCoding_Conversion
	{
		public static T ToNonNullable<T>( this Nullable<T> src ) where T : struct
		{
			return src == null ? default( T ) : (T)src;
		}

		//public static Task<T> ToTask<T,A>( this )

	}
}