﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public sealed class AchievementFirstArray
    {
        [JsonProperty("charname")]
        public string Name { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("guildname")]
        public string Guildname { get; set; }

        [JsonProperty("name")]
        public string AName { get; set; }

        [JsonProperty("description")]
        public string ADescription { get; set; }

        [JsonProperty("point")]
        public int APoint { get; set; }

        [JsonProperty("reward")]
        public string AReward { get; set; }

        [JsonProperty("timestamp")]
        public int ATimestamp { get; set; }
    }
}