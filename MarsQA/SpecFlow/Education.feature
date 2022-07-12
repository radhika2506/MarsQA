Feature: Seller Add Education Details
	As a Seller, I Want to Add, Update, Delete my Education Details
	So that
	Then People can look into My Education

@Education
Scenario: D1 Create Education record with the details    
	Given I sign into Mars portal successfully 
	When I navigate to Education Module
	And I add new education record with '<UniversityName>' and '<Degree>'
	Then the education record should be added successfully with correct '<UniversityName>' and '<Degree>'
	Examples: 
	| UniversityName             | Degree   |
	| Annamacharya University    | Bachelor |
	| Auckland University        | Master   |

	@Education 
Scenario Outline: D2 edit education record with details
	Given I sign into Mars portal successfully 
	When I navigate to Education Module
	And I update '<UniversityName>' and '<Degree>' on existing education record
	Then the education record should have updated '<UniversityName>' and '<Degree>'
	Examples: 
	| UniversityName                    | Degree       |
	| The University of Auckland        | Postgraduate |
	| The University of melbourne       | Master       |
	@Education 
Scenario: D3 delete existing education record
	Given I sign into Mars portal successfully 
	When I navigate to Education Module
	And I delete existing education record
	Then the education record should delete from the education module