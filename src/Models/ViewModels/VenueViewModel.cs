using HeadlessCreator.Models.ContentTypes;
using System.Collections.Generic;

namespace HeadlessCreator.Models.ViewModels{
    public class VenueViewModel{
        public Venue Venue{get;set;} = null;
        public IEnumerable<Event> UpcomingEvents{get;set;} = new List<Event>();
    }
}