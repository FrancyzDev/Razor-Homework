using Razor1.Data;
using Razor1.Interfaces;
using Razor1.Models;
using Microsoft.EntityFrameworkCore;

namespace Razor1.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;

        public PersonRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Persons.ToListAsync();
        }

        public async Task<Person?> GetByIdAsync(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Persons.FindAsync(id);
        }
    }
}