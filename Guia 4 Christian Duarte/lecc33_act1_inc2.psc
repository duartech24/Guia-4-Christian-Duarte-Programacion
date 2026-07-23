Algoritmo lecc33_act1_inc1
	Definir nombres, telefonos Como Cadena
	Dimension nombres[10]
	Dimension telefonos[10]
	Definir i, posicion Como Entero
	
	Escribir "--- REGISTRO DE 10 CONTACTOS ---"
	Para i <- 0 Hasta 9 Hacer
		Escribir "Contacto ", i + 1, ":"
		Escribir "Ingrese el nombre:"
		Leer nombres[i]
		Escribir "Ingrese el telefono:"
		Leer telefonos[i]
	FinPara
	
	Escribir ""
	Escribir "Ingrese la posicion del contacto a consultar (1 a 10):"
	Leer posicion
	
	Si posicion >= 1 Y posicion <= 10 Entonces
		Escribir "--- DATOS DEL CONTACTO ---"
		Escribir "Nombre: ", nombres[posicion - 1]
		Escribir "Telefono: ", telefonos[posicion - 1]
	Sino
		Escribir "Posicion no valida. Debe ser entre 1 y 10."
	FinSi
FinAlgoritmo