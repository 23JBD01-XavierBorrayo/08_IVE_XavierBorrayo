Algoritmo ejercicio8
	Escribir "===EJERCICIO #8==="
	
	Definir oo Como Entero
    Definir v, r Como Real
    
    Escribir "Ingrese valor:"
    Leer v
    
    Escribir "Seleccione unidad destino:"
    Escribir "1. Metros"
    Escribir "2. Pies"
    Escribir "3. Centimetros"
    Escribir "4. Pulgadas"
    Leer oo
	
	Segun oo Hacer
		1:
            r = v 
        2:
            r = v * 3.28084
        3:
            r = v * 100
        4:
            r = v * 39.3701
        De Otro Modo:
            Escribir "Opcion invalida"
	Fin Segun
    
Escribir "Resultado: ", r
	
FinAlgoritmo
