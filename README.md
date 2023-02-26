Aplicación web - Gestor de imágenes
C# /.NET / ASP / SQLServer

Para abrir la aplicación web se precisa que la misma sea ejecutada en un IDE que pueda compilar código C# y ejecutar la aplicación desde un servidor web de manera local. Se recomienda el Visual Studio, ya que este posee el contenedor web Inter Informations Service Express. Así mismo, se adjunta el script en SQL Server [BaseDeDatos.sql] para la creación de la BD y sus respectivos Procedimientos Almacenados. El mismo se encuentra dentro de la carpeta Script.
La aplicación web fue desarrollada siguiendo el modelo de arquitectura en capas, el cual permite distribuir responsabilidades. Por un lado, la clase Dominio se encarga de darle formato al objeto de la Clase Imagen. La clase Negocio posee la lógica que se precisa para interactuar contra la BD y que tenga impacto con la entidad Imagen y por último la capa de Presentación, que corresponde a las pantallas web. En cuanto a la conexión contra la BD, se diseñó en un proyecto nuevo: AccesoBD, desde el cual se deberá configurar la cadena de conexión a la BD con los datos propios de cada Server.
El código se ha desarrollado teniendo en cuenta el diseño de Programación Orientada a Objetos.
Esta forma de diseñar la aplicación permite encontrarnos con un código modularizado, el cual permite una escalabilidad en la aplicación, pensada en un posible seguimiento de la misma con otras funcionalidades. O bien, que la misma pueda adaptarse a otra aplicación, en la cual se encargará de resolver las cuestiones propias a la gestión de imágenes.  

