﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace NotificadoR
{
    public class TodoItem
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }

        [JsonProperty(PropertyName = "abstract")]
        public string Abstract { get; set; }

    }
}
