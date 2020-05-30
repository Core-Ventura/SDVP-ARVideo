# SDVP-ARVideo
He usado el [*AR Foundation 4.0*](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.0/manual/index.html) y utilizado la escena de TooglePlaneDetection como base de la actividad, ya que presentaba el mismo setup expuesto en la guía de la actividad. Todos los recursos generados y utilizados los podemos encontrar en la carpeta Activity Resources.

En la escena, he añadido un componente de Video Player y llevado su salida a un Render Texture. He creado un material, al cual le he asignado dicho Render Texture y se lo he aplicado a los planos a instanciar a modo de pantalla.

Para la creación de objetos, he utilizado el ARRaycastManager y el Input.GetTouch, mediante los cuales obtenía la posición y rotación de instanciación del plano con el vídeo.
