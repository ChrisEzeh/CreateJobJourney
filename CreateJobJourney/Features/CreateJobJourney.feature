Feature: CreateJobJourney
	As an employer
	I would like to create job
	so that I can submit it

@Regression
Scenario: What-To enter Job information
	Given user navigates to "https://employer.flexy.com/jobs/new/:jobId?/:step?"
	When user enters email "c.ezeh45@gmail.com"
	And user enters password "nnenna123"
	And user clicks on let'sGo
	And user enters job title "Parker"
	And user selects job category
	And user enters description "I love parking job"
	And user enters dress code "casual"
	And user selects experience level
	And user selects skills needed for the job
	And user enters contact name "tester tester"
	And user enter contact phone number "07772653797"
	And user enters arrival instruction ""
	And user clicks next
	Then where page is displayed

@Regression
Scenario: When-To enter information regarding shift dste, time and number of workers
	Given user navigates to "https://employer.flexy.com/jobs/new/382881f2-5db7-11ec-b002-7f15d68aca5f/when"
	When user enters email "c.ezeh45@gmail.com"
	And user enters password "nnenna123"
	And user clicks on let'sGo
	And user clicks on add shift
	And user selects date
	And user clicks on next
	And user enters start time "0900"
	And user enters finish time "1730"
	And user enters number of workers "3"
	And user click next
	And user clicks on add more shift
	And user selects another date
	And user clicks on next
	And user enter second start time "1000"
	And user enters second finish time "2000"
	And user enters number of workers "5"
	And user clicks on next
	And user clicks on edit
	And user change finish time to "1900"
	And user change workers to "5"
	And user clicks on next
	And user clicks on delete
	And user clicks done adding shift
	Then subnit page is displayed