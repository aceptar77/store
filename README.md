This is an example of a single-product store that connects to the placetopay payment gateway
The application is made on vb.net 2019 and compiled on framework 4.7
Uses entity framework 6.0 and bd SQL
It consists of 3 forms that inherit from a master.
frmMainStore: Where the order is made
frmResultPay: Where the transaction summary is shown
frmlistorder: Where the list of orders is shown.
the classPay folder contains

autplacetopay: Utility to authenticate the web service.
orderComponents: Business logic to save and view the order
paramplacetopay: Parameters for the web service
resultcreatepay: Entity to send the payment
resultatransaction: Transaction result   payment

the script of the DB is the file
scriptbd.slq
can be viewed at https://storeapprva.azurewebsites.net/
