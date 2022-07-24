# Repositorio con ejemplos de Pricipios SOLID
## Introducción:
**SOLID** es el acrónimo acuñado por Michahel Feathers basado en los principios de programacion orientada a objetos recopilados por Robert C. Martin.  
Nos ayudan a obtener mejores diseños y implementando una serie de reglas o principios.  
  
Los **5 principios SOLID** de diseño de  de aplicaciones de sofware son:
-
- **S** - Single Responsibility Principle (SRP)
- **O** – Open/Closed Principle (OCP)
- **L** – Liskov Substitution Principle (LSP)
- **I** – Interface Segregation Principle (ISP)
- **D** – Dependency Inversion Principle (DIP)
  
### Single Responsibility Principle (SRP) - Principio de Responsabilidad Única
*Just beacause you can, doesn't mean you should*  
- Una clase debe tener solo una razón para cambiar (responsabilidad).
- Una responsabilidad tiene que ver con:
  - ¿Qué hace?
  - ¿A quién conoce?
- Se centra en mantener alta la cohesión.
- Cada clase debe tener responsabilidad sobre una sola parte de la funcionalidad proporcionada por el software, y esa responsabilidad debe estar completamente
encapsulada por la clase.  

[Ejemplo](https://github.com/nbordon/SOLID/tree/master/SOLID.S)

### Open/Closed Principle (OCP) - Principio de Abierto/Cerrado
*Open chest surgery is not needed when putting on a coat*
- El comportamiento de una entidad debe poder ser alterado sin tener que modificar su propio codigo fuente.
- Una clase no se puede modificar, pero si se puede extender haciendo uso de la herencia
- Una clase solo debe ser modificada si existe un bug, para no romper funcionalidades en módulos dependientes.
- Se centra en mantener bajo el acoplamiento.  

[Ejemplo](https://github.com/nbordon/SOLID/tree/master/SOLID.O)

### Liskov Substitution Principle (LSP) - Principio de Sustitución de Liskov
*If it look like a duck, quacks like a duck, but needs batteries - yout probably have the wrong abstraction*
- Extensión del principio abierto/cerrado
- Una clase derivada puede ser reemplazada por cualquier otra que use su clase base sin alterar el correcto funcionamiento de un programa.
- Si una funcón espera como parámetro una clase base, ésta puede ser reemplazada por cualquier clase derivada.
- Una subclase no debe remover ni modificar comportamiento de la clase base, no debe conocer a los demas subtipos.
- Si un subtipo hace algo que el cliente del supertipo no espera, es una violación al principio.  

[Ejemplo](https://github.com/nbordon/SOLID/tree/master/SOLID.L)

### Interface Segregation Principle (ISP) - Principio de Segregación de Interfaces
*You want me to plug this in, where?*
- Los clientes no deben estar forzados a implementar interfaces que no utilizan.
- Guarda relación con la cohesión de las aplicaciones.
- La clase que implementa una interfaz o una clase abstracta no deberían estar obligadas a utilizar partes que no van a necesitar.
- Los clientes no deben estar obligados a implementar y/o a depender de una interface que luego no utilizarán.  

[Ejemplo](https://github.com/nbordon/SOLID/tree/master/SOLID.I)

### Dependency Inversion Principle (DIP) - Principio de Inversión de Dependencia
*Would you solder a lamp directly to the electrical wiring in a wall?*
- Se utiliza para desacoplar módulos de software.
- Las clases de alto nivel no deberían depender de las clases de bajo nivel. Ambas deberían depender de las abstracciones.
- Las abstracciones no deberían depender de los detalles. Los detalles deberían depender de las abstracciones.
- Al diseñar la interacción entre un módulo de alto nivel y un módulo de bajo nivel, la interacción debe considerarse como una interacción abstracta entre ellos.  

[Ejemplo](https://github.com/nbordon/SOLID/tree/master/SOLID.D)
