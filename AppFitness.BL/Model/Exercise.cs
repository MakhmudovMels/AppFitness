using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFitness.BL.Model
{
    [Serializable]
    public class Exercise
    {
        public int Id { get; set; }

        public DateTime Start { get; set; }

        public DateTime Finish { get; set; }

        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }

        public Exercise() { }

        public Exercise(DateTime start, DateTime finish, Activity activity, User user)
        {
            // Проверка

            Start = start;
            Finish = finish;
            this.Activity = activity;
            this.user = user;
        }
    }
}
