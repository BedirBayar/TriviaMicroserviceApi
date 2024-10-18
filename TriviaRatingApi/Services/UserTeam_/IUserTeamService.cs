﻿using TriviaRatingApi.DTOs;
using TriviaRatingApi.Models;

namespace TriviaRatingApi.Services.UserTeam_
{
    public interface IUserTeamService
    {
        Task<BaseResponse<List<UserTeamDto>>> GetTeamUsers(int teamId);
        Task<BaseResponse<List<UserTeamDto>>> GetUserTeams(int userId);
        Task<BaseResponse<int>> AddUserToTeam(UserTeamDto request);
        Task<BaseResponse<bool>> RemoveUserFromTeam(UserTeamDto request);
        Task<BaseResponse<bool>> DissolveTeam(int teamId);

    }
}
