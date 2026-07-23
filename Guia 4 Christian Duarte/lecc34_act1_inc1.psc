Algoritmo lecc34_act1_inc1
	Definir opcion Como Caracter
	Definir numDecimal, residuo, binarioCons, potencia, ultimoDigito, numBinario, temp, decimalRes Como Entero
	Definir textoBinario, caracterActual Como Cadena
	
	Escribir "--- MENU DE CONVERSION ---"
	Escribir "a. Convertir de Decimal a Binario"
	Escribir "b. Convertir de Binario a Decimal"
	Escribir "Seleccione una opcion (a/b):"
	Leer opcion
	
	Segun opcion Hacer
		'a', 'A':
			Escribir "Ingrese un numero decimal entero positivo:"
			Leer numDecimal
			
			temp <- numDecimal
			textoBinario <- ""
			
			Si numDecimal = 0 Entonces
				textoBinario <- "0"
			Sino
				Mientras temp > 0 Hacer
					residuo <- temp % 2
					textoBinario <- ConvertirATexto(residuo) + textoBinario
					temp <- Trunc(temp / 2)
				FinMientras
			FinSi
			
			Escribir "El numero ", numDecimal, " en binario es: ", textoBinario
			
		'b', 'B':
			Escribir "Ingrese un numero binario:"
			Leer numBinario
			
			temp <- numBinario
			decimalRes <- 0
			potencia <- 1
			
			Mientras temp > 0 Hacer
				ultimoDigito <- temp % 10
				decimalRes <- decimalRes + (ultimoDigito * potencia)
				potencia <- potencia * 2
				temp <- Trunc(temp / 10)
			FinMientras
			
			Escribir "El numero binario ", numBinario, " en decimal es: ", decimalRes
			
		De Otro Modo:
			Escribir "Opcion no valida."
	FinSegun
FinAlgoritmo