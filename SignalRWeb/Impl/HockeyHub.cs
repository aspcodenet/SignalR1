//(C) Stefan Holmberg 2013
// http://stefanholmberg.com
//MIT license - use however you'd like...



using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRWeb.Impl
{
    public class HockeyHub : Hub
    {
        //server
        public void Join(string groupName)
        {
            Groups.Add(Context.ConnectionId, groupName);
        }


    }
}