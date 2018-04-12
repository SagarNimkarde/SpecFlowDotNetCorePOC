Feature: CalcMultiply
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@calc
Scenario Outline: Multiply two numbers
	Given I have entered <a> into the calculator
	And I have also entered <b> into the calculator
	When I press multiply
	Then the result should be <c> on the screen
	Examples: 
	| a   | b  | c   |
	| 20  | 10 | 200 |
	| 10  | 20 | 200 |
	| 20  | 0  | 0   |
	| 600 | 1  | 600 |
	