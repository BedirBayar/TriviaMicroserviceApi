﻿using Microsoft.EntityFrameworkCore;
using TriviaContestApi.DataAccess;
using TriviaContestApi.DataAccess.Entities;
using TriviaContestApi.DataAccess.Relationships;

namespace TriviaContestApi.DataLayer.Repositories.ContestTeam_
{
    public class ContestTeamRepository :IContestTeamRepository
    {
        private readonly IContestDbContext _context;
        public ContestTeamRepository(IContestDbContext context) { 
            _context = context;
        }

        public async Task<int> Add(ContestTeam ct)
        {
            _context.ContestTeams.Add(ct);
            await _context.SaveChangesAsync();
            return ct.Id;
        }

        public async Task<List<int>> AddRange(List<ContestTeam> cts)
        {
            _context.ContestTeams.AddRange(cts);
            await _context.SaveChangesAsync();
            return cts.Select(c=>c.Id).ToList();
        }

        public async Task<List<ContestTeam>> GetByContest(int contestId)
        {
           return await _context.ContestTeams.Where(t=>t.ContestId == contestId).ToListAsync();
        }

        public async Task<ContestTeam> GetById(int id)
        {
            return await _context.ContestTeams.FindAsync(id);
        }

        public async Task<List<ContestTeam>> GetByTeam(int teamId)
        {
            return await _context.ContestTeams.Where(t => t.TeamId == teamId).ToListAsync();
        }
    }
}
