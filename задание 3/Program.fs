open System
open System.IO

let rec inputFilePath () = 
    printfn "введите путь дирректории:"
    let filePath = Console.ReadLine()
    if Directory.Exists(filePath) then
        filePath
    else
        printfn "дирректории не существует"
        inputFilePath ()



let upCase (str:string) = 
    str.ToUpper()


[<EntryPoint>]
let main _ =
    let path = inputFilePath ()
    let filesSeq = 
        Directory.EnumerateFiles(path, "*")   
        |> Seq.map upCase                      
    let filesList = Seq.toList filesSeq
    let minFileName = List.min filesList
    printfn "файлы в указанной дирректории: %A" filesList
    printfn "первое по алфавиту имя: %s" minFileName
    0
