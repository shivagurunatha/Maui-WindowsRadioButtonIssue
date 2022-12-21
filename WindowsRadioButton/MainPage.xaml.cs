using System.Collections.ObjectModel;
using System.Reflection;
using System.Xml.Linq;

namespace WindowsRadioButton;

public partial class MainPage : ContentPage
{
    private ObservableCollection<RadioButtonItem> groupExpandAndCollapseSegments;

    public ObservableCollection<RadioButtonItem> GroupExpandAndCollapseSegments
    {
        get { return groupExpandAndCollapseSegments; }
        set
        {
            groupExpandAndCollapseSegments = value;
            OnPropertyChanged("GroupExpandAndCollapseSegments");
        }
    }

    public MainPage()
    {
        this.BindingContext = this;
		InitializeComponent();
        GroupExpandAndCollapseSegments = new ObservableCollection<RadioButtonItem>
        {
            new RadioButtonItem { Text = "Expand", IsChecked = true },
            new RadioButtonItem { Text = "Collapse", IsChecked = false }
        };
    }	
    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }
}

public class RadioButtonItem
{
    public string Text { get; set; }

    public bool IsChecked { get; set; }
}

