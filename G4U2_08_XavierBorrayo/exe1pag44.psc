Algoritmo act1pag44inc1
	Definir pm, pt Como Real
	pt = 0
	
	Escribir "Compra 1kg de manzanitas."
	
	Mientras pt < 1 Hacer
		Escribir "Coloca una manzana en la bascula"
		Escribir "Indica el peso de la manzana en kg"
		Leer pm
		
		pt = pt + pm
		
		Si pt < 1 Entonces
			Escribir "Peso Actual", pt, "kg Aun Falta para el kg"
		Fin Si
	Fin Mientras
	Escribir "Listo! El peso total es: ", pt
	
FinAlgoritmo
