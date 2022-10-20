Feature: SellerSkills

A short summary of the feature

@AddSkills
Scenario: [Add skills of the Seller on the profile page ]
	Given [I logged into website]
	When [When I navigate to profile page]
	And [I add skills of the seller]
   Then [I should be able to create skill record sucessfully]

@EditeSkills
Scenario:[Edit existing record of the seller on the profil page]
    Given [I logged into the Website]
	When  [I navigated to the profile page]
	And   [I update '<Skill>' on the existing skill record]
	Then  [The record should have updated '<Skill>']
Examples: 
| Skill          | 
| Manual Testing | 

@DeleteSkills
Scenario:[Delete the skills record sucessfully]
Given I logged into the Mars website
When  I navigate to the Profile page
And   I delete the extisting edited skill record
Then  Record should be deleted sucessfully

