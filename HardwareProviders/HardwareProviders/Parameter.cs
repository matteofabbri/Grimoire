/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2010 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

namespace HardwareProviders
{
    public class Parameter
    {
        public Parameter(string name, string description, float defaultValue)
        {
            Name = name;
            Description = description;
            Value = defaultValue;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Value { get; set; }
    }
}