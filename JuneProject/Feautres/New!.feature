Feature: New!
	To see the New Arrivals 

@mytag
Scenario: New!
	Given A customer navigates to New arrivals
	When A customer clicks on the tab New
	And A customer clicks on blue denim jacket
	Then A customer clicks AddToCart
	Then A customer verifies that the jacket has been added to the cart

