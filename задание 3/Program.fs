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
    let files = Array.map upCase (Directory.GetFiles(path, ""))
    let minFileName = Array.min files 
    printfn "файлы в указанной дирректории: %A" files
    printfn "первое по алфавиту имя: %s" minFileName 
    0