Algoritmo lecc34_act1_inc3
	Definir centigrados, resultado Como Real
	Definir opcion Como Caracter
	
	Escribir "Ingrese la temperatura en grados centigrados:"
	Leer centigrados
	
	Escribir "--- MENU DE CONVERSION ---"
	Escribir "a. Fahrenheit"
	Escribir "b. Celsius"
	Escribir "c. Kelvin"
	Escribir "Seleccione una opcion (a-c):"
	Leer opcion
	
	Segun opcion Hacer
		'a', 'A':
			resultado <- (centigrados * 9 / 5) + 32
			Escribir centigrados, " ?C equivalen a ", resultado, " ?F."
		'b', 'B':
			resultado <- centigrados
			Escribir centigrados, " ?C equivalen a ", resultado, " ?C."
		'c', 'C':
			resultado <- centigrados + 273.15
			Escribir centigrados, " ?C equivalen a ", resultado, " K."
		De Otro Modo:
			Escribir "Opcion no valida."
	FinSegun
FinAlgoritmo