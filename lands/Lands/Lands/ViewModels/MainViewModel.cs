namespace Lands.ViewModels
{
    class MainViewModel
    {
        //Esta clase es el principal coordinador de los ViewModels y dentro de estos hacemos referencia a cada uno de los VieModels

        #region ViewModels
        //Dentro del ScrollView en LoginPage hay un BindingContext="{Binding Login} y este mismo nombre esta acá en el Main
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion
        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
