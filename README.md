# DiamondCharacter
This is a code output for the Code Dojo Diamond Kata (https://github.com/davidwhitney/CodeDojos/tree/master/Diamond%20Kata)

## Some assumptions
 * Valid input characters are B-M
 * Lower case input characters allowed but sanitised to uppercase for consistency

## Unit tests
The solution includes some unit tests to cover some positive/negative scenarios

## Manually running the code
There is a console app 'DiamondCharacter.ConsoleApp' which can be invoked with a single letter argument e.g.
```
DiamondCharacter.ConsoleApp.exe g
```

## Some further developer notes
In an effort to save time, no IOC/dependency injection has been used however some configuration elements could be injected in (for example what character to use for empty visualisation)

Also in an effort to save time, no interface abstraction has been used.