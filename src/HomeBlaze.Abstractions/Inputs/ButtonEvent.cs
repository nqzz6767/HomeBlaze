﻿using Namotion.Devices.Abstractions.Messages;

namespace HomeBlaze.Abstractions.Inputs
{
    public class ButtonEvent : IEvent
    {
        public required object Source { get; init; }

        public required ButtonState ButtonState { get; init; }
    }
}
