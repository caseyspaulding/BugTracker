using IssueTracker.Data;
using IssueTracker.Models;
using IssueTracker.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Services
{
    public class BTCompanyInfoService : IBTCompanyInfoService
    {
        private readonly ApplicationDbContext _context;
        
        public BTCompanyInfoService(ApplicationDbContext context) 
        {
            _context = context;
        
        }
        
        public async Task<List<BTUser>> GetAllMembersAsync(int companyId)
        {
            List<BTUser> result = new();

            result = await _context.Users.Where(u => u.CompanyId == companyId).ToListAsync();

            return result;
        }

        public async Task<List<Project>> GetAllProjectsAsync(int companyId)
        {
            List<Project> result = new(); // -- instantiate 

            result = await _context.Projects.Where(p => p.CompanyId == companyId)
                                            .Include(p => p.Members)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t=>t.Comments)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.Attachments)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.DeveloperUser)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.Notifications)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.OwnerUser)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.History)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.TicketStatus)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.TicketPriority)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.TicketType)
                      // --- Query Methods .ThenInclude using link available only after .Include --- //
                                            .Include(p => p.ProjectPriority)
                                            .ToListAsync();
            // ---- .Include eager loads the members, tickets and project priority  ----- ///
            return result;
        }

        public async Task<List<Ticket>> GetAllTicketAsync(int companyId) // calling 
        {
            List<Ticket> result = new();   // What we are returning (A list of Tickets) instantiating
            List<Project> projects = new List<Project>();

            projects = await GetAllProjectsAsync(companyId);    // using companyId

            result = projects.SelectMany(p => p.Tickets).ToList();  // -- extension method of the Link language

            return result;
        }

        public async Task<Company> GetCompanyInfoByIdAsync(int? companyId)
        {
            Company result = new();

            if (companyId != null)
            {
                result = await _context.Companies
                                        .Include(c=>c.Members)
                                        .Include(c=>c.Projects)
                                        .Include(c=>c.Invites)
                                        .FirstOrDefaultAsync(c => c.Id == companyId);
            }
            return result;

        }
    }
}
