Algoritmo act3pag97inc2
	Definir n, i, sumaTotal Como Entero
    sumaTotal = 0
    
    Escribir "Ingrese un número:"
    Leer n
    
    Escribir "Cuenta regresiva:"
    
    Para i = n Hasta 1 Con Paso -1 Hacer
        Escribir i
        sumaTotal = sumaTotal + i
    FinPara
    
    Escribir "etc."
    Escribir "La suma es ", sumaTotal, "."
	
FinAlgoritmo
