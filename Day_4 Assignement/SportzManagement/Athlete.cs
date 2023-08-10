namespace SportzManagement
{
    internal class Athlete
    {
        public int athleteId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string sport { get; set; }
        public string dateTime { get; set; }

        public Athlete()
        {

        }
        public Athlete(int athleteId, string firstName, string lastName, int age, string sport, string dateTime)
        {
            this.athleteId = athleteId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.sport = sport;
            this.dateTime = dateTime;

        }

        public override string ToString()
        {
            
            return $"Id:{athleteId}   Name:{firstName} {lastName}   Age:{age}   Sport:{sport}  Date:{dateTime}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                Athlete other = obj as Athlete;
                if (this.athleteId == other.athleteId)
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return athleteId;
        }

    }
}
