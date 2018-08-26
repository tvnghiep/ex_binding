using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ex_binding
{
    public class clsMain : INotifyPropertyChanged
    {
        private string _name;
        private string _title;
        private string _phonenumber;
        private string _address;
        private string _imagepath;

        public string Name
        {
            get => _name;
            set 
            {
                if (_name!=value)
                {
                    _name=value ;
                    //if (PropertyChanged!=null)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public string Title
        {
            get => _title ;
            set
            {
                if (_title  != value)
                {
                    _title  = value;
                    //if (PropertyChanged!=null)
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
                    RaisePropertyChanged(nameof(Name));
                }
            }
        }

        

        public string PhoneNumber
        {
            get => _phonenumber ;
            set
            {
                if (_phonenumber != value)
                {
                    _phonenumber = value;
                    //if (PropertyChanged!=null)
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
                    RaisePropertyChanged(nameof(Name));
                }
            }
        }

        public string Address
        {
            get => _address ;
            set
            {
                if (_address != value)
                {
                    _address = value;
                    //if (PropertyChanged!=null)
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
                    RaisePropertyChanged(nameof(Name));
                }
            }
        }

        public string ImagePath { get; set; }


        private void RaisePropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
