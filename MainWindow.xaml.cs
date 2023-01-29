using System.Windows;


namespace RPN_Calc
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void СalculateButton_Click(object sender, RoutedEventArgs e)
        {
            RpnExpr.Text = RPN.GetExpression(expression.Text);
            Result.Text = RPN.Counting(RpnExpr.Text).ToString();
        }
    }
}


    
