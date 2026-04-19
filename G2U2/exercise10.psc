Algoritmo ejercicio10
	Definir c, oo Como Entero
    Definir p, i, pii Como Real
    Definir tsd, d, md, tp Como Real
    
    p = 650
    i = 0.12
    
    Escribir "Cantidad de impresoras:"
    Leer c
    
    pii = p + (p * i)
    
    Escribir "Forma de pago:"
    Escribir "1. Efectivo (10%)"
    Escribir "2. Tarjeta (5%)"
    Escribir "3. Vale (15%)"
    Leer oo
	
	Segun oo Hacer
		1:
            d = 0.10
        2:
            d = 0.05
        3:
            d = 0.15
        De Otro Modo:
            Escribir "Opcion invalida"
	Fin Segun
	
	tsd = pii * c
    md = tsd * d
    tp = tsd - md

    Escribir "Cantidad: ", c
    Escribir "Precio con IVA: Q", pii
    Escribir "Total sin descuento: Q", tsd
    Escribir "Descuento: Q", md
    Escribir "Total a pagar: Q", tp
	
FinAlgoritmo
