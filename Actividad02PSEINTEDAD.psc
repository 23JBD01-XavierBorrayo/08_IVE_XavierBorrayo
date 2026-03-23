Algoritmo actividad01
	
	Escribir "===BASE DE DATOS DE EDAD==="
	//variables
	Definir edad Como Entero
	
	//menu
	Escribir "__¿ERES APTO?__"
	Escribir "Escribe tu edad: "
	leer edad;
	Esperar 3 Segundos
	Escribir "El usuario ha escrito que tiene: ", edad
	//conditions
	Si ( edad >= 18) Entonces
		Escribir "ERES MAYOR DE EDAD"
	    Escribir "Presiona cualquier tecla"
	    Esperar Tecla
	    Escribir "Gracias por entrar a la BASE DE DATOS"
		Limpiar Pantalla
		Esperar 3 Segundos
	SiNo
		Escribir "ERES MENOR DE EDAD"
	    Escribir "Presiona cualquier tecla"
	    Esperar Tecla
	    Escribir "Gracias por entrar a la BASE DE DATOS"
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
FinAlgoritmo
