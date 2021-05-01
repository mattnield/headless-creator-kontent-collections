using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HeadlessCreator.Models.ViewModels;
using Kentico.Kontent.Delivery.Abstractions;
using HeadlessCreator.Models.ContentTypes;
using Kentico.Kontent.Delivery.Urls.QueryParameters;

namespace HeadlessCreator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected IDeliveryClient _client { get; }

        public HomeController(IDeliveryClient deliveryClient, ILogger<HomeController> logger)
        {
            _logger = logger;
            _client = deliveryClient;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel();
            var latestEvents = await _client.GetItemsAsync<Event>(
                new OrderParameter($"elements.{Event.DateCodename}", SortOrder.Ascending),
                new LimitParameter(3)
            );

            model.LatestEvents = latestEvents.Items;

            return View(model);
        }
    }
}
