# ProyectoARQUITECTURA

*DOCUMENTACION PARA LA CREACIÓN DE UN NUEVO PROYECTO*

                /*Desde la terminal*/

1) Genere un repositorio nuevo con el Proyecto

2) Clone el Repositorio
   /*Desde la terminal*/
   git clone (aqui va la URL del repositorio)

3) Genere la Solucion Principal 
   /*Desde la terminal*/
   dotnet new sln

4) Crear el Proyecto Dominio
   /*Desde la terminal*/
   dotnet new classlib -o Dominio

5) Crear Proyecto Persistencia
   /*Desde la terminal*/
   dotnet new classlib -o Persistencia

6) Crear Proyecto de Aplicacion y webApi
   /*Desde la terminal*/
   dotnet new classlib -o Aplicacion
   dotnet new classlib -o DinoApi

7)
