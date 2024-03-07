using System;
using System.Collections.Generic;

namespace XML_JSON_dz
{
    [Serializable]
    public class Lots
    {
        public List<Lot> LotsList { get; set; } = new List<Lot>();
    }
}
