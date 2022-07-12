Feature: Seller Add Language Details
	As a seller, I Want to add, update Language Details
	Then People can look into my Language details

@Language
Scenario Outline: C1 create language record with details
	Given I logged into Mars portal successfully
	When I navigate to language module
	And I add new '<language>' records on lauguange module
	Then the '<language>' records should be added in language module successfully

	Examples: 
	| language |
	| English  |
	| Telugu   |



@Language
Scenario Outline: C2 edit language record with details
	Given I logged into Mars portal successfully 
	When I navigate to language module
	And I update '<Language>'on existing language record
	Then the language record should have updated '<Language>'
	Examples: 
	| Language |
	| French   |
	| Hindi    |
@Language
Scenario: delete existing language record
	Given I logged into Mars portal successfully 
	When I navigate to language module
	And I delete existing language record
	Then the language record should disappear from the language module