using Elettra.AccessControl;
using Elettra.Alerts;
using Elettra.Goals;
using Elettra.Messages;
using Elettra.Staff;
using Elettra.Tasks;
using Netfluid;
using System.Collections.Generic;

namespace Elettra
{
    public class CRM
    {
        public StaffMember User { get; private set; }

        public PreviewList<Message> Messages { get; private set; }
        public PreviewList<Alert> Alerts { get; private set; }
        public PreviewList<Task> Tasks { get; private set; }
        public PreviewList<Goal> Goals { get; private set; }

        public IEnumerable<Country> Countries
        {
            get
            {
                return Country.All;
            }
        }

        public IEnumerable<StaffMember> Staff
        {
            get
            {
                return StaffManager.All;
            }
        }

        public SidebarMenu SidebarMenu { get; private set; }

        public UserStat UserStat { get; private set; }

        public string Footer { get; private set; }

        public static CRM Instance(Context cnt)
        {
            var user = cnt.Session<StaffAccess>("user");
            var member = user.Member;

            return new CRM
            {
                User= member,
                SidebarMenu = SidebarMenu.Instance,
                Messages = new PreviewList<Message>(MessageManager.To(member)),
                Alerts = new PreviewList<Alert>(AlertManager.To(member)),
                Tasks = new PreviewList<Task>(TaskManager.To(member)),
                Goals = new PreviewList<Goal>(GoalManager.List),
                Footer = "Copyright Netfluid 2016"
            };
        }
    }
}
