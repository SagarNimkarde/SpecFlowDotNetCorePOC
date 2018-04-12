Feature: CalculatorFeatureMultiplyNumbers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the multiply of two numbers

Scenario Outline: Multiply two numbers
	Given I have entered <a> into the calculator
	And I have entered <b> into the calculator
	When I press multiply
	Then the result should be <c> on the screen

	Examples: 
	| a  | b  | c  |
	| 10 | 20 | 200 |
	| 20 | 20 | 400 |
	| 20 | 10 | 200 |
	| 0  | 0  | 0  |
