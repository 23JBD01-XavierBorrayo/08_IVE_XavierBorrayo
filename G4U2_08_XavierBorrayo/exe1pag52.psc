Algoritmo act1pag52inc1
	Definir cm, au, d Como Entero
	cm = 200
	au = 0
	Repetir
		d = cm - au
		Escribir "Lugares disponibles: ", d
		
		Escribir "Presiona una tecla para registrar un auto..."
		Leer tecla
		
		au = au+1
	Hasta Que au == cm
	
	Escribir "Ya no hay cajones libres."
	
FinAlgoritmo
