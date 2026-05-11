Algoritmo act2pag67inc1
	Definir i, j, divisores, suma, contadorPrimos Como Entero
    suma = 0
    contadorPrimos = 0
    i = 1
    
    Repetir
        divisores = 0
        j = 1
        Repetir
            Si i % j = 0 Entonces
                divisores = divisores + 1
            FinSi
            j = j + 1
        Hasta Que j > i
        
        Si divisores = 2 Entonces
            Escribir "Primo: ", i
            suma = suma + i
            contadorPrimos = contadorPrimos + 1
        FinSi
        i = i + 1
    Hasta Que i > 100
    
    Escribir "Total de primos encontrados: ", contadorPrimos
    Escribir "Suma total de los primos: ", suma
	
FinAlgoritmo
