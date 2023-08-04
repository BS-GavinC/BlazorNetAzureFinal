using BlazorNetAzure2.FakeData;
using BlazorNetAzure2.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorNetAzure2.Pages
{
    public partial class Demo4
    {
        [Parameter]
        public int id { get; set; }
        public string MaValeur { get; set; } = "Chaine de charactere par defaut";

        public Voiture VoitureForm { get; set; } = new Voiture();

        [Inject]
        public NavigationManager nvm { get; set; }

        protected override Task OnParametersSetAsync()
        {
            if (id != 0)
            {
                VoitureForm = FakeData.FakeData.Voitures.Find(x => x.Id == id);
            }


            return base.OnParametersSetAsync();
        }

        void SubmitDone()
        {
            Console.WriteLine(VoitureForm.ToString());

            if (VoitureForm.Id == 0)
            {
                VoitureForm.Id = FakeData.FakeData.Voitures.Count() + 1;

                FakeData.FakeData.Voitures.Add(VoitureForm);

                
            }
            else
            {

            }

            nvm.NavigateTo("/exo/exo1");
        }
    }
}
