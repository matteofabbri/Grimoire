/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2011 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace HardwareProviders
{
    public abstract class Hardware
    {
        private readonly List<Sensor> active = new List<Sensor>();

        [SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
        static Hardware()
        {
            EnsureHook();
        }

        protected static void EnsureHook()
        {
            Ring0.Open();
            Opcode.Open();

            AppDomain.CurrentDomain.DomainUnload += (sender, args) =>
            {
                Opcode.Close();
                Ring0.Close();
            };
        }

        protected Hardware(string name)
        {
            Name = name;
        }

        protected Hardware(string name, string identifier)
        {
            Identifier = identifier;
            Name = name;
        }

        public string Name { get; protected set; }

        public string Identifier { get; protected set; }

        public abstract void Update();

        public void ActivateSensor(Sensor sensor)
        {
            active.Add(sensor);
        }

        public void DeactivateSensor(Sensor sensor)
        {
            active.Remove(sensor);
        }
    }
}