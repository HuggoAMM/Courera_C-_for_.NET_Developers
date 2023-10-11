# C# for .NET Developers

## Conceptos:

### .NET Core:

- Se conoce como un usbconjunto mas grande de .NET Framework.
- Las aplicaciones son mas modulares, ligeras, rápidas, flexibles y modernas.

1. Open source
2. Cross-Platform
3. Modular Architecture
4. Supports Multiple Languages
5. Consistent
6. CLI Tool
7. Flexible Deployment
8. Compatibility

### .NET FRAMEWORK vs .NET CORE

#### .NET CORE

- Es una plataforma de desarrollo de propósito general para desarrollar aplicaciones de software modernas basadas en la nube en diferentes sistemas operativos. Ofrece código abierto, multiplataforma, alto rendimiento y multiples entornos.
- Open source
- Compatible con Windows, Linux, Mac OS
- No soporta el desarrollo de aplicaciones de escritorio, se centra mas en web
- Ofrece un alto rendimiento y escalabilidad

#### .NET FRAMEWORK

- Algunos componentes son open source, la mayoria son de paga.
- Windows
- se utiliza para aplicaciones de escritorio y web
- Ofrece menos rendimiento y escalabilidad que .NET Core

##### Crear Proyecto

- dotnet new list
- dotnet new console -n coreConsoleProject
- dotnet build
- dotnet run

#### .NET Core Framework

- CLI Tools:
- Roslyn:compilador de c# y visual basic
- CoreFX: proporciona un conjunto de frameworks
- CoreCLR: es un componente de la plataforma .NET Core que proporciona el entorno de ejecución para las aplicaciones .NET Core.

### Programación orientada a objetos:

- Clases: La estructura utilizando métodos y propiedades que se asemejan a la entidad del mundo real.[Capos, propiedades, metodos]
- Objetos: Es el principal componente importante que ayuda a acceder a los miembros de la clase. Son instancias de la clase que contienen diferentes datos en campos de propiedades y tambien pueden interactuar con otros objetos.
  \*- Encapsulación: Ocultación de datos. Se necesita abstraerlos con ayuda de modificadores de acceso.
- Abstracción: Modificadores de acceso: publicos, privados protegidos e internos
- Herencia: Reutilización de datos
- Polimorfismo: Signidica una interfaz, multiples funciones donde una misma operación se va a realizar en diferentes entidades.

#### Polimorfismo

##### Polimorfismo en tiempo de compilación

El compilador identifica qué método está siendo llamado en tiempo de compilación:

1. Sobrecarga de método: es un mecanismo para tener mas de un método con el mismo nombre pero diferentes parametros.
2. Sobrecarga de constructores

##### Propiedades

- Getters y Setters
- Solo son de lectura y escritura

##### Indexador

- Es un tipo especial de propiedas que permite acceder a una clase o a una estructura como un array para su coleccion interna.
- Cuando se define un indexador a una clase, esta clase se comporta de manera similar a un array vitual o un tipo de coleccion.
- Se puede acceder a la instancia de esta clase utilizando el operador de eje de array que es []

### Extension methods, anonymous type, delegates, events, lambda expression, expression tree

#### Anonymous type

- Es un tipo de dato que tienen atributos públicos de sólo lectura.
- Es un objeto que no tiene tipos explicitos, por lo qu puede almacenar cualquier tipo de valor.
- No contiene funciones, constructores, métodos getters, setters.
- El compilador genera el nombre del tipo y es accesible solo para el bloque de código actual.
- Los tipos anónimos proporcionan una forma cómoda de encapsular un conjunto de propiedades de sólo lectura en un único objeto sin tener que definir primero explícitamente un tipo.
- El nombre del tipo es generado por el compilador y no está disponible a nivel del código fuente. El tipo de cada propiedad es inferido por el compilador.

* Los tipos anónimos se utilizan para definir nuevas clases con un conjunto específico de propiedades sin tener que definir explícitamente la clase.
* Los tipos anónimos se definen utilizando la palabra clave "var" y no tienen una definición de clase explícita.

#### Extension methods

- Los métodos de extensión le permiten "añadir" métodos a tipos existentes sin crear un nuevo tipo derivado, recompilar o modificar de otro modo el tipo original. Los métodos de extensión son métodos estáticos, pero se llaman como si fueran métodos de instancia en el tipo extendido. Para el código cliente escrito en C#, F# y Visual Basic, no hay diferencia aparente entre llamar a un método de extensión y a los métodos definidos en un tipo.

