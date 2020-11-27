Feature: Marca de CarToGo

Scenario: Validar que se encuentra una marca
	Given ingresar la marca null
	When busca la marca
	Then el resultado debe ser "No se encontro la Marca"

Scenario: Validar que se encuentra una marca para actualizar
	Given ingresar la marca null
	When actualizar la marca
	Then el resultado debe ser "No se encontro la Marca"

Scenario: Validar que se encuentra una marca para eliminar
	Given ingresar la marca null
	When eliminar la marca
	Then el resultado debe ser "No se encontro la Marca"




