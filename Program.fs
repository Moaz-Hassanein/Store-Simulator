namespace StoreSimulator

open System
open System.Windows.Forms

module Program =

    [<EntryPoint; STAThread>]
    let main (_: string[]) : int =
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(false)
        Application.Run(MainForm.create ())
        0
