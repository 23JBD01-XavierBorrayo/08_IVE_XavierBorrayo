Algoritmo act3pag97inc1
	Definir acumuladorPrimos, i, j, divisores Como Entero
    acumuladorPrimos = 0
    
    Escribir "Calculando la suma de números primos entre 1 y 50..."
    
    Para i = 2 Hasta 50 Hacer
        divisores = 0
        Para j = 1 Hasta i Hacer
            Si i % j = 0 Entonces
                divisores = divisores + 1
            FinSi
        FinPara
        
        Si divisores = 2 Entonces
            Escribir "Primo encontrado: ", i
            acumuladorPrimos = acumuladorPrimos + i
        FinSi
    FinPara
    
    Escribir "La suma total de los números primos es: ", acumuladorPrimos
FinAlgoritmo
