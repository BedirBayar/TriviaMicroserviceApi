﻿namespace TriviaRatingApi.DTOs
{
    public class TeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slogan { get; set; }
        public string Image { get; set; }
        public int LeaderId { get; set; }
        public bool IsBanned { get; set; }
        public bool IsActive { get; set; }
        public DateTime BannedUntil { get; set; }
        public string BanReason { get; set; }
    }
}
