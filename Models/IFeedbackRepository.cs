using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetAllFeedbacks();
        void AddFeedback(Feedback feedback);
    }
}
