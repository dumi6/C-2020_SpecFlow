Feature: SignInSignUp
	User logs into demoreStore

	@mytag
Scenario: CustomerSignInSignUp
	Given Customer has opened my demoStore
	When Customer clicks SignIn SignUp
	And Customer enters email 'dstest@email.com'
	And Customer enters password 'ELIsa321!'
	And Customer clicks Sign button
	Then the user logged in successfully
