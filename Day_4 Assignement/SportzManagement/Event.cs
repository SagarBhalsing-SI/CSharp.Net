using System;

namespace SportzManagement
{
    internal class Event
    {
        public int eventId { get; set; }
        public string eventName { get; set; }
        public string eventType { get; set; }
        public string eventDate { get; set; }

        public Event()
        {

        }
        public Event(int eventId, string eventName, string eventType, string eventDate)
        {
            this.eventId = eventId;
            this.eventName = eventName;
            this.eventType = eventType;
            this.eventDate = eventDate;

        }
        public override string ToString()
        {

            return $"Event Id: {eventId}   Event: {eventName}   Event Type: {eventType}   Event Date: {eventDate}";
        }
    }
}
