Feature: Estados de CarToGo

Scenario: Validar que se encuentra un estado
	Given ingresar el estado null
	When buscar el estado
	Then muestra el estado "No se encontro este Estado"

Scenario: Validar que se encuentra un estado para actualizar
	Given ingresar el estado null
	When actualizar el estado
	Then muestra el estado "No se encontro este Estado"

	
Scenario: Validar que se encuentra un estado para eliminar
	Given ingresar el estado null
	When eliminar el estado
	Then muestra el estado "No se encontro este Estado"
