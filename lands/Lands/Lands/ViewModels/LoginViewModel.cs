namespace Lands.ViewModels
{
    using System.Windows.Input;

    class LoginViewModel
    {
        #region Properties
        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        //public bool IsEnabled
        //{
        //    get { return this.isEnabled; }
        //    set { SetValue(ref this.isEnabled, value); }
        //}
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            //this.Email = "jzuluaga55@hotmail.com";
            //this.Password = "123456";
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get;
            set;
            
        }
        #endregion
    }
}
