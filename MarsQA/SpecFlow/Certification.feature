Feature: Seller Add Certification Details
	As a seller, i want to add, update,delete my certification
	So that
	Then people can look into my cerifications

@Certifications 
Scenario Outline: 1-Create certifications record with details
	Given I log into Mars portal successfully 
	When I navigate to certifications Module
	And I add new certifications record with '<CertificationName>' and '<CertificatedFrom>'
	Then the certifications record should be added successfully with correct '<CertificationName>' and '<CertificatedFrom>'
	Examples: 
	| CertificationName | CertificatedFrom   |
	| Best Programmer   | Industry Connect   |
	| Best Tester       | ISTQB              |
@Certifications 
Scenario Outline: 2-Edit certifications record with details
	Given I log into Mars portal successfully
	When I navigate to certifications Module
	And I update '<CertificationName>' and '<CertificatedFrom>' on existing certifications record
	Then the certifications record should have updated '<CertificationName>' and '<CertificatedFrom>' 
	Examples: 
	| CertificationName | CertificatedFrom         |
	| Best Tester       | MVP Studio               |
	| Best Student      | University of Auckland   |
@Certifications 
Scenario: 3-Delete existing certifications record
	Given I log into Mars portal successfully
	When I navigate to certifications Module
	And I delete existing certifications record
	Then the certifications record should disappear from the certification module