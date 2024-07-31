using System.Security.Cryptography.X509Certificates;
using Taskplayer.LogicItems;

namespace Taskplayer.Views;

public partial class AllTasksView : ContentPage
{
    private List<Playtask> _playtaskList;
	public AllTasksView()
    {
        _playtaskList = new List<Playtask>();
        InitializeComponent();
	}

    public void AddPlaytaskToList(Playtask playtask)
    {
        this._playtaskList.Add(playtask);
    }

    public void ClearPlaytastList()
    {
        this._playtaskList.Clear();
    }

    public Playtask GetPlaytaskById(int id)
    {
        for (int i = 0; i < this._playtaskList.Count; i++)
        {
            if id = _playtaskList[i].Id{
                return this._playtaskList[i];
            }
        }
    }

    private async void CreateNewBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TaskCreationView());
    }
}