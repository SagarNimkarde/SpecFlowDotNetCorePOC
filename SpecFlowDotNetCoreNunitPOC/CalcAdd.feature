Feature: CalcAdd
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@calc
Scenario Outline: Add two numbers
	Given I have entered <a> into the calculator Nunit
	And I have also entered <b> into the calculator Nunit
	When I press add Nunit
	Then the result should be <c> on the screen Nunit

	Examples: 
	| a   | b   | c   |
	| 0   | 0   | 0   |
	| 10  | 20  | 30  |
	| 20  | 10  | 30  |
	| 100 | 200 | 300 |