using BlazorNetAzure2.Models;

namespace BlazorNetAzure2.Pages
{
    public partial class Demo3
    {

        public List<int> MesNombres { get; set; } = new List<int>() { 213, 546, 143, 87, 1, 8, 23 };

        public List<User> Users { get; set; } = new List<User> 
        { new User()
        {
            Age = 1,
            Email = "mineur@mineur",
            IsWoman = false,
            Name = "Mineur"
        },
            new User()
        {
            Age = 20,
            Email = "femme@femme",
            IsWoman = true,
            Name = "Femme"
        },
            new User()
        {
            Age = 25,
            Email = "Homme@Homme",
            IsWoman = false,
            Name = "Homme"
        }
        };
    }
}
