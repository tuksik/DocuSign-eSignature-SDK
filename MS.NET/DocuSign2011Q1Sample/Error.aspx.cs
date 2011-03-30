﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocuSign2011Q1Sample
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["errorMessage"] != null)
            {
                lblErrorMessage.Text = (string)Session["errorMessage"];
            }
            else
            {
                lblErrorMessage.Text = "No error message in session. ?";

            }
        }
    }
}