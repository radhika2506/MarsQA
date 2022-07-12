Feature: Seller add Login details
	As a seller, i Want login into Mars portal with valid details
	Then i can able to see my profile Page

@Login
Scenario: Login to mars portal with valid credentials
    Given I open the  browser and Login with valid credentials 
	Then I logged into poratl Successfully