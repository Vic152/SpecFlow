﻿using System;
using System.Collections.Generic;

namespace SpecFlow.ExternalData.SpecFlowPlugin.DataSource
{
    public class DataRecord
    {
        public IDictionary<string, DataValue> Fields { get; } = new Dictionary<string, DataValue>();

        public DataRecord()
        {
            
        }

        public DataRecord(Dictionary<string, string> fields)
        {
            foreach (var field in fields)
            {
                Fields.Add(field.Key, new DataValue(field.Value));
            }
        }
    }
}
