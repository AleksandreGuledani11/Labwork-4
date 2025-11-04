

type Numeric = number;

function calc(a: Numeric, b: Numeric, op: '+' | '-' | '*' | '/'): number {
    switch (op) {
        case '+': return a + b;
        case '-': return a - b;
        case '*': return a * b;
        case '/': return a / b;
    }
}


console.log(calc(10, 5, '+'));   
console.log(calc(10.5, 2, '/')); 


