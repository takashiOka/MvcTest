﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcTest.Models;

namespace MvcTest.Controllers
{
    public class BeginController : Controller
    {
        private MvcBasicContext db = new MvcBasicContext();

        public ActionResult List()
        {
            return View(db.Members);
        }
	}
}