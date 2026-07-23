Algoritmo lecc34_act1_inc2
	Definir peso, altura, imc Como Real
	
	Escribir "Ingrese su peso en kilogramos (kg):"
	Leer peso
	Escribir "Ingrese su altura en metros (m):"
	Leer altura
	
	imc <- peso / (altura * altura)
	
	Escribir "--- RESULTADO ---"
	Escribir "Su Indice de Masa Corporal (IMC) es: ", imc
	
	Si imc < 18.5 Entonces
		Escribir "Clasificacion: Bajo peso"
	Sino
		Si imc >= 18.5 Y imc < 25 Entonces
			Escribir "Clasificacion: Peso normal"
		Sino
			Si imc >= 25 Y imc < 30 Entonces
				Escribir "Clasificacion: Sobrepeso"
			Sino
				Escribir "Clasificacion: Obesidad"
			FinSi
		FinSi
	FinSi
FinAlgoritmo