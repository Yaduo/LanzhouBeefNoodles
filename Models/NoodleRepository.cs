using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class NoodleRepository : INoodleRepository
    {
        private readonly AppDbContext _context;

        public NoodleRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _context.Noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return _context.Noodles.FirstOrDefault(n => n.Id == id);
        }
    }
}
