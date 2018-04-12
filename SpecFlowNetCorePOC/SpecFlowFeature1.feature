Feature: CalculatorFeatureMultiplyNumbers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the multiply of two numbers

Scenario: Multiply two numbers
	Given I have entered 50 into the calculator
	And I have entered 50 into the calculator
	When I press multiply
	Then the result should be 2500 on the screen
