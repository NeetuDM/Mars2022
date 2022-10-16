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
	And   [I edit the existing skill record]
	Then  [The skill record should be edited sucessfully]
Examples: 
| Language       | Level        |
| Manual Testing | Intermediate |

@DeleteSkills
Scenario:[Delete the skills record sucessfully]
Given [I navigated to the profile page]
When  [I delete the edited skill record]
Then  [Edited skill record should be delted sucessfully]

