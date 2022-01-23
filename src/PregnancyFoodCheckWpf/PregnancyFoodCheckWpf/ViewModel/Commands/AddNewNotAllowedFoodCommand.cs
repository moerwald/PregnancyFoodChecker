namespace PregnancyFoodCheckWpf.ViewModel.Commands
{
    public class AddNewNotAllowedFoodCommand : BaseCommand
    {
        private readonly AddNewNotAllowedFoodViewModel _addNewNotAllowedFoodViewModel;

        public AddNewNotAllowedFoodCommand(AddNewNotAllowedFoodViewModel addNewNotAllowedFoodViewModel) => _addNewNotAllowedFoodViewModel = addNewNotAllowedFoodViewModel;
        public override bool CanExecute(object? parameter) => true;
        public override async void Execute(object? parameter) => await _addNewNotAllowedFoodViewModel.AddNewNotAllowedAsync();
    }
}
