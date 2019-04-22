using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.BattleCity.Model;
namespace Avalonia.BattleCity
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        static void Main(string[] args)
        {
            BuildAvaloniaApp()
                .Start<MainWindow>(() =>
                {

                    var field = new GameField();
                    var game = new Game(field);
                    game.Start();
                    return field;


                });
        }

        static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<App>()
            .UsePlatformDetect();

    }
}

