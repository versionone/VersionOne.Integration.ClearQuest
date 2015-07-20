using System;
using System.Collections.Generic;
using System.Text;
using VersionOne.ServiceHost.Eventing;
using VersionOne.ServiceHost.Core.Logging;
using VersionOne.ServiceHost.ClearQuestServices.Exceptions;
using VersionOne.ServiceHost.WorkitemServices;

namespace VersionOne.ServiceHost.ClearQuestServices
{
	class ClearQuestReaderUpdater : IClearQuestReader, IClearQuestUpdater
	{
		private readonly ClearQuestQuery query;
	    private ClearQuestServiceConfiguration config;
		private readonly ILogger logger;

		public ClearQuestReaderUpdater(ClearQuestQuery query, ClearQuestServiceConfiguration config, ILogger logger)
		{
			this.query = query;
			this.logger = logger;
		    this.config = config;
		}

		#region IClearQuestUpdater Members

		public void OnDefectCreated(WorkitemCreationResult createdResult)
		{
			query.UpdateStatesToSubmittedToV1(createdResult.Source.ExternalId);
		}

		public void OnDefectStateChange(WorkitemStateChangeResult stateChangeResult)
		{
			logger.Log(LogMessage.SeverityType.Debug, stateChangeResult.ToString());

			query.UpdateStatesToClosed(stateChangeResult.ExternalId);
		}

		#endregion

		#region IClearQuestReader Members

		public IList<Defect> GetDefects()
		{
            return query.GetWaitingDefects();
		}

		#endregion
	}
}