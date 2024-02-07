// This Source Code Form is subject to the terms of the Mozilla Public 
// License, v. 2.0. If a copy of the MPL was not distributed with this 
// file, You can obtain one at http://mozilla.org/MPL/2.0/. 
// Copyright (C) 2016-2017 Sebastian Grams <https://github.com/sebastian-dev> 
// Copyright (C) 2016-2017 Aqua Computer <https://github.com/aquacomputer, info@aqua-computer.de> 

using System.Collections.Generic;

namespace HardwareProviders.CPU.Ryzen
{
    public class RyzenNumaNode
    {
        private readonly AmdCpu17 _cpu;

        public RyzenNumaNode(AmdCpu17 cpu, int id)
        {
            Cores = new List<RyzenCore>();
            NodeId = id;
            _cpu = cpu;
        }

        public int NodeId { get; }
        public List<RyzenCore> Cores { get; }

        public void AppendThread(CpuId thread, int core_id)
        {
            RyzenCore ryzenCore = null;
            foreach (var c in Cores)
                if (c.CoreId == core_id)
                    ryzenCore = c;
            if (ryzenCore == null)
            {
                ryzenCore = new RyzenCore(_cpu, core_id);
                Cores.Add(ryzenCore);
            }

            if (thread != null)
                ryzenCore.Threads.Add(thread);
        }

        #region UpdateSensors

        public void UpdateSensors()
        {
        }

        #endregion
    }
}