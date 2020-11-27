Feature: Car de CarToGo

Scenario: Validar que se encuentra el carro
	Given ingresar el carro null
	When buscar el carro
	Then debe mostrar "No se Encontro el Vehiculo"

Scenario: Postear un carro cuando el modelo no existe
	Given ingresar el carro con modelo vacio
	When postear el carro con modelo vacio
	Then debe mostrar "El Modelo no existe"

Scenario: Postear un carro cuando no existen fotografias
	Given ingresar el carro sin fotografias
	When postear el carro sin fotografias
	Then debe mostrar "Estas fotografias no estan registradas"

Scenario: Postear un carro cuando el estado no existe
	Given ingresar el carro sin estado
	When postear el carro sin estado
	Then debe mostrar "El Estado no existe"

Scenario: Postear un carro cuando el vendedor no existe
	Given ingresar el carro sin vendedor
	When postear el carro sin vendedor
	Then debe mostrar "El Vendedor no existe"

Scenario: Postear un carro cuando la condicion no existe
	Given ingresar el carro sin condicion
	When postear el carro sin condicion
	Then debe mostrar "La Condicion no existe"

Scenario: Postear un carro cuando el anio sea 1990 o inferior
	Given ingresar el carro con anio 1990
	When postear con anio inferior
	Then debe mostrar "El vehiculo debe ser año 1990 en adelante"

Scenario: Actualizar cuando el carro no existe
	Given actualizar cuando el carro no existe
	When  actualizar el carro 
	Then debe mostrar "No se encuentra el Vehiculo"


Scenario: Actualizar cuando el modelo del carro no existe
	Given actualizar modelo del carro 
	When  actualizar el modelo no encontrado
	Then debe mostrar "El Modelo no existe"

Scenario: Actualizar cuando el carro no tiene fotografias registradas
	Given un carro sin fotografias
	When  actualizar carro sin fotografias
	Then debe mostrar "Estas fotografias no estan registradas"

Scenario: Actualizar cuando el carro no tiene estado
	Given un carro sin estado
	When  actualizar carro sin estado
	Then debe mostrar "El Estado no existe"

Scenario: Actualizar el carro cuando no existe el vendedor
	Given un carro sin vendedor
	When  actualizar carro sin vendedor
	Then debe mostrar "El Vendedor no existe"

Scenario: Actualizar el carro cuando no existe condicion
	Given un carro sin condicion
	When  actualizar carro sin condicion
	Then debe mostrar "La Condicion no existe"

Scenario: Actualizar un carro cuando el anio sea 1990 o inferior
	Given actualizar el carro con anio 1990
	When actualizar con anio inferior
	Then debe mostrar "El vehiculo debe ser año 1990 en adelante"

Scenario: Validar que se encuentra el carro para eliminarlo
	Given ingresar el carro null
	When eliminar el carro
	Then debe mostrar "No se encuentra el Vehiculo"
#
#Scenario: Validar que se encuentra el modelo para actualizar
#	Given ingresar el modelo null
#	When actualizar el modelo
#	Then muestra el modelo "No se encuentra el Modelo"
#
#Scenario: Validar en el modelo la marca vacia para actualizar
#	Given ingresar en el modelo la marca null
#	When actualizar la marca null
#	Then muestra el modelo "No se encuentra la Marca"
#
#Scenario: Postear un modelo con marca vacia
#	Given ingresar marca vacia
#	When postear el modelo
#	Then muestra el modelo "No se encuentra la Marca"
#
#Scenario: Validar que se encuentra el modelo para eliminar
#	Given ingresar el modelo null
#	When eliminar el modelo
#	Then muestra el modelo "No se encuentra el Modelo"

