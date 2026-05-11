Algoritmo act2pag53inc1
	Definir n,f,i Como Entero
	Escribir "Ingresa un numero: " Sin Saltar
	Leer n
	f = 1
	i = 1
	
	Si n < 0 Entonces
		Escribir "No existe factorial de negativos"
	SiNo
		Repetir
			f = f*i
			i = i+1
		Hasta Que i > n
		Escribir "El factrorial es: ", f
	Fin Si
FinAlgoritmo
