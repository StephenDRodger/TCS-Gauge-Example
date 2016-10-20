Banking - Create customer
==========================
To create a new user you need to be logged in as a manager.
Verify that the manager is logged in by checking the page title and retrieving the manager ID

tags: manager

|UserName      |Password       |CustomerName	|CustomerGender	|CustomerDateOfBirth	|CustomerAddress	|CustomerCity	|CustomerState	|CustomerPIN	|CustomerMobileNumber	|CustomerEmial	|CustomerPassword	|
|--------------|---------------|----------------|---------------|-----------------------|-------------------|---------------|---------------|---------------|-----------------------|---------------|-------------------|
|mngr51538     |tytUdYg        |TestSteve		|m				|2015/05/05				|18 George Way		|Cape Town		|WC				|654321			|0793567840				|S@R.com		|Secret				|


Verify manager home page title 
Retrieve manager ID


Scenario 1
-------------
* Log into banking app as a Manager <UserName> <Password>
* Click on the New Customer button
* Enter space as Customer Name
* Check for error message "First character can not have space"

Scenario 2
-----------

* Log into banking app as a Manager <UserName> <Password>
* Click on the New Customer button
* Enter blank as Customer Name
* Check for error message "Customer name must not be blank"

Create New User
----------------
* Log into banking app as a Manager <UserName> <Password>
* Click on the New Customer button
* Enter new customer name <CustomerName>
Click on Gender radio button <CustomerGender>
* Enter new customer Date of Birth <CustomerDateOfBirth>
* Enter new customer Address <CustomerAddress>
* Enter new customer City <CustomerCity>
* Enter new customer State <CustomerState>
* Enter new customer Pin <CustomerPIN>
* Enter new customer Mobile Number <CustomerMobileNumber>
* Enter new customer E-mail <CustomerEmial>
* Enter new customer Password <CustomerPassword>
* Click on the Submit button

