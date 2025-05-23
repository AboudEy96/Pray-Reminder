using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace TaskMAUI.Pray;

public class PrayerStatusView : INotifyPropertyChanged
{
    
    // current prayer strategy
    private readonly Prayer _prayer;

    // storege the current prayerstatus
    private string _status;

    public string Status
    {
        get => _status;
        set { _status = value;
            OnPropertyChanged();
        }
    }
    
    // the comands in ui to use in xaml ( Binding OnTimeCommand ..)
    public ICommand OnTimeCommand { get; }
    public ICommand MissedCommand { get; }
    public ICommand MadeUpCommand { get; }

    public PrayerStatusView()
    {
        _prayer = new Prayer(new PrayedOnTimeStrategy()); // prayed on Time default .. الصلاة بالوقت

        OnTimeCommand = new Command(() =>
        {
            _prayer.SetStrategy(new PrayedOnTimeStrategy());
            _status = _prayer.CheckPrayerStatus();
        });
        MissedCommand = new Command(() =>
        {
            _prayer.SetStrategy(new MissedPrayerStrategy());
            _status = _prayer.CheckPrayerStatus();
        });
        MadeUpCommand = new Command(() =>
        {
            _prayer.SetStrategy(new MadeUpPrayerStrategy());
            _status = _prayer.CheckPrayerStatus();
        });
    }
    
    // INotifyPropertyChanged to use in front-end status
    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string name = "") => 
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    
}