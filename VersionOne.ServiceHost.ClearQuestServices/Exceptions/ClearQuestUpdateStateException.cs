using System;
using System.Collections.Generic;
using System.Text;

namespace VersionOne.ServiceHost.ClearQuestServices.Exceptions
{
	public class ClearQuestUpdateException : ClearQuestException
	{
		private int codeError;

		public ClearQuestUpdateException(string message) : base(message)
		{
		}

		public ClearQuestUpdateException(string message, int codeError) : base(message)
		{
			this.codeError = codeError;
		}

		public int CodeError
		{
			get { return codeError; }
		}
	}
}
