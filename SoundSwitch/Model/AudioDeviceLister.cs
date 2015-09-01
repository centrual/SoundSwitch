﻿/********************************************************************
* Copyright (C) 2015 Antoine Aflalo
* 
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or (at your option) any later version.
* 
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
********************************************************************/

using System.Collections.Generic;
using AudioEndPoint;
using AudioEndPointControllerWrapper;

namespace SoundSwitch.Model
{
    public class AudioDeviceLister : IAudioDeviceLister
    {
        private readonly DeviceState _state;

        public AudioDeviceLister(DeviceState state)
        {
            _state = state;
        }

        /// <summary>
        ///     Get the playback device in the set state
        /// </summary>
        /// <returns></returns>
        public ICollection<IAudioDevice> GetPlaybackDevices()
        {
            return AudioController.GetPlaybackDevices(_state);
        }

        /// <summary>
        ///     Get the recording device in the set state
        /// </summary>
        /// <returns></returns>
        public ICollection<IAudioDevice> GetRecordingDevices()
        {
            return AudioController.GetRecordingDevices(_state);
        }
    }
}