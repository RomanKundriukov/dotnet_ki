using static Tensorflow.KerasApi;

namespace MauiKITrainer.Service
{
    /// <summary>
    /// Class um die Modelle zu erstellen
    /// </summary>
    public static class ModellCreator
    {


        public static object CreateCVModel()
        {
            //var model = keras.Sequential();
            //model.add(new );
            var layers = keras.layers;
            var inputs = keras.Input(shape: (150, 150, 3), name: "img");


            return model;

        }

        //public static async Task<BaseModel> BuildModelAsync()
        //{
        //    //await Installer.SetupPython();
        //    //PythonEngine.Initialize();
        //    //dynamic sys = Py.Import("sys");
        //    var model = new Sequential();
        //    model.Add(new Dense(64, activation: "relu", input_shape: new Shape(32)));
        //    model.Add(new Dense(10, activation: "softmax"));

        //    model.Compile(optimizer: new Adam(), loss: "categorical_crossentropy", metrics: new string[] { "accuracy" });


        //    return (BaseModel)model;
        //}

        //public static string GetModelSummary(BaseModel model)
        //{
        //    // Aktuelle Konsolenausgabe zwischenspeichern
        //    var originalStdOut = Console.Out;

        //    try
        //    {
        //        // StringWriter zum Abfangen der Konsolenausgabe
        //        using var sw = new StringWriter();

        //        // Standardausgabe temporär auf unseren StringWriter umleiten
        //        Console.SetOut(sw);

        //        // Aufruf, der sonst direkt in die Konsole schreiben würde
        //        model.Summary();

        //        // Zurück in einen String holen
        //        return sw.ToString();
        //    }
        //    finally
        //    {
        //        // Wiederherstellen der alten Standardausgabe
        //        Console.SetOut(originalStdOut);
        //    }
        //}


        //public static object CreateModell()
        //{
        //    var layers = keras.layers;

        //    var inputs = keras.Input(shape: 1);
        //    var dense = layers.Dense(units: 1);

        //    var outputs = dense.Apply(inputs);

        //    var model = keras.Model(inputs, outputs);

        //    model.compile(optimizer: "adam", loss: "mean_squared_error", metrics: new string[] { "accuracy" });

        //    return model;
        //}

        //public static string GetModelSummary()
        //{
        //    var layers = keras.layers;

        //    var inputs = keras.Input(shape: 1);  // Fix: Shape muss explizit angegeben werden
        //    var dense = layers.Dense(units: 1);
        //    var outputs = dense.Apply(inputs);
        //    var model = keras.Model(inputs, outputs);

        //    model.compile(optimizer: "adam", loss: "mean_squared_error", metrics: new string[] { "accuracy" });

        //    using (var sw = new System.IO.StringWriter())
        //    {
        //        var originalOut = Console.Out;  // Speichere die originale Konsole
        //        Console.SetOut(sw);  // Umleiten auf StringWriter

        //        model.summary();  // Jetzt wird die Ausgabe gespeichert

        //        Console.SetOut(originalOut);  // Zurücksetzen auf die Standard-Konsole
        //        return sw.ToString();  // Die gespeicherte Ausgabe zurückgeben
        //    }
        //}


    }
}
