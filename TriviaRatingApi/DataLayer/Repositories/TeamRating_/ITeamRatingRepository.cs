﻿using TriviaRatingApi.DataLayer.Relationships;

namespace TriviaRatingApi.DataLayer.Repositories.TeamRating_
{
    public interface ITeamRatingRepository
    {
        Task<List<TeamRating>> GetAll();
        Task<List<TeamRating>> GetByRating(int min, int max);
        Task<TeamRating> GetByTeam(int id);
        Task<bool> Update(TeamRating tr);
        Task<int> Add(TeamRating tr);
    }
}
