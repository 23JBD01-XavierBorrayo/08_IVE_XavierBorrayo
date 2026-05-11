Algoritmo act1pag95inc1
	Definir i, m, suma, contadorPares Como Entero
    suma = 0
    contadorPares = 0
    i = 1
    
    Mientras i <= 20 Hacer
        m = i * 7
        suma <- suma + m
        
        Si m % 2 = 0 Entonces
            contadorPares = contadorPares + 1
        FinSi
        
        i = i + 1
    FinMientras
    
    Escribir "Suma total: ", suma
    Escribir "Múltiplos pares: ", contadorPares
FinAlgoritmo
