﻿using System;

namespace Portfolio.Api.DTO
{
    public class TechnologyVersionDto
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string MajorBuild { get; set; }
        public DateTime releaseDate { get; set; }
    }
}