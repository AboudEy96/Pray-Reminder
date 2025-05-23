using TaskMAUI.Entity;
using TaskMAUI.Pray;

namespace TaskMAUI;

public partial class LoginPage : ContentPage
{
    private bool isLogin = true;

    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnSwitchButtonClicked(object sender, EventArgs e)
    {
        isLogin = !isLogin;

        if (isLogin)
        {
            TitleLabel.Text = "تسجيل الدخول";
            ActionButton.Text = "دخول";
            SwitchLabel.Text = "ليس لديك حساب؟";
            SwitchButton.Text = "إنشاء حساب";
        }
        else
        {
            TitleLabel.Text = "إنشاء حساب";
            ActionButton.Text = "تسجيل";
            SwitchLabel.Text = "لديك حساب؟";
            SwitchButton.Text = "تسجيل الدخول";
        }
    }

    private async void OnActionButtonClicked(object sender, EventArgs e)
    {
        if (isLogin)
        {
            Console.WriteLine("تم تسجيل الدخول");
//            Student student = new Student { Name = EmailEntry.Text, ID = 1, Password = PasswordEntry.Text };
// //          student.ShowInfo();
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            Console.WriteLine("تم إنشاء الحساب");
            await Navigation.PushAsync(new MainPage());
        }
    }
}