Algoritmo ejercicio2
	Escribir "===EJERCICIO #2==="
	Definir n1, n2 Como Real
	Definir r Como Real
	Escribir "Digite su primer numero: " Sin Saltar
	Leer n1
	Escribir "Digite su segundo numero: " Sin Saltar
	Leer n2
	Escribir "1-Suma"
	Escribir "2-Resta"
	Escribir "3-Multiplicacion"
	Escribir "4-Division"
	Escribir "Escriba un numero del 1-4 para su ecuacion: "
	Leer r
	
	Segun r Hacer
		1:
			Escribir "Suma: ",n1+n2
		2:
			Escribir "Resta: ",n1-n2
		3:
			Escribir "Multi: ",n1*n2
		4:
			Escribir "Division: ",n1/n2
		De Otro Modo:
			Escribir "Digite numeros validos"
	Fin Segun
FinAlgoritmo
