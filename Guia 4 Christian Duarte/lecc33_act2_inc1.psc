Algoritmo lecc33_act2_inc1
	Definir frase, fraseInvertida Como Cadena
	Definir i, longitudFrase Como Entero
	
	Escribir "Ingrese una frase:"
	Leer frase
	
	fraseInvertida <- ""
	longitudFrase <- Longitud(frase)
	
	Para i <- longitudFrase Hasta 1 Con Paso -1 Hacer
		fraseInvertida <- fraseInvertida + Subcadena(frase, i, i)
	FinPara
	
	Escribir "--- RESULTADO ---"
	Escribir "Frase invertida: ", fraseInvertida
FinAlgoritmo