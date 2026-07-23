Algoritmo lecc35_act1_inc1
	Definir cantidadLocal, usd, eur, mxn, gbp, jpy Como Real
	Definir respuesta Como Caracter
	
	Repetir
		Escribir "Ingrese la cantidad en moneda local:"
		Leer cantidadLocal
		
		usd <- cantidadLocal * 0.13
		eur <- cantidadLocal * 0.12
		mxn <- cantidadLocal * 2.50
		gbp <- cantidadLocal * 0.10
		jpy <- cantidadLocal * 19.50
		
		Escribir "--- EQUIVALENCIAS ---"
		Escribir "1. Estados Unidos (USD): ", usd
		Escribir "2. Union Europea (EUR): ", eur
		Escribir "3. Mexico (MXN): ", mxn
		Escribir "4. Reino Unido (GBP): ", gbp
		Escribir "5. Japon (JPY): ", jpy
		
		Escribir ""
		Escribir "Desea convertir otra cantidad? (s/n):"
		Leer respuesta
	Hasta Que respuesta = "n" O respuesta = "N"
FinAlgoritmo