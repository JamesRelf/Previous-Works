const XLSX = require('xlsx');

const workbook = XLSX.readFile("Book1.xlsx");
const worksheet = workbook.Sheets["Sheet1"]
// Gets all the data from the excel workbook and parses it to json, which is then stored in an array.
const arrCustomData = XLSX.utils.sheet_to_json(worksheet);

//console.log(arrCustomData);

for (const customer of arrCustomData ){
    const customerName = customer["Name"];
    const customerAddress = customer["Address"];
    const customerContact = customer["Contact"];
    const customerReason = customer["Reason"];
    const customerID = customer["RequestID"]

    if(arrCustomData === null){
        return;
    }

    console.log('The Customers names are: ' + customerName);
    console.log('The Customers addresses are: ' + customerAddress);
    console.log('The Customers emails are: ' + customerContact);
    console.log('The Customers reasons are: ' + customerReason);
    console.log('The Customers ID is: ' + customerID);
}


