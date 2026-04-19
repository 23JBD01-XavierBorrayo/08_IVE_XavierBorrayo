Algoritmo ejericio6
	Escribir "===EJERCICIO #6==="
	Definir a, b, c Como Real
	Definir s, cc, t, r Como Real
	
	Escribir "Escriba el lado A"
	Leer a
	Escribir "Escriba el lado B"
	Leer b
	Escribir "Escriba el lado C"
	Leer c
	
	s = a/c
	cc = b/c
	t = a/b
	
	Escribir "1-Seno"
	Escribir "2-Coseno"
	Escribir "3-Tangente"
	
	Escribir "Escriba el numero que desee para su operacion..." Sin Saltar
	Leer r
	
	Segun r Hacer
		1:
			Escribir s
		2:
			Escribir cc
		3:
			Escribir t
		De Otro Modo:
			Escribir "Escriba un numero valido..."
	Fin Segun
FinAlgoritmo
