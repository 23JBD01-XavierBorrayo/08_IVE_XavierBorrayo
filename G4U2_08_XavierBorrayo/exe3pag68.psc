Algoritmo act3pag68inc1	
	Definir i, m, suma, contadorPares Como Entero
    suma = 0
    contadorPares = 0
    i = 1
    
    Repetir
        m = i * 7
        suma = suma + m
        
        Si m % 2 = 0 Entonces
            contadorPares = contadorPares + 1
        FinSi
        
        i = i + 1
    Hasta Que i > 20
    
    Escribir "La sumatoria de los 20 múltiplos es: ", suma
    Escribir "Cantidad de múltiplos que son pares: ", contadorPares
FinAlgoritmo
