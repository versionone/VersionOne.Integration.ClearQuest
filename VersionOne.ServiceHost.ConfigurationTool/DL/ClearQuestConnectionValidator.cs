using System;
using IBM.ClearQuest.Interop;
using VersionOne.ServiceHost.ConfigurationTool.Entities;

namespace VersionOne.ServiceHost.ConfigurationTool.DL {
    public class ClearQuestConnectionValidator : IConnectionValidator {
        private const int SessionTypePrivate = 2;
        private readonly ClearQuestServiceEntity entity;

        public ClearQuestConnectionValidator(ClearQuestServiceEntity entity) {
            this.entity = entity;
        }

        public bool Validate() {
            try {
                IOAdSession session = new SessionClass();
                session.UserLogon(entity.UserName, entity.Password, entity.DataBase, SessionTypePrivate, entity.ConnectionName);
                session.SignOff();
                return true;
            } catch(Exception) {
                return false;
            }
        }
    }
}