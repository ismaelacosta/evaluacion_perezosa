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
En la evaluación perezosa el cálculo de ciertas expresiones puede ser retrasado hasta llegar el punto en que su valor sea necesario obtenerlo.

En este ejemplo con la función *lazy* nos permite evitar en principio un error al calcular un valor entre cero ya que le indicamos que no es necesario procesarlo por el momento, de igual forma la instruccion siguiente con la operación de multiplicación no se ejecuta, despues ambos procesos los llamamos con a función *Force* para poder ejecutarlas y guardarlas en las respcetivas variables.

Para evitar el error de la división entre cero podriamos simplemente no llamar a la instrucción comentando la linea que guarda *y* el valor. \
`  let y = x.Force(); `\
