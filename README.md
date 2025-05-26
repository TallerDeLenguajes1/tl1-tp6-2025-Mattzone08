[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

## Preguntas sobre el tipo `string` en C#

### ¿`string` es un tipo por valor o un tipo por referencia?

`string` es un **tipo por referencia**, ya que internamente es una clase (`System.String`). Sin embargo, su comportamiento es **inmutable**, lo que significa que cada vez que se modifica una cadena, en realidad se crea un nuevo objeto en memoria.

---

### ¿Qué secuencias de escape tiene el tipo `string`?

C# soporta las siguientes **secuencias de escape** dentro de cadenas de texto:

| Secuencia | Significado             |
|-----------|--------------------------|
| `\n`      | Nueva línea              |
| `\r`      | Retorno de carro         |
| `\t`      | Tabulación               |
| `\\`      | Barra invertida (`\`)    |
| `\'`      | Comilla simple           |
| `\"`      | Comilla doble            |
| `\0`      | Carácter nulo (null)     |
| `\a`      | Alerta (beep)            |
| `\b`      | Retroceso                |
| `\f`      | Salto de página          |
| `\v`      | Tab vertical             |

---

### ¿Qué sucede cuando utiliza el carácter `@` y `$` antes de una cadena de texto?

- **`@` (verbatim string)**: Permite escribir cadenas **literales**, es decir, sin necesidad de usar secuencias de escape. También permite escribir en **varias líneas**. Muy útil para rutas de archivos.

  ```csharp
  string ruta = @"C:\Usuarios\Juan\Documentos";
