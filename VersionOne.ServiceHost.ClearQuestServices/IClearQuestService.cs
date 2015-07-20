using System;
using System.Collections.Generic;
using System.Text;
using VersionOne.ServiceHost.WorkitemServices;

namespace VersionOne.ServiceHost.ClearQuestServices
{
	internal interface IClearQuestReader
	{
		IList<Defect> GetDefects();
	}

	internal interface IClearQuestUpdater
	{
		void OnDefectCreated(WorkitemCreationResult createdResult);
		void OnDefectStateChange(WorkitemStateChangeResult stateChangeResult);
	}
}
