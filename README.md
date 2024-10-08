<div align="center">
   
# Árbol Binario en C#
</div>

### Descripción
Un Árbol Binario es una estructura de datos jerárquica en la que cada nodo tiene a lo sumo dos hijos: un nodo izquierdo y un nodo derecho. Esta estructura es fundamental en la informática debido a su capacidad para representar relaciones jerárquicas y organizar datos de manera que las operaciones de búsqueda, inserción y eliminación sean altamente eficientes. 

Este proyecto desarrolla un Árbol Binario que soporta múltiples funcionalidades, permitiendo al usuario realizar diversas operaciones sobre el árbol. El Árbol Binario puede utilizarse en diversas aplicaciones, tales como la creación de árboles de expresión en compiladores, la organización de datos jerárquicos, la implementación de estructuras de datos para algoritmos de búsqueda como el Árbol de Búsqueda Binaria (BST), y la realización de recorridos sistemáticos sobre conjuntos de datos ordenados.

El código está diseñado de manera modular, con una clase `Nodo` que define los nodos del árbol y una clase `ArbolBinario` que encapsula toda la lógica de las operaciones posibles en el árbol. Estas clases trabajan en conjunto para proporcionar una interfaz sencilla pero potente para manejar árboles binarios, lo que permite a los desarrolladores utilizar el proyecto como base para estudios académicos, experimentación o desarrollo de software más avanzado.

## Objetivo
El objetivo del proyecto es desarrollar un Árbol Binario en C# que permita realizar diversas operaciones sobre la estructura, tales como inserción, búsqueda, y recorrido de nodos, además de calcular propiedades como el peso total y contar los nodos hoja. El proyecto está diseñado para ser utilizado como base educativa, experimental, o para el desarrollo de aplicaciones más avanzadas que requieran la organización jerárquica de datos.

## Características
1. **Insertar Nodo:** Permite insertar un nodo en el árbol siguiendo las reglas de los árboles binarios, asegurando que los valores menores se coloquen a la izquierda y los mayores a la derecha.
2. **Buscar Nodo:** Permite verificar si un valor específico está presente en el árbol, retornando verdadero si se encuentra y falso en caso contrario.
3. **Obtener Nivel de un Nodo:** Calcula el nivel en el que se encuentra un nodo específico dentro del árbol, permitiendo comprender la profundidad de los datos.
4. **Recorrer Camino General:** Muestra todos los caminos posibles desde la raíz hasta las hojas del árbol, lo que es útil para visualizar la estructura completa del árbol.
5. **Recorrer Camino de un Nodo:** Muestra el camino desde la raíz hasta un nodo específico, facilitando la identificación de rutas dentro del árbol.
6. **Calcular Peso Total:** Calcula el número total de nodos presentes en el árbol, proporcionando una medida del tamaño del árbol.
7. **Contar Nodos Hoja:** Cuenta cuántos nodos hoja tiene el árbol, es decir, aquellos nodos que no tienen hijos.

## Requisitos
- .NET 5.0 o superior.
- Un IDE compatible con C# (como Visual Studio o Visual Studio Code).
> [!Important]
> Es importante asegurarse de que todos los requisitos estén instalados y configurados correctamente antes de ejecutar este proyecto para evitar problemas y asegurar un funcionamiento óptimo.

## Guía de Instalación
1. Clona el repositorio o descarga los archivos.
   
   ```bash
   git clone https://github.com/Miguel-Antonio-Martinez-Jimenez/Arbol.Binario
3. Abre el proyecto en tu IDE favorito.
4. Asegúrate de tener .NET 5.0 instalado y configurado.

## Conexión con la Base de Datos
Este proyecto no requiere un sistema de gestión de bases de datos. En su lugar, se emplean archivos para el almacenamiento y manejo de los datos.

## Accesos o Credenciales
El proyecto no requiere de accesos o credenciales específicas para su uso. Solo es necesario clonar el repositorio y contar con los requisitos instalados en tu sistema para poder ejecutar el código.

## Guía de Uso del Proyecto
1. Ejecuta el proyecto desde el IDE o desde la terminal usando
   
   ```bash
   dotnet run
3. El programa insertará nodos en el árbol y demostrará las funcionalidades implementadas, como la búsqueda de nodos, la obtención del nivel de un nodo, y el recorrido de los caminos del árbol.

## Estructura de Archivos
- `ArbolBinario/ArbolBinario.cs`: Clase principal que implementa las funciones del árbol binario.
- `ArbolBinario/ArbolBinario.csproj`: Este es el archivo del proyecto de C# de Visual Studio. Contiene información sobre cómo construir el proyecto, las dependencias, y otras configuraciones del proyecto.
- `ArbolBinario/Nodo.cs`: Clase que define la estructura de un nodo con su valor y referencias a los nodos hijos (izquierdo y derecho).
- `ArbolBinario/Program.cs`: Punto de entrada del programa que ejecuta ejemplos de uso de las funcionalidades del árbol binario.
- `ArbolBinario.sln`: Este es el archivo de solución de Visual Studio, que agrupa uno o más proyectos (como ArbolBinario.csproj) y administra cómo se construyen y ejecutan.
  
  ```bash
   Arbol_Binario/
   ├── ArbolBinario/
   │   ├── ArbolBinario.cs
   │   ├── ArbolBinario.csproj
   │   ├── Nodo.cs
   │   └── Program.cs
   ├── ArbolBinario.sln
   ├── LICENSE
   └── README.md

## Estado del Proyecto
**Estado Actual**: `Finalizado`
> [!Note]
> Este proyecto se encuentra en estado **Finalizado**, lo que significa que todas las funcionalidades planeadas han sido implementadas y probadas satisfactoriamente. El código está disponible para su uso y estudio, y se aceptan contribuciones para mejoras o nuevas características.
<!--### Posibles Estados del Proyecto
- **Inicios:** El proyecto está en sus etapas iniciales de planificación y desarrollo. Apenas se están definiendo los requisitos y comenzando la implementación básica.
- **En Desarrollo:** El proyecto está en plena fase de desarrollo, con funcionalidades siendo añadidas y pruebas en curso. Puede contener errores o estar sujeto a cambios importantes.
- **Finalizado:** El proyecto ha alcanzado sus objetivos iniciales, con todas las funcionalidades implementadas y probadas. Puede recibir mantenimiento o mejoras menores.
- **Mantenimiento:** El proyecto está completo, pero sigue recibiendo actualizaciones menores, corrección de errores o mejoras en la documentación y el rendimiento.
- **Abandonado:** El desarrollo ha sido detenido y no se planean futuras actualizaciones ni mantenimiento. -->

## Contribuciónes
> [!Tip]
> Si deseas contribuir al proyecto, reportar errores o proponer mejoras, te invitamos a abrir un pull request o issue en el repositorio. También puedes contactarme directamente para compartir tus ideas o sugerencias a través de mi correo electrónico miguelantoniomartinezjimenez00@gmail.com. ¡Toda colaboración es bienvenida!

## Autores
[MiguelMartinez30 - @DevDarkSonic](https://github.com/Miguel-Antonio-Martinez-Jimenez)

## Licencia
Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.
