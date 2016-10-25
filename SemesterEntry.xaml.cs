using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NHTIYearPlannerSkeleton
{
    /// <summary>
    /// Interaction logic for YearEntry.xaml
    /// </summary>
    public partial class SemesterEntry : UserControl
    {
        public Panel MyParent { get; set; }

        public SemesterEntry()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pnlCourses.Children.Add(new SemesterCourseEntry() { MyParent = pnlCourses });
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            cbxSemesters.IsEnabled = false;
            txtYear.IsEnabled = false;
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            cbxSemesters.IsEnabled = true;
            txtYear.IsEnabled = true;
        }

        private void thmDrag_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            this.Margin = new Thickness(Math.Max(0, this.Margin.Left + e.HorizontalChange),
                                        Math.Max(0, this.Margin.Top + e.VerticalChange),
                                        0, 0);
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            this.MyParent?.Children.Remove(this);
        }
    }
}
