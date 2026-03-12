open System

let addChar (ch:string) (str: string) = 
    str+ch

let seqInput (n:int) =
    seq {for i in 1..n do
            printfn "введите строку:"
            yield Console.ReadLine()}

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

let rec recInput () =
    printfn "введите символ: "
    let input = Console.ReadLine()
    if input.Length = 1 then 
        input
    else
        printfn "1 символ!"
        recInput ()

[<EntryPoint>]
let main _ =
    let n = inputNum ()
    let mySeq = seqInput n
    let charr = recInput ()
    let ans = Seq.map (addChar charr) mySeq
    printfn "Итоговый sequense = %A" ans
    0