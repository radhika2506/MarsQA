Feature: Seller Add Profile Details
	As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

@Login
Scenario: A1 Login to mars portal with valid credentials
    Given I open the  browser and Login with valid credentials 
	Then I logged into poratl Successfully
    

@PersonalDetails
Scenario: B1 Add personal details
    Given I logged into Mars portal successfully
	When I input my first name and last name
	And  I click Availability, Hours, Earn Target and input Descriptioon
	Then The profile page details should be added

@PersonalDetails
Scenario: B2 Update personal details
    Given I logged into Mars portal successfully
	When I Update my first name and last name
	And  I update Availability, Hours, Earn Target and Descriptioon
	Then The profile page details should be updated

@PersonalDetails
Scenario: B3 Add personal details
    Given I logged into Mars portal successfully
	When I delete my first name and last name
	And  I delete Descriptioon
	Then The profile page details should be deleted

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

@Education
Scenario: D1 Create Education record with the details    
	Given I logged into Mars portal successfully 
	When I navigate to Education module
	And I add new education record with '<UniversityName>' and '<Degree>'
	Then the education record should be added successfully with correct '<UniversityName>' and '<Degree>'
	Examples: 
	| UniversityName             | Degree   |
	| Annamacharya University    | Bachelor |
	| Auckland University        | Master   |

	@Education 
Scenario Outline: D2 edit education record with details
	Given I logged into Mars portal successfully 
	When I navigate to education Module
	And I update '<UniversityName>' and '<Degree>' on existing education record
	Then the education record should have updated '<UniversityName>' and '<Degree>'
	Examples: 
	| UniversityName                    | Degree       |
	| The University of Auckland        | Postgraduate |
	| The University of melbourne       | Master       |
	@Education 
Scenario: D3 delete existing education record
	Given I logged into Mars portal successfully 
	When I navigate to education Module
	And I delete existing education record
	Then the education record should delete from the education module
	
@Certifications 
Scenario Outline: E1 create certification record with details
	Given I logged into Mars portal successfully 
	When I navigate to certification Module
	And I add new certification record with '<CertificationName>' and '<CertificatedFrom>'
	Then the certification record should be added successfully with correct '<CertificationName>' and '<CertificatedFrom>'
	Examples: 
	| CertificationName | CertificatedFrom   |
	| Best Programmer   | Industry Connect   |
	| Best lecturers    | Lincoln University |
@Certifications 
Scenario Outline: E2 edit certification record with details
	Given I logged into Mars portal successfully 
	When I navigate to certification Module
	And I update '<CertificationName>' and '<CertificatedFrom>' on existing certification record
	Then the certification record should have updated '<CertificationName>' and '<CertificatedFrom>' 
	Examples: 
	| CertificationName | CertificatedFrom         |
	| Best Tester       | MVP Studio               |
	| Best Tutors       | University of Canterbury |
@Certifications 
Scenario: E3 delete existing certification record
	Given I logged into Mars portal successfully 
	When I navigate to certification Module
	And I delete existing certification record
	Then the certification record should disappear from the certification module
@Skill
Scenario Outline: F1 create skill record with details
	Given I logged into Mars portal successfully 
	When I navigate to skills Module
	And I add new '<skill>' record in skill module
	Then the '<skill>' record should be added successfully in skill module
	Examples: 
	| skill       |
	| Programming |
	| Writing     |
@Skill 
Scenario Outline: F2 edit skill record with details
	Given I logged into Mars portal successfully 
	When I navigate to skills Module
	And I update '<skill>'on existing skill record
	Then the skill record should have updated '<skill>'
	Examples: 
	| skill              |
	| Automation Testing |
	| Swimming           |
@Skill 
Scenario: F3 delete existing skill record
	Given I logged into Mars portal successfully 
	When I navigate to skills Module
	And I delete existing skill record
	Then the skill record should disappear from the skills module





