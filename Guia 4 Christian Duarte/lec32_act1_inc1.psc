Algoritmo lecc32_act1_inc1
	Definir metros, resultado Como Real
	Definir opcion Como Caracter
	
	Escribir "Ingrese la cantidad en metros:"
	Leer metros
	
	Escribir "---MENU DE CONVERSION---"
	Escribir "a. Milimetros"
	Escribir "b. Centimetros"
	Escribir "c. Decimetros"
	Escribir "d. Hectometros"
	Escribir "e. Kilometros"
	Escribir "Seleccione una opcion entre a-e:"
	Leer opcion
	
	Segun opcion Hacer
		'a', 'A':
			resultado <- metros * 1000
			Escribir metros, " metros equivalen a ", resultado, " milimetros."
		'b', 'B':
			resultado <- metros * 100
			Escribir metros, " metros equivalen a ", resultado, " centimetros."
		'c', 'C':
			resultado <- metros * 10
			Escribir metros, " metros equivalen a ", resultado, " decimetros."
		'd', 'D':
			resultado <- metros / 100
			Escribir metros, " metros equivalen a ", resultado, " hectometros."
		'e', 'E':
			resultado <- metros / 1000
			Escribir metros, " metros equivalen a ", resultado, " kilometros."
		De Otro Modo:
			Escribir "Opcion no valida."
	FinSegun
FinAlgoritmo