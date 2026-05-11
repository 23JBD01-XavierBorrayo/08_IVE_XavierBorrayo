Algoritmo act1pag65inc1
	Definir tb, oo Como Entero
	Definir td Como Real
	tb = 0
	td = 0
	Repetir
        Escribir "Tipo de boleto: 1. Adulto ($15) 2. Niño ($10) 3. Cerrar caja"
        Leer opcion
        
        Si opcion = 1 Entonces
            tb = tb + 1
            td = td + 15
        FinSi
        
        Si opcion = 2 Entonces
            tb <- tb + 1
            td <- td + 10
        FinSi
        
        Escribir "Ventas actuales: ", tb, " boletos. Total: $", td
        
    Hasta Que opcion = 3
    
    Escribir "Cierre de caja final:"
    Escribir "Boletos vendidos: ", tb
    Escribir "Dinero recaudado: $", td
FinAlgoritmo
