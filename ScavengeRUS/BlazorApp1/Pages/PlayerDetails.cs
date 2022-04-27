using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages

{
    public class PlayerDetails : ComponentBase
    {
        [Parameter]
        public string Display_Name { get; set; }
    }
}
