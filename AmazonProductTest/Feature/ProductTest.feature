Feature: ProductTest
	Implement tests covering the following cases:

		- Open Amazon.com
		- Search for "sunon 40mm fan KDE1205P"
		- Sort the result by "Price: Low to High"
		- Assert that 1st item name contains the words "SUNON" and "KDE1205PFB2-8"
		- Open 1st item in the search list
		- Assert the brand of the product is Sunon
		- Assert the name of seller is "Coolerguys"

@mytag
Scenario: 1. Search an item on amazon.com , Sort prices & Verify words "SUNON" and "KDE1205PFB2-8" in first item name.
	Given GoTo Amazon website
	And   Search for Product 'sunon 40mm fan KDE1205P'
    When  Sort from low to high price
	Then  Name of first item should contains the words 'SUNON' and 'KDE1205PFB2-8'


	@mytag
Scenario: 2. Search an item on amazon.com , Sort prices , Verify Brand and Seller of first product.
	Given GoTo Amazon website
	And   Search for Product 'sunon 40mm fan KDE1205P'
    And   Sort from low to high price
	When  First product is clicked
	Then  Brand name is 'Sunon' and Seller name is 'Coolerguys' 
	     


