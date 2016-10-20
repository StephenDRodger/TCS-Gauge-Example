Guru99 Banking App Test Cases
==============================

Starting point:
---------------
* Take the "TestCaseSuite_v1" document and create a rough specification document from it's contents.
* - Exported the spreadsheet to .csv format. Each tab will be a unique specification document.
* - Create scenarios for each test case, and the steps for each Scenario including the test data provided.
* Saved "TCS_v1_CustomisedStatement_01.spec" as my rough specification example.


Extra Information: 
-------------------
* Verify what each of the scenarios require to be able to run and enter the info underneath the Specification name.
* - Login at "demo.guru99.com/v4/" as manager
* - Navigate to the "demo.guru99.com/v4/mamnager/CustomermisedStatementInput.php" page.


Create Starting Point for each scenario to use (This should be concept but I haven't looked into tht yet):
----------------------------------------------------------------------------------------------------------
* In /env/default/default.properties set APP_ENDPOINT = http://demo.guru99.com/v4/
* Create Page Classes for each page required and grab the WebElements (/Implementation/Pages/)
* - Guru99 Bank Home page
* - - Find Elements for:
* - - - UserID
* - - - Password
* - - - LOGIN button
* - Manager home page
* - - Find Elements for:
* - - - Customised Statement button
* - Customerised Statement Input page 
* - - Find Elements for:
* - - - Account No input field
* - - - From Date input field
* - - - To Date input field
* - - - Minimum Transaction Value input field
* - - - Number of Transaction
* - - - Submit button
* - - - Reset button
* - - - Home link


Write the code to support the Specification and refine the rough Specification to a final product.(test each step as you go along)
-----------------------------------------------------------------------------------------------------------

* 
