using BroadwayAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly EfContext _context;
        public RegisterService(EfContext context)
        {
            _context = context;
        }
        public async Task RegisterAsync(ApplicationUser model)
        {

            await _context.ApplicationUser.AddAsync(model);
            _context.SaveChanges();
        }

        
    }
}
