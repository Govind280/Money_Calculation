# Money_Calculation

Requirement is to build a reuable assembly for calculating Money activity based on provided interface.

I have created a .csproj for implementing interface shared as input using .net Core.

## Unit Test
Used `MS Unite test` for writing unit test. In unit test I have used `DynamicData` to test with multiple inputs for same test method for full code coverage. 
If we need additional inputs or scenarios to be tested,
 - Add additional input in `GetTestDataFor_Max_Test` method for `Max()` method.
 - Add additional input in `GetTestDataFor_SumPerCurrency_Test` method for `SumPerCurrency()` method.


## Improvements/Extra miles
Below improvements can be implemented if I get more time,
 - I can build REST API to consume business logic with token based authentication for endpoints.
 - Add logging using log4net.
