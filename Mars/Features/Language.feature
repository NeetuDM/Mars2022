Feature: Language

A short summary of the feature

@Add_Language
Scenario: [Add Language of Seller in the profile page]
	Given [I logged into the Mars website]
	When  [I navigate to the Language Tab in the profile page]
	And  [I create new language record on the profile page ]
	Then [New Language record should be added sucessfully]
	

@Edit_Language
Scenario:[Edit Language record of the seller in the profile page]
    Given [I logged into the Mars website]
	When [I navigate to Language tab in the profile page]
	And I update '<Language>', '<Level>' language details
	Then The existing record for Language '<Language>', '<Level>'should be updated sucessfully
	Examples: 
	| Language | Level|
	| French   | Basic|

@Delete_Language
Scenario: [Delete Edited Language record of Seller in the profile page]
	Given [I logged into the Mars website]
	When [I navigate to the Language Tab in the profile page]
	And [I delete the edited language record]
	Then [Edited Language record should be deleted sucessfully]


