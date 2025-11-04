
let x: number = 10;
console.log(x, typeof x); // 10 number


let y: any = 10;
console.log(y, typeof y); 

y = "ten";
console.log(y, typeof y); 

y = true;
console.log(y, typeof y); 



// • What happens in each case?
//     TypeScript enforces static typing. Reassigning 'x' to a different type causes a compile-time error.
//      If declared as 'any', 'y' can change type freely at runtime (like JavaScript).

// • If the compiler/interpreter allows it, print type(x) or equivalent.
//      typeof y prints the runtime JavaScript type (number, string, boolean).
