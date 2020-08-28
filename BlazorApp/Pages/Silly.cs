using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class Silly
    {
        [Parameter] public string Name { get; set; }
        protected override async Task OnInitializedAsync()
        {
            
        }
    }
}
