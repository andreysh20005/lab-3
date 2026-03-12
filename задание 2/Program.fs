open System

let minimumLenth (a: string) (b: string) = 
    if a.Length < b.Length then
        a
    else
        b


let rec inputNum () = 
    printfn "введите количество элементов sequense:"
    let flag, n = Int32.TryParse(Console.ReadLine())

    if flag then
        if n <= 0 then 
            printfn "число не является натуральным!"
            inputNum ()
        else n
    else
        printfn "не является целым числом!"
        inputNum ()
        
let seqInput (n:int) =
    seq {for i in 1..n do
            printfn "введите строку:"
            yield Console.ReadLine()}

[<EntryPoint>]
let main _ =

    let n = inputNum () 
    let mySeq = seqInput n
    let minStr = Seq.fold minimumLenth (Seq.head mySeq) (Seq.tail mySeq)
    printf "минимальная длинна строки в sequense = '%d' (строка %s)"  minStr.Length minStr
    0