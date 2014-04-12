using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LSWebAPI.Models;
namespace LSWebAPI.Controllers
{
    public class MenuController : ApiController
    {
        root[] menu = new root[]
        {
            new root { 
                id = "1", 
                text = "menu1", 
                iconCls = "menu_admin", 
                parent_id = null,  
                className = null, 
                leaf = false, 
                items = new items[] { 
                    new items { id = "2", text = "menu11", iconCls = "menu_groups", parent_id = "1",  className = "panel", leaf = true },
                    new items { id = "3", text = "menu12", iconCls = "menu_groups", parent_id = "1",  className = "panel", leaf = true } 
                } 
            }
        };

        public IEnumerable<root> Get(int id)
        {
            return menu;
        }
    }
}
