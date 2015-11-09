using Autofac;
using OdeToFoodConsoleApp.Interfaces;

namespace OdeToFoodConsoleApp.DI
{
    public class Writer
    {
        private static IContainer Container { get; set; }

        public static void SetWriter<T>()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<T>().As<IOutput>();
            Container = builder.Build();
        }

        public static void WriteOutput(string order)
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IOutput>();
                writer.WriteLine(order);
            }
        }
    }
}