#### Delegates

- Es un puntero a un método.
- Es una referencia al método.
- Contiene la dirección de un método que puede ser llamado utilizando la variable de referencia del delegado.
- Para el método estático, el delegado encapsula solo el método pero para el método de instancia,, encapsula tanto la instancia del metodo.
- El mejor uso del delegado e utilizar un evento.
- Un delegado es un tipo que representa referencias a métodos con una lista de parámetros y un tipo de retorno determinados. Al instanciar un delegado, puede asociar su instancia a cualquier método con una firma y un tipo de retorno compatibles. Puede invocar (o llamar) al método a través de la instancia del delegado.

* Un delegado es un tipo que representa una referencia a un método con una firma específica, que puede utilizarse para encapsular llamadas a métodos y pasarlas como parámetros.

#### Events

- Los eventos permiten a una clase u objeto notificar a otras clases u objetos cuando ocurre algo de interés. La clase que envía (o plantea) el evento se denomina publicador y las clases que reciben (o manejan) el evento se denominan suscriptores.

* Los eventos se utilizan para proporcionar un mecanismo para que un objeto notifique a otros objetos cuando se produce un evento, permitiendo que los otros objetos respondan adecuadamente.

#### Var vs Dynamic

- Los lenguajes de programación pueden considerarse normalmente de tipado estático o de tipado dinámico.
- Un lenguaje tipado estáticamente (no confundir con la palabra clave static, utilizada para las clases) valida la sintaxis o comprueba si hay algún error durante la compilación del código.
- Por otro lado, los lenguajes tipados dinámicamente validan la sintaxis o comprueban si hay errores sólo en tiempo de ejecución.
- Por ejemplo, C# y Java son de tipo estático y JavaScript es un lenguaje de tipo dinámico.

* var se utiliza para la inferencia estática de tipos, mientras que dynamic se utiliza para la vinculación dinámica de tipos, lo que significa que el tipo de una variable declarada como dynamic se determina en tiempo de ejecución y no en tiempo de compilación.
* La palabra clave "var" permite a los desarrolladores declarar variables sin especificar sus tipos explícitamente, siempre que el tipo pueda deducirse de la expresión de inicialización de la variable.
* "Var" se utiliza para objetos tipados estáticamente, mientras que "dinámico" se utiliza para objetos que se resuelven en tiempo de ejecución.
* "var" se utiliza para declarar una variable cuyo tipo es inferido por el compilador, mientras que "dynamic" se utiliza para declarar una variable cuyo tipo puede cambiar en tiempo de ejecución.
* "Var" se utiliza para declarar una variable con un tipo inferido, mientras que "dinámico" se utiliza para declarar una variable con un tipo que se determina en tiempo de ejecución.

#### Anonymous Methods

- Pueden acceder a las variables definidas en una función externa y tambien se comporta como un metodo normal.
- Como su nombre indica, un método anónimo es un método sin nombre. Los métodos anónimos en C# pueden definirse utilizando la palabra clave delegado y pueden asignarse a una variable de tipo delegado.
- Un método anónimo es un método sin nombre, que puede utilizarse para definir un bloque de código que puede pasarse como parámetro delegado.

#### Expresiones Lambda

- Utilice una expresión lambda para crear una función anónima. Utilice el operador de declaración lambda => para separar la lista de parámetros de la lambda de su cuerpo.
- Una expresión lambda es una forma concisa de definir un método anónimo que puede pasarse como parámetro a otro método.

#### Árboles de expresiones

- Los árboles de expresiones representan el código en una estructura de datos similar a un árbol, donde cada nodo es una expresión, por ejemplo, una llamada a un método o una operación binaria como x < y.
- Un árbol de expresiones es una estructura de datos que representa una expresión lambda, que puede utilizarse para construir consultas dinámicas o crear código dinámico en tiempo de ejecución.
- Un árbol de expresión es una estructura de datos que representa una expresión lambda como un árbol de nodos de expresión, lo que puede resultar útil para analizar, transformar y compilar expresiones lambda.
- Los árboles de expresiones se utilizan para representar las consultas LINQ como código que puede traducirse a una consulta SQL o a otro código específico del lenguaje.
