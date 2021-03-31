const manager = {
    id: 1,
    name: 'Sam',
    reportees: [
       { id: 10, name: 'Harry' },
       { id: 11, name: 'Ron' },
       { id: 12, name: 'Fred' }
    ]
 }
 
 const {
    name: managerName,
    reportees: [
       { name: reporteeName1 },
       { name: reporteeName2 },
    ]
 } = manager;
 
 console.log(managerName);
 console.log(reporteeName1);
 console.log(reporteeName2);
 