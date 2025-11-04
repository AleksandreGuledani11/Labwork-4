let a: number = 5;
let b: string = "5";
let c: number = 5.0;


console.log(a + c);         
console.log(a + b);         
console.log(b + c);         


console.log(a + Number(b));  
console.log(String(a) + b);  


// • Which of these operations fail and why?
//   None fail at runtime, but TypeScript may give compile-time warnings for type mismatch.
//
// • Which language allows implicit coercion and how safely?
//    TypeScript compiles to JavaScript, which performs automatic (and sometimes unsafe)
//      type coercions at runtime (e.g., string + number -> string).
//
// • What does this tell you about strong vs weak typing?
//   TypeScript adds strong static typing at compile time,
//      but JavaScript underneath is weakly and dynamically typed.
