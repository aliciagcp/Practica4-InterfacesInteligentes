# Practica4-InterfacesInteligentes
## Delegados - Eventos
### Alicia Guadalupe Cruz Pérez
Se han realizado varios ejercicios de eventos en unity:

- **a) Se pide que a partir de la escena que se ha estado utilizando en las [últimas prácticas](https://github.com/aliciagcp/Practica3-InterfacesInteligentes.git), crear la siguiente mecánica. Cuando el cubo colisiona con el cilindro, las esferas de tipo 1 cambian su color y las esferas de tipo 2 se desplazan hacia el cilindro.**

![ejercicio_1](gifs/ejercicio_1.gif)

Notificador: [script](scripts/ejercicio1/Cylinder.cs)
Observador: [script](scripts/ejercicio1/SpheresGroup1.cs)
Observador: [script](scripts/ejercicio1/SpheresGroup2.cs)

<br><br>

- **b) Se pide adaptar la escena anterior para que:**
   + **Cuando el cubo colisiona con cualquier objeto que no sean esferas del grupo 1, las esferas en el grupo 1 se acercan al cilindro.**
   + **Cuando el cubo toca cualquier esfera del grupo 1, las esferas del grupo 2 aumentan de tamaño.**

![ejercicio_2](gifs/ejercicio_2.gif)

Notificador: [script](scripts/ejercicio1/Cube.cs)
Observador: [script](scripts/ejercicio1/SpheresGroup1_2.cs)
Observador: [script](scripts/ejercicio1/SpheresGroup2_2.cs)

<br><br>

- **c) Se pide que cuando el cubo se aproxime al cilindro, las esferas del grupo 1 cambien su color y salten y las esferas del grupo 2 se orienten hacia un objeto ubicado en la escena con ese propósito.**

![ejercicio_3](gifs/ejercicio_3.gif)

Para ello se han seguido los siguientes pasos:
1. Creación de un [script](scripts/ejercicio1_script.cs) asociado al cubo (Ejercicio1_3).
   
Dentro del script:


<br><br>

