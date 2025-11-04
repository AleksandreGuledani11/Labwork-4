
const person = { name: "Guga", age: 27 } as const;


const updated = { ...person, age: 28 };

console.log(person); 
console.log(updated); 
