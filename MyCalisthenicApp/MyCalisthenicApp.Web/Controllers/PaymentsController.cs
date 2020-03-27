﻿namespace MyCalisthenicApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class PaymentsController : BaseController
    {
        public PaymentsController()
        {
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}