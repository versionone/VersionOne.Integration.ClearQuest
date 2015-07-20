using System;
using System.Collections.Generic;
using System.Text;

namespace VersionOne.ServiceHost.ClearQuestServices.Exceptions
{
	class ClearQuestLoginException : ClearQuestException
	{

		public ClearQuestLoginException(string message) : base(message)
		{
		}
	}
}
