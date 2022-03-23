open System
[<EntryPoint>]
let main argv =
  let x = lazy(1/0);
  let result = lazy(45 * 12);
  let z = result.Force();
  let y = x.Force();
  printfn "%d" z;
  printfn "%d" y;
  0
