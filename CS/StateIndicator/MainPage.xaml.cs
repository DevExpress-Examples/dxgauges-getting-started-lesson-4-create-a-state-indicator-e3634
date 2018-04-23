using System.Windows.Controls;
using System.Windows.Input;

namespace StateIndicator {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void stateIndicatorControl1_MouseEnter(object sender, MouseEventArgs e) {
            stateIndicatorControl1.StateIndex = 0;
        }

        private void stateIndicatorControl1_MouseLeave(object sender, MouseEventArgs e) {
            stateIndicatorControl1.StateIndex = 2;
        }
    }
}
