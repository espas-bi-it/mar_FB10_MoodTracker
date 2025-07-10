using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;

namespace mar_FB10_MoodTracker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public ObservableCollection<Course> Courses { get; set; } = new();
        public ObservableCollection<Course> CoursesWithDetails { get; set; } = new();
        public ICommand ToggleDetailsCommand { get; }

        public MainPage()
        {
            InitializeComponent();
            ToggleDetailsCommand = new Command<Course>(ToggleDetails);
            LoadCourses();
            BindingContext = this;
        }

        private async void LoadCourses()
        {
            var allowedNames = new[] { "Malworkshop", "Abenteuerwanderung", "Schwimmkurs", "Töpferkurs" };

            using var stream = await FileSystem.OpenAppPackageFileAsync("MoodTrackerDaten.json");
            using var reader = new StreamReader(stream);
            var json = await reader.ReadToEndAsync();

            var doc = JsonDocument.Parse(json);
            var courses = doc.RootElement.GetProperty("courses");

            foreach (var course in courses.EnumerateArray())
            {
                var name = course.GetProperty("name").GetString();
                if (allowedNames.Contains(name))
                {
                    var c = new Course
                    {
                        Name = name,
                        Description = course.GetProperty("description").GetString(),
                        Location = course.GetProperty("location").GetString(),
                        Date = course.GetProperty("date").GetString(),
                        Time = course.GetProperty("time").GetString()
                    };
                    Courses.Add(c);
                    CoursesWithDetails.Add(c);
                }
            }
        }

        private void ToggleDetails(Course course)
        {
            if (course != null)
                course.ShowDetails = !course.ShowDetails;
        }
    }
}
