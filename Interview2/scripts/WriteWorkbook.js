// require(['require'], function (xlsx) {
  
// });

const XLSX = require('xlsx');

const workbook = XLSX.readFile("Book1.xlsx");
const worksheet = workbook.Sheets["Sheet1"];




let workSheets = {};
for(const sheetName of workbook.SheetNames){
    workSheets[sheetName] = XLSX.utils.sheet_to_json(workbook.Sheets[sheetName]);
}

//This is a test object
workSheets.Sheet1.push({
    "Name": "George Martin",
    "Address": "33 Red Keep Square",
    "Contact": "G.Martin@yahoo.com",
    "Reason": "When will my paper arrive?",
    "RequestID": "6734"
});

function addToWorkBook(name, address, contact, reason, customerID){
    
    workSheets.Sheet1.push({
        "Name" : name,
        "Address" : address,
        "Contact" : contact,
        "Reason" : reason,
        "RequestID": customerID
    })
}

XLSX.utils.sheet_add_json(worksheet, workSheets.Sheet1);
XLSX.writeFile(workbook, "Book1.xlsx");


