Algoritmo act2pag45inc1
	Definir mg, mt Como Real
	mt = 0
	Escribir "===NIVEL 5 BLOQUEADO==="
	
	Mientras mt < 350 Hacer
		Escribir "Tienes: ", mt, " Monedas, sigue jugando!"
		Escribir "Cuantas monedas ganaste ahora?"
		Leer mg
		
		mt = mt + mg
	Fin Mientras
	
	Escribir "DESBLOQUEASTE EL NIVEL 5 FELICIDADES!"
FinAlgoritmo
