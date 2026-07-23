Algoritmo lecc32_act3_inc3
	Definir lado1, lado2, lado3 Como Real
	
	Escribir "Ingrese la medida del primer lado:"
	Leer lado1
	Escribir "Ingrese la medida del segundo lado:"
	Leer lado2
	Escribir "Ingrese la medida del tercer lado:"
	Leer lado3
	
	Escribir "-RESULTADO-"
	
	Si (lado1 + lado2 > lado3) Y (lado1 + lado3 > lado2) Y (lado2 + lado3 > lado1) Entonces
		Si lado1 = lado2 Y lado2 = lado3 Entonces
			Escribir "El triangulo es Equilatero."
		Sino
			Si lado1 = lado2 O lado1 = lado3 O lado2 = lado3 Entonces
				Escribir "El triangulo es Isosceles."
			Sino
				Escribir "El triangulo es Escaleno."
			FinSi
		FinSi
	Sino
		Escribir "Las medidas ingresadas no forman un triangulo valido."
	FinSi
FinAlgoritmo