Feature: MarsFeature

A short summary of the feature

@Login
Scenario: [Login to the Mars website sucessfully]
	Given [I entered URL in the browser]
	When  [I enter the credential on the login page]
	And   [I click on the Login button]
	Then  [I should be able to logged into the Mars Website successfully]

@Add_Description
Scenario:[Create Description of seller with valid details]
Given I logged into the website
When I add Description on the profile page
And I Save the Description details
Then The Description should be created successfully

@Hours
Scenario: Add Seller Hours on the Profile page
Given I logged into the Mars website sucessfully
When I nevigate to the Profile page 
And I add the Hours of the seller
Then The Hours should be added sucessfully

@EarnTarget
Scenario: Add Seller Earn Target on the Profile page
Given I logged into the Mars website sucessfully
When I nevigate to the Profile page 
And I add the Seller Earn Target
Then The Seller Earn Target should be added sucessfully

@Edit_Description
Scenario: [Edit Description of seller with valid details]
Given I logged into the website
When I add Description on the profile page
And I Save the Description details
Then The Description should be created successfully

@AddEducation
Scenario: [Create new Education record of the seller]
Given I logged into the Mars website sucessfully
When I navigate to the profile page 
And I enter the <'College name'>,<'Degree'> and other Education details
Then The new education should be created sucessfully

@EditEducation
Scenario: [Edit existing Education record of the seller]
Given I logged into the Mars website sucessfully
When I navigate to the profile page 
And I edit the existing education details <'College name'>,<'Degree'> 
Then The existing education should be edited sucessfully

@DeleteEducation
Scenario:[Delete Education record sucessfully]
Given I logged into the Mars website sucessfully
When I navigate to the profile page 
And I delete the edited Education record
Then The edited Education record should be deleted sucesfully

@AddCertifications
Scenario: [Create new Certification record of the seller sucessfully]
Given I logged into the Mars website sucessfully
When I naviagte to the profile page
And I Add new Certification record of the seller
Then The new Certification record should be created sucessfully

@EditCertification
Scenario:[Edit existing certification record of the seller]
Given I logged into the MArs website sucessfully
When I navigate to the profile page
And I update the Certification details '<Certificate>','<From>','<Year>'
Then existing Certification record should be edited sucessfully

Examples:
| Certificate                    | From                | Year |
| Diploma in Information Systems | Victoria University | 2021 |

@DeleteCertification
Scenario:[Delete the Certification record sucessfully]
Given I logged into the Mars website sucessfully
When I navigate to the profile page
And Delete the edited Certification reord of the seller
Then the edited Certification record should be deleted sucessfully

@Dashboard
Scenario:[Seller is able to navigate the Dashboard page]
Given I logged into the website
When I Navigate to the Dashboard page
Then I should be ableto NAvigate to the Dashboard page successfully

@ManageListing
Scenario:[Seller is able to navigate to the Manage Listing page]
Given I logged into the website
When I Navigate to the Manage Listing page
Then I should be ableto NAvigate to the Manage Listing pagee successfully

@ManageRequest
Scenario:[Seller is able to navigate to the Manage Request page]
Given I logged into the website
When I Navigate to the Manage Request page
Then I should be ableto NAvigate to the Manage Request pagee successfully


