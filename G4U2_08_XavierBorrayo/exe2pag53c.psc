Algoritmo act2pag53inc3
	Definir n1, n2, me, ma Como Entero
    Leer n1, n2
    
    Si n1 < n2 Entonces
        me = n1; ma = n2
    Sino
        me = n2; ma = n1
    FinSi
    
    Escribir "Múltiplos de 4:"
    Repetir
        Si me % 4 = 0 Entonces
            Escribir me
        FinSi
        me = me + 1
    Hasta Que me > ma
FinAlgoritmo
