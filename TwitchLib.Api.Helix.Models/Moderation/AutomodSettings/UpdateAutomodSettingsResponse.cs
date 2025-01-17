﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.Api.Helix.Models.Moderation.AutomodSettings
{
    public class UpdateAutomodSettingsResponse
    {
        [JsonProperty(PropertyName = "data")]
        public AutomodSettings[] Data { get; protected set; }
    }
}
