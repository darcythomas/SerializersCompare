﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSerializers
{
    public class Results
    {
        public string serName { get; set; }
        public int sizeBytes { get; set; }
        public bool success { get; set; }
        public List<ResultColumnEntry> resultColumn { get; set; }

        // debug
        public string orignalObjectAsJson { get; set; } // stored as JSON for human visualization
        //This is the original object => serialized => deserialized. Should again match original object if all went well!
        public string testObjectAsJson { get; set; } // stored as JSON for human visualization
    }

    public class ResultColumnEntry
    {
        public TimeSpan time { get; set; }
        public int iteration { get; set; }
    }
}