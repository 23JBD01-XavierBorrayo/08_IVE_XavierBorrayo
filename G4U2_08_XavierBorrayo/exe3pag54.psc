Algoritmo act3pag54inc1
	Definir n1,n2,me,ma,i,s Como Entero
	s = 0
	Escribir "Ingrese su primer numero:"
	Leer n1
	Escribir "Ingrese su segundo su numero:"
	Leer n2
	
	Si n1 < n2 Entonces
		n1 = me
		n2 = ma
	SiNo
		n1 = me
		n2 = ma
	Fin Si
	
	i = me
	Repetir
		s = s+i
		i = i+1
	Hasta Que i > ma
	Escribir "La suma es:",s
FinAlgoritmo
