Algoritmo actividad01
	
	Escribir "===BASE DE DATOS DE NOTAS==="
	//variables
	Definir n1 Como Entero
	Definir n2 Como Entero
	Definir n3 Como Entero
	Definir n4 Como Entero
	Definir n5 Como Entero
	
	//menu
	Escribir "__PROMEDIO NOTAS__"
	Escribir "Escribe la Materia: "
	leer materia;
	Esperar 3 Segundos
	Escribir sin Saltar "Digite 5 Notas"
	Escribir " - Nota 1: "
	leer n1
	Escribir "Espera un momento..."
	Esperar 3 Segundos
	Escribir "-Nota 2: "
	leer n2
	Escribir "Espera un momento..."
	Esperar 3 Segundos
	Escribir "-Nota 3: "
	leer n3
	Escribir "Espera un momento..."
	Esperar 3 Segundos
	Escribir "-Nota 4: "
	leer n4
	Esperar 3 Segundos
	Escribir "Espera un momento..."
	Escribir "-Nota 5: "
	leer n5
	resultado = (n1+n2+n3+n4+n5)/5
	Escribir "Cargando Notas."
	Esperar 1 Segundos
	Escribir "Cargando Notas.."
	Esperar 1 Segundos
	Escribir "Cargando Notas..."
	Esperar 1 Segundos
	
	//conditions
	Si ( resultado >= 70) Entonces
		Escribir "ESTAS APROBADO"
	    Escribir "Presiona cualquier tecla"
	    Esperar Tecla
	    Escribir "Gracias por entrar a la BASE DE DATOS"
		Limpiar Pantalla
		Esperar 3 Segundos
	SiNo
		Escribir "ESTAS REPROBADO"
	    Escribir "Presiona cualquier tecla"
	    Esperar Tecla
	    Escribir "Gracias por entrar a la BASE DE DATOS"
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	Escribir "Materia: ", materia
	Escribir "Promedio: ", resultado
	
FinAlgoritmo
