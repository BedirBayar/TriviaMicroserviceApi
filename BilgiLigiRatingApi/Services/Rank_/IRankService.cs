﻿using BilgiLigiRatingApi.DTOs;
using BilgiLigiRatingApi.Models;

namespace BilgiLigiRatingApi.Services.Rank_
{
    public interface IRankService
    {
        Task<BaseResponse<List<RankDto>>> GetAll();
        Task<BaseResponse<List<RankDto>>> GetAllActive();
        Task<BaseResponse<List<RankDto>>> GetUserRanks();
        Task<BaseResponse<List<RankDto>>> GetTeamRanks();
        Task<BaseResponse<RankDto>> GetById(int id);
        Task<BaseResponse<int>> Add(RankDto rankDto);
        Task<BaseResponse<bool>> Update(RankDto rankDto);
        Task<BaseResponse<bool>> Archive (int id);
        Task<BaseResponse<bool>> ChangeStatus (int id);
    }
}
