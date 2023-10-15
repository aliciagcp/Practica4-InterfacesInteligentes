# Practica4-InterfacesInteligentes
## Delegados - Eventos
### Alicia Guadalupe Cruz Pérez
Se han realizado varios ejercicios de eventos en unity:

- **a) A partir de la escena que se ha estado utilizando en las [últimas prácticas](https://github.com/aliciagcp/Practica3-InterfacesInteligentes.git), crear la siguiente mecánica. Cuando el cubo colisiona con el cilindro, las esferas de tipo 1 cambian su color y las esferas de tipo 2 se desplazan hacia el cilindro.**

![ejercicio_1](gifs/ejercicio_1.gif)

Notificador: [script](scripts/ejercicio1/Cylinder.cs)
Observador: [script](scripts/ejercicio1/SpheresGroup1.cs)
Observador: [script](scripts/ejercicio1/SpheresGroup2.cs)

<br><br>

- **b) Adaptar la escena anterior para que:**
   + **Cuando el cubo colisiona con cualquier objeto que no sean esferas del grupo 1, las esferas en el grupo 1 se acercan al cilindro.**
   + **Cuando el cubo toca cualquier esfera del grupo 1, las esferas del grupo 2 aumentan de tamaño.**

![ejercicio_2](gifs/ejercicio_2.gif)

Notificador: [script](scripts/ejercicio2/Cube.cs)
Observador: [script](scripts/ejercicio2/SpheresGroup1_2.cs)
Observador: [script](scripts/ejercicio2/SpheresGroup2_2.cs)

<br><br>

- **c) Cuando el cubo se aproxima al cilindro, las esferas del grupo 1 cambian su color y saltan y las esferas del grupo 2 se orientan hacia un objeto ubicado en la escena con ese propósito.**

![ejercicio_3](gifs/ejercicio_3.gif)

Notificador: [script](scripts/ejercicio3/Notifier.cs)
Observador: [script](scripts/ejercicio3/SpheresGroup1_3.cs)
Observador: [script](scripts/ejercicio3/SpheresGroup2_3.cs)


<br><br>

