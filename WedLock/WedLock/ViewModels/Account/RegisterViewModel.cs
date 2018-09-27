using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;


namespace WedLock.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {

        #region Properties

        private bool _sexmale;
        public bool SexMale
        {
            get { return _sexmale; }
            set
            {
                _sexmale = value;
                RaisePropertyChanged(() => SexMale);
            }
        }


        public bool _sexfemale;
        public bool SexFemale
        {
            get { return _sexfemale; }
            set
            {
                _sexfemale = value;
                RaisePropertyChanged(() => SexFemale);
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        public string _mobilenumber;
        public string MobileNumber
        {
            get { return _mobilenumber; }
            set
            {
                _mobilenumber = value;
                RaisePropertyChanged(() => MobileNumber);
            }
        }

        public string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        public DateTime _dateofbirth = DateTime.Now.Date.AddYears(-19);
        public DateTime DateOfBirth
        {
            get { return _dateofbirth; }
            set
            {
                _dateofbirth = value;
                RaisePropertyChanged(() => DateOfBirth);
            }
        }

        #endregion

        #region Relay Commands

        public RelayCommand AlreadyRegisteredCommand => new RelayCommand(AlreadyRegistered_Clicked);

        public RelayCommand SexMaleCommand => new RelayCommand(SexMaleCommand_Clicked);

        public RelayCommand SexFemaleCommand => new RelayCommand(SexFemaleCommand_Clicked);

        public RelayCommand RegisterCommand => new RelayCommand(RegisterCommand_Clicked);

        #endregion

        #region On Click functions

        private void AlreadyRegistered_Clicked()
        {
            _navigationService.NavigateTo(ViewModelLocator.LoginPage);
        }

        private void SexMaleCommand_Clicked()
        {
            SexMale = true;
            SexFemale = false;
        }

        private void SexFemaleCommand_Clicked()
        {
            SexFemale = true;
            SexMale = false;
        }
        private async void RegisterCommand_Clicked()
        {
            if ((SexFemale == true || SexMale == true) && !string.IsNullOrWhiteSpace(MobileNumber) && !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Password))
            {
                //call webapi to register user
                

            }
            else
            {
                //Show alert or message to add values
                //DisplayAlert("Alert", "You have been alerted", "OK");
            }

        }

        #endregion
    }
}
