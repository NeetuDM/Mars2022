Feature: Language

A short summary of the feature

@Add_Language
Scenario: 1-[Add Language of Seller in the profile page]
	Given [I logged into the Mars website]
	When  [I navigate to the Language Tab in the profile page]
	And  [I create new language record on the profile page ]
	Then [New Language record should be added sucessfully]
	

@Edit_Language
Scenario:2-[Edit Language record of the seller in the profile page]
    Given [I logged into the Mars website]
	When [I navigate to Language tab in the profile page]
	And I update '<Language>' on existing language record
	Then The record should have updated '<Language>'

	Examples: 
	| Language |
	| French   |
	

@Delete_Language
Scenario:3-[Delete the Edited language record from the Profile page.]
	Given I logged into the Mars website.
	When I navigate to the Language Tab in the profile page.
	And  I delete the edited language record.
	Then Edited Language record should be deleted sucessfully


