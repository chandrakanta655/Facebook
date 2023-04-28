Feature: Feature1

A short summary of the feature

@tag1
Scenario: Verify Google
	Given I open chrome browser
	When I put url as (http//www.facebook.com)
	Then I click search butten
	Then I click search result
	And I click alredy have account
	Then I put user Id
	And  I put passward
	Then I click enter butten
