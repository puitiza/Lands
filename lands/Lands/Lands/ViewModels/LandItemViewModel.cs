namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Models;
    using System.Windows.Input;
    using Views;
    using Xamarin.Forms;

    public class LandItemViewModel : Land
    {
        //Esta clase es necesaria para cuando usamos un listView como los item en este caso heredas de Land por eso se pone
        //como extension

        #region Commands
        public ICommand SelectLandCommand
        {
            get
            {
                return new RelayCommand(SelectLand);
            }
        }

        private async void SelectLand()
        {   
            //Recuerda que cuando quieres navegar entre las pages , es obligatorio instanciar el MainViewModel
            //Cuando quieres pasar un objecto de un ViewModel a otro ViewModel usa el constructor. 
            MainViewModel.GetInstance().Land = new LandViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new LandTabbedPage());
        }
        #endregion
    }
}
