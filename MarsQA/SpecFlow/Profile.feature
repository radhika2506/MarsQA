Feature: Seller Add Profile Details
	As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

@Login
Scenario: Login to mars portal with valid credentials
    Given I open browser and goto Url
	When I give valid Email and Password
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
Scenario: C3 delete existing language record
	Given I logged into Mars portal successfully 
	When I navigate to language module
	And I delete existing language record
	Then the language record should disappear from the language module