using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace VersionOne.ServiceHost.ClearQuestServices.Exceptions
{
	public class ClearQuestException : Exception
	{
		public ClearQuestException(string message) : base(message)
		{
			
		}
	}
}
