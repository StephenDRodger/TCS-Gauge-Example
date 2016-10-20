TCS Customised Statement Input Specification
============================================
Tags: login, 
The two steps below should be moved to a concept - look into it
Get "ManUserName" and "ManPassword" from <table: ../resources/ManagerLogin.csv>
<table : \resources\ManagerLogin.csv>
Log into banking app as a Manager "ManUserName" "ManPassword" 
* Log into banking app as a Manager "mngr51538" "tytUdYg"
* Click on the Customised Statement button



CS1 - Verify account number
---------------------------

* Account No Do not enter a value in Account number Field
* An AccountNo error message "Account Number must not be blank" must be shown


CS2 - Verify account number
---------------------------
Account number must be numeric
* Account No Enter numeric value in Account number Field "1234Acc123"
* An AccountNo error message "Characters are not allowed" must be shown


CS3 - Verify account number
---------------------------
Account number cannot have special character
* Account No Enter Special Character In Account number Field "123!@#"
* An AccountNo error message "Special characters are not allowed" must be shown


CS4 - Verify account number
---------------------------
Account number cannot have blank space
* Account No Account no cannot have Blank space "123 12"
* An AccountNo error message "Account no cannot have blank space" must be shown


CS5 - Verify account number
---------------------------
First Character cannot be space
* Account No Enter first character space " "
* An AccountNo error message "Characters are not allowed" must be shown


CS6 - Verify Amount lower limit
-------------------------------
Amount cannot be empty
* Amount lower limit Do not enter a value in Amount Field
* An AmountLowerLimit error message "Amount Lower Limit cannot be empty" must be shown


CS7 - Verify Amount lower limit
-------------------------------
Amount must be numeric
* Amount lower limit Enter numeric value in Amount Lower Limit number Field "Acc123"
* An AmountLowerLimit error message "Amount Lower Limit must be numeric" must be shown


CS8 - Verify Amount lower limit
-------------------------------
Amount cannot have special character
* Amount lower limit Enter Special Character In Amount Field "123!@#"
* An AmountLowerLimit error message "Amount Lower Limit cannot have special character" must be shown


CS9 - Verify Amount lower limit
-------------------------------
Amount cannot have blank space
* Amount lower limit Amount no cannot have Blank space "123 12"
* An AmountLowerLimit error message "Amount Lower Limit cannot have blank space" must be shown

CS10 - Verify Amount lower limit
-------------------------------
First Character cannot be space
* Amount lower limit Enter first character space " "
* An AmountLowerLimit error message "Amount Lower Limit cannot have first character space" must be shown


CS11 - Verify Number of Transaction
-----------------------------------
Number of transaction cannot be empty
* Number of Transaction Do not enter a value in Number of Transaction Field
* An NumberofTransaction error message "Number of Transaction cannot be empty" must be shown

CS12 - Verify Number of Transaction
-----------------------------------
Number of transaction must be numeric
* Number of Transaction Enter character value in Number of Transaction number Field "Acc123"
* An NumberofTransaction error message "Number of Transaction must be numeric" must be shown

CS13 - Verify Number of Transaction
-----------------------------------
Number of transaction have special character
* Number of Transaction Enter Special Character In Number for Transaction Field "123!@#"
* An NumberofTransaction error message "Number of Transaction cannot have special character" must be shown

CS14 - Verify Number of Transaction
-----------------------------------
Number of transaction cannot have blank space
* Number of Transaction Number of transaction cannot have Blank space "123 12"
* An NumberofTransaction error message "Number of Transaction cannot have blank space" must be shown

CS15 - Verify Number of Transaction
-----------------------------------
First Character cannot be space
* Number of Transaction Enter first character space " "
* An NumberofTransaction error message "Number Of Transaction cannot have first character space" must be shown
