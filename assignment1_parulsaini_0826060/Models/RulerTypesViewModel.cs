using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ImperialRulers.Models
{
    public class RulerTypesViewModel
    {
        public List<Ruler> Rulers { get; set; }
        public SelectList Types { get; set; }
        public string RulerTypes { get; set; }
        public string SearchString { get; set; }
    }
}