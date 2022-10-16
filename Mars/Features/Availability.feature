Feature: Availability

A short summary of the feature

@Availability
Scenario: Create seller Availability with valid details
Given I logged in to the Mars website
When I navigate to Profile page 
And I create Availabilty of the seller
Then Availability should updated sucessfully

