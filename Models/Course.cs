using System.ComponentModel;

public class Course : INotifyPropertyChanged
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }

    private bool showDetails;
    public bool ShowDetails
    {
        get => showDetails;
        set
        {
            if (showDetails != value)
            {
                showDetails = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ShowDetails)));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}