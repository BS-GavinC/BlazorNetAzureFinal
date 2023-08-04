using BlazorNetAzure2.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorNetAzure2.Pages
{
    public partial class Exo2
    {

        public ContactForm contactForm { get; set; } = new ContactForm();

        public bool FormValid { get; set; } = false;

        [Inject]
        public IJSRuntime js { get; set; }

        void Invalid()
        {
            Console.WriteLine("C'est invalide");
            js.InvokeVoidAsync("alert", "Veuillez verifier votre forms !");
        }

        void Valid()
        {
            Console.WriteLine("C'est valide");

            FormValid = true;
        }

    }
}
