Feature: Modelos de CarToGo

Scenario: Validar que se encuentra el modelo
	Given ingresar el modelo null
	When buscar el modelo
	Then muestra el modelo "No se encuentra el Modelo"

Scenario: Validar que se encuentra el modelo para actualizar
	Given ingresar el modelo null
	When actualizar el modelo
	Then muestra el modelo "No se encuentra el Modelo"

Scenario: Validar en el modelo la marca vacia para actualizar
	Given ingresar en el modelo la marca null
	When actualizar la marca null
	Then muestra el modelo "No se encuentra la Marca"

Scenario: Postear un modelo con marca vacia
	Given ingresar marca vacia
	When postear el modelo
	Then muestra el modelo "No se encuentra la Marca"

Scenario: Validar que se encuentra el modelo para eliminar
	Given ingresar el modelo null
	When eliminar el modelo
	Then muestra el modelo "No se encuentra el Modelo"

