using BlazorNetAzure2.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorNetAzure2.Shared
{
    public partial class ShowUser
    {

        [Parameter]
        public User user { get; set; }

    }
}
