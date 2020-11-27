Feature: Vendedor de CarToGo 

Scenario: Validar que se encuentra un vendedor
	Given ingresar el vendedor null
	When buscar vendedor
	Then lo que encuentra "No se encontro el Vendedor"

Scenario: Validar que se encuentra un vendedor para actualizar
	Given ingresar el vendedor null
	When actualizar vendedor
	Then lo que encuentra "No se encontro el Vendedor"

Scenario: Validar que se encuentra un vendedor eliminar
	Given ingresar el vendedor null
	When eliminar vendedor
	Then lo que encuentra "No se encontro el Vendedor"




