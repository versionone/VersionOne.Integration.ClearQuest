using IBM.ClearQuest.Interop;
using System.Runtime.InteropServices;
using VersionOne.ServiceHost.ClearQuestServices.Exceptions;

namespace VersionOne.ServiceHost.ClearQuestServices 
{
    public interface IClearQuestSessionBuilder 
    {
        IOAdSession Create(ClearQuestServiceConfiguration config);
    }

    public class ClearQuestSession : IClearQuestSessionBuilder
	{
        private IOAdSession session;

        public IOAdSession Create(ClearQuestServiceConfiguration config) 
		{
            if (session == null) 
            {
                session = new SessionClass();
				try
				{
					session.UserLogon(config.Username, config.Password, config.Database, Constants.SessionTypePrivate,
								  config.ConnectionName);
				}
				catch (COMException ex)
				{
					throw new ClearQuestLoginException("Connection to the ClearQuest system failed: " + ex.Message);
				}
            }

            return session;
        }
	}
}
