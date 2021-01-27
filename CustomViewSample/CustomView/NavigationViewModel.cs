using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomView
{
    public class NavigationViewModel
    {
        public NavigationViewModel()
        {
            Contents = new List<MailModel>();

            Contents.Add(new MailModel() { Name = "Home" });
            Contents.Add(new MailModel() { Name = "Profile" });
            Contents.Add(new MailModel() { Name = "Inbox" });
            Contents.Add(new MailModel() { Name = "Outbox" });
            Contents.Add(new MailModel() { Name = "Sent" });
            Contents.Add(new MailModel() { Name = "Trash" });
        }

        public List<MailModel> Contents { get; set; }
    }
}
