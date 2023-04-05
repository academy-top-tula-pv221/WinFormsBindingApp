namespace WinFormsBindingApp
{
    public partial class Form1 : Form
    {
        User user;
        public Form1()
        {
            user = new User() { Name = "Bob", Age = 23 };

            InitializeComponent();

            this.DataContext = user;

            lblTarget.Text = "";
            lblDateTarget.Text = "";

            Binding binding = new Binding("Text", txtSource, "Text");
            binding.Format += (sender, e) => e.Value = $"Content: {e.Value}";

            lblTarget.DataBindings.Add(binding);

            Binding bindingDate = new Binding("Text", dateTimePicker, "Value");
            bindingDate.FormattingEnabled = true;
            bindingDate.FormatString = "dd.MM.yyyy";

            lblDateTarget.DataBindings.Add(bindingDate);

            Binding bindingUserName = new Binding("Text", this.DataContext, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUserName.DataBindings.Add(bindingUserName);

            Binding bindingUserAge = new("Value", this.DataContext, "Age");
            bindingUserAge.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            numUserAge.DataBindings.Add(bindingUserAge);



        }
        private void btnUserNameChange_Click(object sender, EventArgs e)
        {
            user.Name = "Joe";
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User name: {user.Name}, age: {user.Age}");
        }
    }
}