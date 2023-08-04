using BlazorNetAzure2.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorNetAzure2.Shared
{
    public partial class VoitureVignette
    {
        [Parameter]
        public Voiture Voit { get; set; }

        [Inject]
        NavigationManager nvm { get; set; }

        void OnCarClick(int id)
        {
            nvm.NavigateTo($"/exo/voiture/{id}");
        }

    }
}
