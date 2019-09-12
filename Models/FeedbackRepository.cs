using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _context;

        public FeedbackRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<Feedback> GetAllFeedbacks()
        {
            return _context.Feedbacks;
        }

        public void AddFeedback(Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();
        }
    }
}
