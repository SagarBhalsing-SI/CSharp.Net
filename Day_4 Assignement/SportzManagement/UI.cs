namespace SportzManagement
{
    internal class UI
    {
        public void AthleteUI()
        {
            AthleteManagement am = new AthleteManagement();
            string c;

            do
            {
                Console.WriteLine("-----------------Athlete------------------");
                Console.WriteLine("1.Resiter Athlete\n" +
                                  "2.Get Athlete By Id\n" +
                                  "3.Get Athlete By Sport\n" +
                                  "4.Update Athlete\n" +
                                  "5.Remove Athlete\n" +
                                  "6.View Athletes");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            am.RegisterAthlete();
                            break;
                        }
                    case 2:
                        {
                            am.GetAthleteById();
                            break;
                        }
                    case 3:
                        {
                            am.GetAthleteBySport();
                            break;
                        }
                    case 4:
                        {
                            am.UpdateAthlete();
                            break;
                        }
                    case 5:
                        {
                            am.RemoveAthlete();
                            break;
                        }
                    case 6:
                        {
                            am.ViewAthlete();
                            break;
                        }
                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to continue with Athlete Menu Y/N:");
                c = Console.ReadLine();
            } while (c == "Y");





        }
        public void EventUI()
        {
            EventManagement em= new EventManagement();
            string c;

            do
            {
                Console.WriteLine("-----------------Event------------------");
                Console.WriteLine("1.Resiter Event\n" +
                                  "2.Update Event\n" +
                                  "3.Remove Event\n" +
                                  "4.Search Event By Type\n"+
                                  "5.View Event");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            em.RegisterEvent();
                            break;
                        }
                    case 2:
                        {
                            em.UpdateEvent();
                            break;
                        }
                    case 3:
                        {
                            em.RemoveEvent();
                            break;
                        }
                    case 4:
                        {
                            em.SearchEventByType();
                            break;
                        }
                    case 5:
                        {
                            em.ViewEvent();
                            break;
                        }
              
                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to continue with Event Menu Y/N:");
                c = Console.ReadLine();
            } while (c == "Y");





        }

        public void PerformanceTrackingUI()
        {
            PerformanceTracking pt = new PerformanceTracking();
            string c;

            do
            {
                Console.WriteLine("-----------------Performance------------------");
                Console.WriteLine("1.Record Athlete Performance\n" +
                                  "2.Get Performance By Athlete Id and Event Id\n" +
                                  "3.View Performance");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            pt.RecordAthletePerformance();
                            break;
                        }
                    case 2:
                        {
                            pt.GetPerformanceByAtheleteIdAndEventId();
                            break;
                        }
                    case 3:
                        {
                            pt.ViewPerformance();
                            break;
                        }
        
                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to continue with Performance Menu Y/N:");
                c = Console.ReadLine();
            } while (c == "Y");


        }
    }
    }


