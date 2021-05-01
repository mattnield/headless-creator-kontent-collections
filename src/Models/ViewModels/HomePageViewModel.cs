using HeadlessCreator.Models.ContentTypes;
using System.Collections.Generic;

namespace HeadlessCreator.Models.ViewModels{
    public class HomePageViewModel{
        public IEnumerable<Event> LatestEvents{get;set;} = new List<Event>();
    }
}