SOLUTION:

open {workingdir}\Smit.sln file

The solution consists of 2 projects:
1) Smit - executable
2) SmitTest - unit tests

Rebuild the solution before the first run. Reference to MSTest.TestAdapter and MSTest.TestFramework should be updated automatically.
Otherwise, make sure on Tools->Options->NuGet Package Manager: General two options "Allow NuGet to download missing packages" and "Automatically check for missing packages.." are checked

UNIT TESTS:

Unit tests are created with  MSTest.TestAdapter/MSTest.TestFramework. To run the test, open Test Explorer in VS and click RunAll

DESIGN:

see uml-diagram in smit-demo.png file

Models:
IProductData and IMachineData are interfaces to describe model API
ProductData and MachineData are implementations of the corresponding interfaces

ViewModels:
IProductViewModel and IMachineViewModel are view model interfaces.
ProductViewModel and MachineViewModel are implementations of the above interfaces.
MainViewModel is a view model for the main window view.

Views:
ProductView is a UserControl unit to present a product rectangle implemented as a button
MachineView is a UserControl unit to present a machine workspace background rectangle and to display a list of products.
MainView is the main application view containing MachineView and a couple of controls to add a new product: Customer ID textbox and Add Product button.

NOTES:

1) Using application configuration file it is possible to define a machine and a product size in m/mm and a max capacity of a machine (ex. 63)

2) New product appears on the left-hand side of a machine, moves to the right using a timer event and becomes hidden leaving the machine.

3) Click a product rectangle to change the corresponding product status to Rejected, the product rectangle becomes OrangeRed

4) The app has been implemented in Visual Studio 2017 Community