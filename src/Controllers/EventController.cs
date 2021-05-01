using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HeadlessCreator.Models.ViewModels;
using Kentico.Kontent.Delivery.Abstractions;

namespace HeadlessCreator.Controllers
{
    public class EventController : Controller
    {
        private readonly ILogger<EventController> _logger;
        protected IDeliveryClient _client { get; }

        public EventController(IDeliveryClient deliveryClient, ILogger<EventController> logger)
        {
            _logger = logger;
            _client = deliveryClient;
        }

        public async Task<IActionResult> Detail(string eventCodename)
        {
            var model = new EventViewModel();

            var ev = await _client.GetItemAsync<HeadlessCreator.Models.ContentTypes.Event>(eventCodename);

            model.Event = ev.Item;

            return View(model);
        }
    }
}
