Feature: Fotografias de CarToGo 

Scenario: Validar que se encuentra una fotografia
	Given ingresar la fotografia null
	When buscar la fotografia
	Then lo que muestra "No se encontraron las Fotografias"

Scenario: Validar que se encuentra una fotografia para actualizar
	Given postear la fotografia null
	When ingresar la fotografia
	Then devuelve "No se encontraron las Fotografias"

Scenario: Validar que se encuentra una fotografia para eliminar
	Given ingresar la fotografia null
	When eliminar la fotografia
	Then devuelve "No se encontraron las Fotografias"







