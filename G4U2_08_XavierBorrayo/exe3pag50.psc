Algoritmo act3pag50inc1
	Definir suma, i, j, divisores Como Entero
    suma = 0
    
    Para i <- 1 Hasta 22 Hacer
        divisores = 0
        Para j = 1 Hasta i Hacer
            Si i % j = 0 Entonces
                divisores = divisores + 1
            FinSi
        FinPara
        
        Si divisores = 2 Entonces
            suma = suma + i
            Escribir "Encontrado primo: ", i
        FinSi
    FinPara
    
    Escribir "La suma de los números primos entre 1 y 22 es: ", suma
FinAlgoritmo
