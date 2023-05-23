using ClassLibTeam10.Business.Entities;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        List<Faction>factionList= new List<Faction>();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            RestService restService = new RestService();
            string factions = await restService.getFactions();
            string[] factionsArray = factions.Split('{');
            for(int i = 1; i < factionsArray.Length; i++)
            {
                string[] firstSplit = factionsArray[i].Split('"');

                Faction faction = new Faction();
                faction.Race = firstSplit[5];
                faction.FactionName= firstSplit[9];
                faction.FactionLeader= firstSplit[13];
                faction.FactionStronghold = firstSplit[17];


                factionList.Add(faction);
            }
            listViewApp.ItemsSource = factionList;

        }
    }
}