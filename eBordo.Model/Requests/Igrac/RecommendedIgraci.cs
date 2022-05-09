using System;
using System.Collections.Generic;
using System.Text;

namespace eBordo.Model.Requests.Igrac
{
    public class RecommendedIgraci
    {
        public int igracId { get; set; }
        public List<int> selectedIds { get; set; }
    }
}
