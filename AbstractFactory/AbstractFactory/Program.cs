using AbstractFactory;
using AbstractFactory.Factory;

// Pc is the abstract factory, and it received another factory
// In other words, Pc is factory of factory
var officePc = new Pc(new OfficePcFactory());
var gamingPc = new Pc(new GamingPcFactory());