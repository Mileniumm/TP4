TP_Tecnicatura
Trabajo final de Programación 1
Integrantes: Aguilera Nahuel, Monelli Alexander, Previgliano Milena, Vigna Ruffino Gino
Gestión de Ocupación y Estadísticas de Vuelos

Este proyecto es una aplicación de consola en C# que permite gestionar la ocupación de vuelos de una aerolínea, así como calcular estadísticas relacionadas. Los datos de la aerolínea, incluidos los vuelos y la información de ocupación, se guardan y cargan desde un archivo XML.

Características La aplicación ofrece las siguientes funcionalidades:

1)Agregar un vuelo: Permite al usuario agregar un vuelo especificando el código de vuelo, fecha y hora de salida, fecha y hora de llegada, nombres del piloto y copiloto, y capacidad máxima de pasajeros.

2)Registrar pasajeros en un vuelo: Permite registrar el número de pasajeros que han abordado un vuelo específico, verificando que no se exceda la capacidad máxima.

3)Calcular ocupación media de la flota: Calcula el porcentaje promedio de ocupación de todos los vuelos registrados.

4)Mostrar vuelo con mayor ocupación: Muestra el vuelo con el mayor porcentaje de ocupación registrado.

5)Buscar vuelo por código: Permite ingresar un código de vuelo específico y muestra sus detalles junto con el porcentaje de ocupación.

6)Listar vuelos ordenados por ocupación: Muestra todos los vuelos ordenados en función de su porcentaje de ocupación, de mayor a menor.

7)Guardar y recuperar datos: Guarda los datos de la aerolínea en un archivo XML, lo que permite que los datos persistan entre ejecuciones del programa.

Estructura del Proyecto:

Clase Vuelo: Contiene la información de cada vuelo, como el código, fechas, capacidad, y pasajeros actuales. Incluye métodos para calcular el porcentaje de ocupación.

Clase Aerolinea: Almacena la lista de vuelos y la información de contacto de la aerolínea. Incluye métodos para manejar los vuelos y calcular estadísticas.

Clase GestorDeArchivos: Proporciona métodos para guardar y cargar los datos de la aerolínea en un archivo XML.

Program.cs: Contiene el menú principal y llama a las funciones de Aerolinea para ejecutar las opciones seleccionadas.
