# Reloj de Lamport :alarm_clock:

>El algoritmo de los tiempos lógicos de Lamport, es un algoritmo simple usado para determinar el orden de los eventos en un Sistema Distribuido Informático. Este algoritmo se denomina así debido a que su creador fue uno de los científicos de la computación más relevantes, Leslie Lamport.
>Lamport inventó un mecanismo por el cual el orden de los sucesos puede ser expresado de forma numérica. Un reloj lógico de Lamport es un contador de software asociado a cada proceso.

## El funcionamiento del algoritmo es el siguiente:
  * Un proceso incrementa su contador antes de cada evento que ocurra en ese proceso.
  * Cuando un proceso envía un mensaje, este incluye su contador en el envío.
  * Al recibir un mensaje, se actualiza el contador del receptor si es necesario, al mayor entre su propio contador y la marca de tiempo recibida en dicho mensaje.
  
## ¿Cómo funciona el sistema?
El presente sistema contiene 3 procesos, los cuales pueden mandarse mensajes entre ellos a través de la selección de un proceso dentro de un ComboBox y presionando el botón "Enviar mensaje" de cada uno de los procesos.
Siguiendo el algoritmo de Lamport, el programa actualiza los relojes de los procesos y muestra en el historial los eventos que sucedieron.



### Acerca de
Autor: Gabriela Sandoval Cruz
Desarrollado en: .Net Framework
Fecha de creación: 07 de marzo de 2020
