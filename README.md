# Evaluación perezosa
Código de ejemplo de la presentación del tema de Evaluación perezosa de la clase Programación Lógica y Funcional

## Código 

  `open System` \
  `[<EntryPoint>]` \
  `let main argv = `\
   `  let x = lazy(1/0);` \
   `  let result = lazy(45 * 12); `\
   `  let z = result.Force(); `\
   `  let y = x.Force(); `\
   `  printfn "%d" z; `\
   `  printfn "%d" y; `\
   `  0`

###Descripción 
