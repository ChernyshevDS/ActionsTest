namespace ActionsTest
{
    public class MainVM : ObservableObject
    {
        private string message;

        public string Message { get => message; set => SetProperty(ref message, value); }

        public MainVM()
        {
            var bld = new SomeLibrary.GreetingsBuilder("world");
            Message = bld.Build();
        }
    }
}
