namespace Lands.Infrastructure
{
    using ViewModels;
    class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        //Esto me sirve para ligar la pagina MainViewModel con LoginPage
        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        } 
        #endregion
    }
}
