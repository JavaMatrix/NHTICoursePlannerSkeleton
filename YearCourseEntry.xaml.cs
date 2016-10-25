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
    /// Interaction logic for YearCourseEntry.xaml
    /// </summary>
    public partial class YearCourseEntry : UserControl
    {
        public Panel Parent { get; set; }

        public YearCourseEntry()
        {
            InitializeComponent();
            Parent = null;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Parent?.Children.Remove(this);
        }
    }
}
