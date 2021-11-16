Feature: Login
	In order to access the main site
	As a user
	I want to login with my credentials


@login
Scenario: Login with valid credentials
	Given I am on the Login page
	And email address is ***
	And password is ***
	When click the Login button
	Then I am on the Home page

@login
Scenario: Cannot login with invalid credentials
	Given I am on the Login page
	When I fill in the required values
	| Field       | Value  |
	| incorrect email | password |
	| email | incorrect password |
	And click the Login button
	Then I am on the Login page
	And the message is shown: "We didn't recognize that email and/or password. Need help?"

@navigate
Scenario: Navigate to the main page by clicking the Hudl logo
	Given I am on the Login page
	When click the Hudl logo
	Then I am on the Home page not logged in

@ignore
@navigate
Scenario: Navigate to the main page by clicking the Need help button
	Given I am on the Login page
	And click the Need help button
	When I enter email address ***
	And click Send password reset button
	Then the message is shown "" 

@ignore
@navigate
Scenario: Navigate to the Registration page by clicking the Sign up button
	Given I am on the Login page
	When click the Sign up button
	Then I am on the registration page
