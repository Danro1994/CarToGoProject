Feature: Car-To-Go BDD

Scenario: Validar que se encuentra una marca
	Given ingresar la marca null
	When busca la marca
	Then el resultado debe ser "No se encontro la Marca"