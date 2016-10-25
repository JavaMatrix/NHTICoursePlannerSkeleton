using System.Windows;

namespace NHTIYearPlannerSkeleton
{
    /// <summary>
    /// Interaction logic for FormNHTIYearPlanner.xaml
    /// </summary>
    public partial class FormNHTIPlanner : Window
    {
        public FormNHTIPlanner()
        {
            InitializeComponent();
        }

        private void btnAddSemester_Click(object sender, RoutedEventArgs e)
        {
            SemesterEntry semester = new SemesterEntry() { Margin = new Thickness(10, 64, 0, 0), MyParent = pnlSemesters };
            pnlSemesters.Children.Insert(pnlSemesters.Children.Count - 1, semester);
            semester.expMainPanel.IsExpanded = true;
        }
    }
}
