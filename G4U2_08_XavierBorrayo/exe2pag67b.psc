Algoritmo act2pag67inc2
	Definir numBillete, denominacion, contador100, suma100 Como Entero
    contador100 = 0
    suma100 = 0
    numBillete = 1
    
    Repetir
        Escribir "Billete #", numBillete, " - Ingrese denominación ($20, $50, $100):"
        Leer denominacion
        
        Si denominacion = 100 Entonces
            contador100 = contador100 + 1
            suma100 = suma100 + 100
        FinSi
        
        numBillete = numBillete + 1
    Hasta Que numBillete > 1000
    
    Escribir "Total de billetes de $100: ", contador100
    Escribir "Dinero total en billetes de $100: $", suma100
FinAlgoritmo
