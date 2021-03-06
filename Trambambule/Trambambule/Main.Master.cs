﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trambambule
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            int userId = 0;
            if (!Page.IsPostBack && int.TryParse(Request.QueryString["userId"], out userId))
            {
                Player player = DataAccess.GetPlayer(userId);
                if (player != null) Session["UserBasicStatsPlayer"] = player;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = SiteMap.CurrentNode.Title;
        }
    }
}