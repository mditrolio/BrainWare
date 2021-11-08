namespace BrainWare.Web.Pages
{
    using System.Collections.Generic;

    using Application.Services;

    using Domain.Models;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;

    public class IndexModel : PageModel
    {
        public IndexModel(IOrderService orderService, ILogger<IndexModel> logger)
        {
            OrderService = orderService;
            Logger = logger;
        }

        [BindProperty]
        public IEnumerable<Order> Orders { get; set; }

        private ILogger<IndexModel> Logger { get; }

        private IOrderService OrderService { get; }

        public void OnGet()
        {
            Orders = OrderService.GetOrders();
        }
    }
}