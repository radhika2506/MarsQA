Feature: Seller Add Profile Details
	As a Seller
I want the add my Profile Details
So that
The people seeking for some skills can look into my details.


    

@ProfileDetails
Scenario: B1 Add personal details
    Given I logged into Mars portal successfully
	When I input my first name and last name
	And  I click Availability, Hours, Earn Target and input Descriptioon
	Then The profile page details should be added

@ProfileDetails
Scenario: B2 Update personal details
    Given I logged into Mars portal successfully
	When I Update my first name and last name
	And  I update Availability, Hours, Earn Target and Descriptioon
	Then The profile page details should be updated

@ProfileDetails
Scenario: B3 Add personal details
    Given I logged into Mars portal successfully
	When I delete my first name and last name
	And  I delete Descriptioon
	Then The profile page details should be deleted







