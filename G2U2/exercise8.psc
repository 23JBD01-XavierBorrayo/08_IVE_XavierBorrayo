Algoritmo ejercicio8
	Escribir "===EJERCICIO #8==="
	
	Definir oo, c Como Entero
    Definir p, t Como Real
    
	Escribir "1. Palco (Q300)"
    Escribir "2. Tribuna (Q100 - Q125)"
    Escribir "3. Preferencia (Q50 - Q75)"
    Escribir "4. Generales (Q30 - Q50)"
    Escribir "Seleccione un sector :"
    Leer oo
	
	Segun oo Hacer
		1:
			p = 300
		2:
			p = 100
		3:
			p = 50
		4:
			p = 30 
		De Otro Modo:
			Escribir "Invalido"
	Fin Segun
	
	Escribir "Cantidad de entradas: " Sin Saltar
	Leer c
	
	t = p * c
	
	Escribir "Total a pagar: ", t
FinProceso

	
    
	
