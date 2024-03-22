# Mi Aplicación Dockerizada

Este repositorio contiene una aplicación ASP.NET Core dockerizada.

## Ejecución

Para ejecutar la aplicación utilizando Docker, sigue estos pasos:

1. Construye la imagen Docker utilizando el Dockerfile proporcionado:

    ```bash
    # Mi Aplicación Dockerizada

Este repositorio contiene una aplicación ASP.NET Core dockerizada.

## Ejecución

Para ejecutar la aplicación utilizando Docker, sigue estos pasos:

1. Asegúrate de tener Docker instalado en tu sistema. Puedes descargar Docker desde [aquí](https://www.docker.com/get-started).

2. Clona este repositorio en tu máquina local:

    ```bash
    git clone https://github.com/tuusuario/mi-aplicacion-dockerizada.git
    ```

3. Navega al directorio raíz del repositorio clonado:

    ```bash
    cd mi-aplicacion-dockerizada
    ```

4. Construye la imagen Docker utilizando el Dockerfile proporcionado:

    ```bash
    docker build -t hola-mundo -f ./hola-mundo/Dockerfile .
    ```

5. Una vez que la imagen se haya construido correctamente, puedes ejecutar un contenedor basado en esa imagen:

    ```bash
    docker run --name hola-mundo -d -p 3000:80 hola-mundo
    ```

    Este comando ejecutará un contenedor con el nombre `mi-aplicacion` que expone el puerto 8080 de tu máquina local al puerto 80 dentro del contenedor, donde se ejecuta la aplicación.

6. Abre tu navegador web y navega a la siguiente URL para acceder a la aplicación:

    ```
  [  http://localhost:8080](http://localhost:3000/swagger/index.html)
    ```



