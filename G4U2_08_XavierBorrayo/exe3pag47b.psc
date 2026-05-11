Algoritmo act3pag47inc2
	Definir n, i, d Como Entero
	d = 0
	
	Escribir "Ingrese un numero entero:"
	Leer n
	
	Para i = 1 Hasta n Hacer
		Si n % i = 0  Entonces
			d = d+1
		Fin Si
	Fin Para
	
	Si d = 2 Entonces
		Escribir n, " Es Primo"
	SiNo
		Escribir n, " NO Es Primo"
	Fin Si
FinAlgoritmo
