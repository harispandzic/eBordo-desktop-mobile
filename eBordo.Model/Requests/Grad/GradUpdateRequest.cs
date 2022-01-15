using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Grad
{
    public class GradUpdateRequest
    {
        [MinLength(2)]
        public string nazivGrada { get; set; }
    }
}
