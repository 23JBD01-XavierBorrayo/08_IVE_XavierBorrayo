Algoritmo act3pag68inc2
	Definir i, j, divisores, cuentaPrimos, sumaPares Como Entero
    cuentaPrimos = 0
    sumaPares = 0
    i = 300
    
    Repetir
        Si i % 2 = 0 Entonces
            sumaPares <- sumaPares + i
        FinSi
        
        divisores <- 0
        j <- 1
        Repetir
            Si i % j = 0 Entonces
                divisores = divisores + 1
            FinSi
            j = j + 1
        Hasta Que j > i
        
        Si divisores = 2 Entonces
            cuentaPrimos = cuentaPrimos + 1
        FinSi
        
        i = i - 1
    Hasta Que i < 1
    
    Escribir "Cantidad de números primos entre 300 y 1: ", cuentaPrimos
    Escribir "Suma de todos los números pares: ", sumaPares
FinAlgoritmo
