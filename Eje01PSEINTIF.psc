//Voice message program
//Create Menu - 1 Reception
//2 - Vigilance
//3 - Maintenance
//4 - Error / Exit

Algoritmo jujutsukaisen
	Escribir "===Voice Message==="
	//variables
	Definir opc Como Entero
	
	//menu
	Escribir "__Main_Menu__"
	Escribir "1 - Reception"
	Escribir "2 - Vigilance"
	Escribir "3 - Maintenance"
	Escribir "4 - Error / Exit"
	Escribir Sin Saltar "Write a number: "
	leer opc
	
	//conditions
	Si (opc == 1) Entonces
		Escribir "Welcome to Reception"
	    Escribir "Press any key"
	    Esperar Tecla
	    Escribir "Thanks for waiting us"
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	Si (opc == 2) Entonces
		Escribir "Welcome to Vigilance Zone"
	    Escribir "Press any key"
	    Esperar Tecla
	    Escribir "Thanks for waiting us"
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	Si (opc == 3) Entonces
		Escribir "Welcome to Maintenance Dep."
	    Escribir "Press any key"
	    Esperar Tecla
	    Escribir "Thanks for waiting us"
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	
	Si (opc <> 1 y opc <> 2 y opc <> 3 y opc <> 4) Entonces
		Escribir "Closing the system"
	    Escribir "Press any key for exit"
	    Esperar Tecla
	    Escribir "Thanks for waiting us"
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	
FinAlgoritmo
