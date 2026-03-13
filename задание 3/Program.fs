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
    if Seq.length filesSeq >0 then
        let maxFileName = Seq.max filesSeq
        printfn "файлы в указанной дирректории:\n %A" filesSeq
        printfn "последнее по алфавиту имя: %s" maxFileName
    else
        printf "нет файлов в дирректории %s" path
    
    0
