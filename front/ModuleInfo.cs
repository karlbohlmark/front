﻿using System.Collections.Generic;

namespace front
{
    public class ModuleInfo
    {
        public ModuleInfo()
        {
            Dependencies = new List<string>();
        }

        public string Name { get; set; }
        public List<string> Dependencies { get; set; }
        public string Content { get; set; }
    }
}