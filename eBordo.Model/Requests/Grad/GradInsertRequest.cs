using eBordo.Model.Requests.Drzava;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBordo.Model.Requests.Grad
{
    public class GradInsertRequest
    {
        public string nazivGrada { get; set; }
        public int drzavaId { get; set; }
    }
}
