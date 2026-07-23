Algoritmo lecc35_act1_inc3
	Definir opcionUsuario, opcionComp Como Entero
	Definir respuesta Como Caracter
	
	Repetir
		Escribir "--- PIEDRA, PAPEL O TIJERA ---"
		Escribir "1. Piedra"
		Escribir "2. Papel"
		Escribir "3. Tijera"
		Escribir "Seleccione su opcion (1-3):"
		Leer opcionUsuario
		
		Si opcionUsuario >= 1 Y opcionUsuario <= 3 Entonces
			opcionComp <- Aleatorio(1, 3)
			
			Escribir ""
			Segun opcionComp Hacer
				1:
					Escribir "La computadora eligio: Piedra"
				2:
					Escribir "La computadora eligio: Papel"
				3:
					Escribir "La computadora eligio: Tijera"
			FinSegun
			
			Si opcionUsuario = opcionComp Entonces
				Escribir "?Es un empate!"
			Sino
				Si (opcionUsuario = 1 Y opcionComp = 3) O (opcionUsuario = 2 Y opcionComp = 1) O (opcionUsuario = 3 Y opcionComp = 2) Entonces
					Escribir "?Felicidades, ganaste!"
				Sino
					Escribir "?Gana la computadora!"
				FinSi
			FinSi
		Sino
			Escribir "Opcion no valida."
		FinSi
		
		Escribir ""
		Escribir "Desea jugar de nuevo? (s/n):"
		Leer respuesta
		Escribir ""
	Hasta Que respuesta = "n" O respuesta = "N"
FinAlgoritmo