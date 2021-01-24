using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Shipwreck.FontAwesomeControls.Demo
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Icon

        private string _Icon = "fas fa-pulse fa-spinner";

        public string Icon
        {
            get => _Icon;
            set
            {
                value ??= string.Empty;
                if (_Icon != value)
                {
                    _Icon = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Icon)));

                    if (FontAwesome.TryParse(_Icon, out var f, out var t, out var a))
                    {
                        IsRegular = f.Contains("regular");
                        IsSpin = a == FontAwesomeAnimation.Spin;
                        IsPulse = a == FontAwesomeAnimation.Pulse;
                    }
                }
            }
        }

        #endregion Icon

        #region IsRegular

        private bool _IsRegular;

        public bool IsRegular
        {
            get => _IsRegular;
            set
            {
                if (_IsRegular != value)
                {
                    _IsRegular = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRegular)));

                    if (_IsRegular)
                    {
                        Icon = "far " + Regex.Replace(Icon, "(^|(?<=\\s))fas($|\\s)", string.Empty).Trim();
                    }
                    else
                    {
                        Icon = "fas " + Regex.Replace(Icon, "(^|(?<=\\s))far($|\\s)", string.Empty).Trim();
                    }
                }
            }
        }

        #endregion IsRegular

        #region IsSpin

        private bool _IsSpin;

        public bool IsSpin
        {
            get => _IsSpin;
            set
            {
                if (_IsSpin != value)
                {
                    _IsSpin = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsSpin)));

                    if (_IsSpin)
                    {
                        Icon = Regex.Replace(Icon, "(^|(?<=\\s))fa-pulse($|\\s)", string.Empty).Trim() + " fa-spin";
                    }
                    else
                    {
                        Icon = Regex.Replace(Icon, "(^|(?<=\\s))fa-spin($|\\s)", string.Empty).Trim();
                    }
                }
            }
        }

        #endregion IsSpin

        #region IsPulse

        private bool _IsPulse = true;

        public bool IsPulse
        {
            get => _IsPulse;
            set
            {
                if (_IsPulse != value)
                {
                    _IsPulse = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsPulse)));

                    if (_IsPulse)
                    {
                        Icon = Regex.Replace(Icon, "(^|(?<=\\s))fa-spin($|\\s)", string.Empty).Trim() + " fa-pulse";
                    }
                    else
                    {
                        Icon = Regex.Replace(Icon, "(^|(?<=\\s))fa-pulse($|\\s)", string.Empty).Trim();
                    }
                }
            }
        }

        #endregion IsPulse

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
