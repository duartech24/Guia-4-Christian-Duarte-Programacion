Algoritmo lecc32_act2_inc1
	Definir dia, mes Como Entero
	
	Escribir "Ingrese su dia de nacimiento (1-31):"
	Leer dia
	Escribir "Ingrese su mes de nacimiento (1-12):"
	Leer mes
	
	Escribir "--SU RESULTADO--"
	
	Si (mes = 1 Y dia >= 20) O (mes = 2 Y dia <= 18) Entonces
		Escribir "Signo: Acuario"
		Escribir "Horoscopo: Tu creatividad e innovacion te abriran nuevas puertas hoy."
	Sino
		Si (mes = 2 Y dia >= 19) O (mes = 3 Y dia <= 20) Entonces
			Escribir "Signo: Piscis"
			Escribir "Horoscopo: Confia en tu intuicion, te guiara por el camino correcto."
		Sino
			Si (mes = 3 Y dia >= 21) O (mes = 4 Y dia <= 19) Entonces
				Escribir "Signo: Aries"
				Escribir "Horoscopo: Tu energia y dinamismo te ayudaran a superar cualquier reto."
			Sino
				Si (mes = 4 Y dia >= 20) O (mes = 5 Y dia <= 20) Entonces
					Escribir "Signo: Tauro"
					Escribir "Horoscopo: La paciencia y perseverancia seran tus mejores aliadas."
				Sino
					Si (mes = 5 Y dia >= 21) O (mes = 6 Y dia <= 20) Entonces
						Escribir "Signo: Geminis"
						Escribir "Horoscopo: Excelente dia para comunicarse y compartir ideas."
					Sino
						Si (mes = 6 Y dia >= 21) O (mes = 7 Y dia <= 22) Entonces
							Escribir "Signo: Cancer"
							Escribir "Horoscopo: Conecta con tus seres queridos y disfruta de la armonia."
						Sino
							Si (mes = 7 Y dia >= 23) O (mes = 8 Y dia <= 22) Entonces
								Escribir "Signo: Leo"
								Escribir "Horoscopo: Tu liderazgo natural brillara en cada proyecto."
							Sino
								Si (mes = 8 Y dia >= 23) O (mes = 9 Y dia <= 22) Entonces
									Escribir "Signo: Virgo"
									Escribir "Horoscopo: La organizacion te llevara a alcanzar tus metas."
								Sino
									Si (mes = 9 Y dia >= 23) O (mes = 10 Y dia <= 22) Entonces
										Escribir "Signo: Libra"
										Escribir "Horoscopo: Busca el equilibrio y la paz en tus relaciones."
									Sino
										Si (mes = 10 Y dia >= 23) O (mes = 11 Y dia <= 21) Entonces
											Escribir "Signo: Escorpio"
											Escribir "Horoscopo: Tu determinacion te permitira vencer cualquier obstaculo."
										Sino
											Si (mes = 11 Y dia >= 22) O (mes = 12 Y dia <= 21) Entonces
												Escribir "Signo: Sagitario"
												Escribir "Horoscopo: Un espiritu aventurero te llevara a vivir nuevas experiencias."
											Sino
												Si (mes = 12 Y dia >= 22) O (mes = 1 Y dia <= 19) Entonces
													Escribir "Signo: Capricornio"
													Escribir "Horoscopo: Tu disciplina dara frutos muy pronto."
												Sino
													Escribir "Fecha no valida."
												FinSi
											FinSi
										FinSi
									FinSi
								FinSi
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo