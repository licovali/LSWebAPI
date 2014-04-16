using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using LSWebAPI.Models;

namespace LSWebAPI.Controllers
{
    [Authorize]
    public class MenuController : ApiController
    {
        root[] menu = new root[]
        {
            new root { 
                id = "0", 
                text = "<i class=\"fa fa-shield\"></i>" + " Security", 
                iconCls = "", 
                parent_id = null,  
                className = null, 
                leaf = false, 
                items = new items[] { 
                    new items { id = "1", text = "<i class=\"fa fa-users\"></i> " + "Groups", iconCls = "", parent_id = "1",  className = "panel", leaf = true },
                    new items { id = "2", text = "<i class=\"fa fa-user\"></i> " + "Users", iconCls = "", parent_id = "1",  className = "panel", leaf = true } 
                } 
            }
        };

        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        public IEnumerable<root> Get()
        {
            string _user = Request.GetOwinContext().Authentication.User.Identity.Name;
            return menu;
        }
    }
}
