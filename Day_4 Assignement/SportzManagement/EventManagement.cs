using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzManagement
{
    internal class EventManagement
    {
        UserInterface ui = new UserInterface();
        List<Event> EventList = new List<Event>()
        {
            new Event(1001,"Ignitra","Cricket","13-01-2021"),
            new Event(1002,"SI events","Table Tennis","14-09-2022"),
            new Event(1003,"NBA","BasketBall","12-03-2020"),
            new Event(1004,"Chess Championship","Chess","01-12-2022"),
        };
        public void RegisterEvent()
        {
            Event e1 = new Event(ui.getId(),ui.getEventName(),ui.getEventType(),ui.getEventDate());
            EventList.Add(e1);  
        }

        public void ViewEvent()
        {
            Console.WriteLine("---------------------------------------Event List-------------------------------------------");
            Console.WriteLine("==============================================================================================");
            foreach (Event e in EventList)
            {
                Console.WriteLine($"Event Id: {e.eventId}   Event: {e.eventName}   Event Type: {e.eventType}   Event Date: {e.eventDate}");
            }
        }

        public void UpdateEvent()
        {
            int id = ui.getId();
            Event e = EventList.Find(e => e.eventId.Equals(id));
            e.eventName = ui.getInputEventName();
            e.eventType = ui.getInputEventType();
            e.eventDate = ui.getInputEventDate();
            ui.UpdateSuccessfully();
        }

        public void RemoveEvent()
        {
            int id = ui.getId();
            Event e = EventList.Find(e => e.eventId.Equals(id));
            EventList.Remove(e); 
        }

        public void SearchEventByType()
        {
            string type = ui.getType();
            var result = from e in EventList where e.eventType == type select e;
            foreach (Event e in result)
            {
                Console.WriteLine(e);
            }
        }


    }
}
