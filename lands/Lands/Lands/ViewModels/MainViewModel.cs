namespace Lands.ViewModels
{
    using System.Collections.Generic;
    using Models;

    class MainViewModel
    {
        //Esta clase es el principal coordinador de los ViewModels y dentro de estos hacemos referencia a cada uno de los VieModels

        #region Properties
            public List<Land> LandList
        {
            get;
            set;
        }
    	#endregion

        #region ViewModels
        //Dentro del ScrollView en LoginPage hay un BindingContext="{Binding Login} y este mismo nombre esta acá en el Main
        public LoginViewModel Login
        {
            get;
            set;
        }
        public LandsViewModel Lands
        {
            get;
            set;
        }
        public LandViewModel Land
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this; //Cuando carga el constructor se le asigna esa instancia
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        //Patron de diseño singleton para manejar una solo instancia en todo el tiempo de ejecución
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion
    }
}
