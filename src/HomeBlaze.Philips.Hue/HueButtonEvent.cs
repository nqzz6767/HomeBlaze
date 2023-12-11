﻿using HomeBlaze.Abstractions.Inputs;
using HomeBlaze.Abstractions.Messages;
using HueApi.Models;

namespace HomeBlaze.Philips.Hue
{
    public class HueButtonEvent : IEvent
    {
        public required string ButtonId { get; init; }

        public required ButtonState ButtonState { get; init; }
    }
}
