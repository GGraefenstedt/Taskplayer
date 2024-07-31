using System.Diagnostics;
using Taskplayer.LogicItems;
namespace Taskplayer.Views;

public partial class TaskCreationView : ContentPage
{
	public TaskCreationView()
	{
		InitializeComponent();
	}

    private void AddEntryButton_Clicked(object sender, EventArgs e)
    {
        //Playtask temp = new Playtask(TitleEntry.Text, PointsEntry.Text, DescriptionEntry.Text, DateTime.Now, DateDueEntry.Text);
        Playtask temp = new Playtask(TitleEntry.Text, 0, DescriptionEntry.Text, DateTime.Now, DateTime.MaxValue);
		Debug.WriteLine(temp.toString());
    }
}