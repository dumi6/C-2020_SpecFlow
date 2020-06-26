Feature: ContactUs
	Customer needs help due to delayed order!

@mytag
Scenario: ContactUs
	Given A customer needs help
	When A customer clicks on ContactTab
	When Customer enters name 'Test76'
	When A customer enters his email 'dstest@email.com'
	And A customer enters subject 'Help!!!'
	And A customer enters the message 'Help needed!!'
	Then A customer clicks on send button to submit the message
	Then A customer Validates ContactUs page