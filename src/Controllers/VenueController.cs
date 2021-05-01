using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HeadlessCreator.Models.ViewModels;
using Kentico.Kontent.Delivery.Abstractions;
using HeadlessCreator.Models.ContentTypes;
using Kentico.Kontent.Delivery.Urls.QueryParameters;
using Kentico.Kontent.Delivery.Urls.QueryParameters.Filters;

namespace HeadlessCreator.Controllers
{
    public class VenueController : Controller
    {
        private readonly ILogger<VenueController> _logger;
        protected IDeliveryClient _client { get; }

        public VenueController(IDeliveryClient deliveryClient, ILogger<VenueController> logger)
        {
            _logger = logger;
            _client = deliveryClient;
        }

        public async Task<IActionResult> Detail(string venueCodeName)
        {
            var model = new VenueViewModel();

            var venue = await _client.GetItemAsync<Venue>(venueCodeName);

            model.Venue = venue.Item;

            var upcomingEvents = await _client.GetItemsAsync<Event>(
                new AnyFilter($"elements.{Event.VenueCodename}", venue.Item.System.Codename),
                new OrderParameter($"elements.{Event.DateCodename}", SortOrder.Ascending)
            );

            model.UpcomingEvents = upcomingEvents.Items;

            return View(model);
        }
    }
}
