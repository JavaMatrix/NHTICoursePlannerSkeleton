using System.Windows;

namespace NHTIYearPlannerSkeleton
{
    /// <summary>
    /// Interaction logic for FormNHTIYearPlanner.xaml
    /// </summary>
    public partial class FormNHTIYearPlanner : Window
    {
        public FormNHTIYearPlanner()
        {
            InitializeComponent();
        }

        private void btnAddSemester_Click(object sender, RoutedEventArgs e)
        {
            YearEntry semester = new YearEntry() { Margin = new Thickness(10, 64, 0, 0), Parent = pnlSemesters };
            pnlSemesters.Children.Insert(pnlSemesters.Children.Count - 1, semester);
            semester.expMainPanel.IsExpanded = true;
        }
    }
}
