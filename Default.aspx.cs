﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Affairs_App___IT_MONARCHS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void individualBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("OptionsForm.aspx");//Moves to the booking page.
        }

        protected void employeeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeLogin.aspx");
        }

        protected void organisationBtn_Click1(object sender, EventArgs e)
        {
            Response.Redirect("OrganizationLogin.aspx");
        }
    }
}