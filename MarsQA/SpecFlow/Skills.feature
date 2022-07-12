Feature: Seller add Skills details
	As a seller, I want to add,update and delete my skills
	So that
	People can look into my skill details

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