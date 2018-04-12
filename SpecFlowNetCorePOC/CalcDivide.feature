Feature: CalcDivide
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@calc
Scenario Outline: Divide two numbers
	Given I have entered <a> into the calculator
	And I have also entered <b> into the calculator
	When I press divide
	Then the result should be <c> on the screen
Examples: 
	| a   | b   | c   |
	| 20  | 10  | 2   |
	| 10  | 20  | 0.5 |
	| 20  | 20  | 1   |
	| 600 | 200 | 3   |