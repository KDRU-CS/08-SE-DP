using AdapterDesignPattern;
using AdapterDesignPattern.Turkey;

// Creates A Duck
ITurkey turkey = new WildTurkey();

// Convert to Turkey
TurkeyAdapter duck = new(turkey);

// test
duck.Quack();