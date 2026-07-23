Algoritmo lecc35_act1_inc2
	Definir precio, pago, cambio, residuo Como Real
	Definir b200, b100, b50, b20 Como Entero
	Definir monedas Como Real
	
	Escribir "Ingrese el precio del producto:"
	Leer precio
	Escribir "Ingrese la cantidad recibida (pago):"
	Leer pago
	
	Si pago < precio Entonces
		Escribir "El dinero ingresado es insuficiente."
	Sino
		cambio <- pago - precio
		Escribir "CAMBIO TOTAL: ", cambio, ""
		
		residuo <- cambio
		
		b200 <- Trunc(residuo / 200)
		residuo <- residuo % 200
		
		b100 <- Trunc(residuo / 100)
		residuo <- residuo % 100
		
		b50 <- Trunc(residuo / 50)
		residuo <- residuo % 50
		
		b20 <- Trunc(residuo / 20)
		residuo <- residuo % 20
		
		monedas <- residuo
		
		Escribir "Billetes de 200: ", b200
		Escribir "Billetes de 100: ", b100
		Escribir "Billetes de 50: ", b50
		Escribir "Billetes de 20: ", b20
		Escribir "Monedas / Resto: ", monedas
	FinSi
FinAlgoritmo