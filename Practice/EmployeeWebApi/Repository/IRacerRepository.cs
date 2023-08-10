using EmployeeWebApi.Model;

namespace EmployeeWebApi.Repository
{
    public interface IRacerRepository
    {
        List<Racer> GetRacers();
        Racer GetRacer(int id);
        Racer AddRacer(Racer racer);
        Racer UpdateRacer(Racer racer);
        bool DeleteRacer(Racer racer);
    }
}
