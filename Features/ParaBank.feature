Feature: ParaBank

Testing SignUp Functionality

@RergressionTest
Scenario: SignUp Page Test
	Given I'm on Parabank signUp page
	When I enter the following details 
	| firstName | lastName | address        | city       | state | zipCode |   phone        | ssn        | userName         |  password   | confirm      |  
	|   Daniel  | Kirkstal | 5 London Road  | London     | UK    | SE12 6TW|  08475548124   | SA345341D  |  daniel@123.com  |  danile123  |  daniel123   |  
	And I click Register
	Then my account is created successfully
