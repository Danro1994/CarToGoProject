Feature: Condicion de CarToGo

Scenario: Validar que se encuentra una condicion
	Given ingresar la condicion null
	When busca la condicion
	Then la respuesta es "No se encontro la Condicion"

Scenario: Validar que se encuentra una condicion para actualizar
	Given ingresar la condicion null
	When actualizar la condicion
	Then la respuesta es "No se encontro la Condicion"

Scenario: Validar que se encuentra una condicion para eliminar
	Given ingresar la condicion null
	When eliminar la condicion
	Then la respuesta es "No se encontro la Condicion"



