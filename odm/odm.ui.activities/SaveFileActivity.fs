﻿namespace odm.ui.activities
    open System
    open System.IO
    open System.Linq
    open System.Collections.Generic
    open System.Collections.ObjectModel
    open System.Threading
    open System.Net
    open System.Windows
    open System.Windows.Threading
    open Microsoft.Win32

    open odm.onvif
    open odm.core
    open odm.infra
    // open utils
    //open odm.models
    open utils.fsharp

    type SaveFileActivityResult = 
        | Selected of string
        | Canceled

    type SaveFileActivity() = class
        static member Run(filter:string) = async{
            let disp = Application.Current.Dispatcher
            return! disp.InvokeAsync(fun ()->
                let dlg = new SaveFileDialog()
                //dlg.InitialDirectory <- Directory.GetCurrentDirectory()
                dlg.Filter <- filter
                if dlg.ShowDialog() = Nullable(true) then
                    SaveFileActivityResult.Selected(dlg.FileName)
                else
                    SaveFileActivityResult.Canceled
            )
        }
    end
