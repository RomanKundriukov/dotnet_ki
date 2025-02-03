//using Microsoft.Extensions.Logging;
//using Tensorflow.NumPy;
//using static Tensorflow.KerasApi;



using MauiKITrainer.Service;
using Microsoft.Extensions.Logging;

namespace MauiKITrainer
{
    public static class MauiProgramExtensions
    {
        public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
        {
            var model = ModellCreator.CreateCVModel();
            //var model = keras.Sequential();
            //PythonEngine.Initialize();
            //using (Py.GIL())
            //{
            //    dynamic np = Py.Import("numpy");
            //    Console.WriteLine(np.cos(np.pi * 2));

            //    dynamic sin = np.sin;
            //    Console.WriteLine(sin(5));

            //    double c = (double)(np.cos(5) + sin(5));
            //    Console.WriteLine(c);

            //    dynamic a = np.array(new List<float> { 1, 2, 3 });
            //    Console.WriteLine(a.dtype);

            //    dynamic b = np.array(new List<float> { 6, 5, 4 }, dtype: np.int32);
            //    Console.WriteLine(b.dtype);

            //    Console.WriteLine(a * b);
            //    Console.ReadKey();
            //}



            //NDArray a = np.array(new float[] { 1, 2, 3 });
            //NDArray b = np.array(new float[] { 4, 5, 6 });

            //NDArray sum = np.add(a, b); // Вручную вызываем np.add(), вместо "+"



            //Build sequential model


            //Load model and weight




            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder;
        }
    }
}
