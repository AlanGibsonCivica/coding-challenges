# Coding challenge #1

Given an input string, find the first character in the string that is a repeat of a previous character.

## Examples

```
  Input:  "HELLO WORLD"
  Output: 'L'

  Input:  "SOMETHING ELSE"
  Output: 'E'
```

## Extensions

1. Ensure the code handles null or empty strings gracefully
2. Ignore any character that is not alphanumeric
3. Treat characters as equal regardless of casing i.e. 'A' === 'a'
4. Return the positions of the repeated character (first occurrence and first repetition) as well as the character itself e.g. `"SOMETHING ELSE"` returns `{ character: 'E', first_index: 3, repeat_index: 10 }`
5. Return the positions of all repeated characters as well as the character itself e.g. `"SOMETHING ELSE"` returns `{ character: 'E', indices: [3, 10, 13] }`

## Instructions

1. Clone this repository
2. Decide on a language from one of the supplied templates
3. Install additional language runtimes and VS Code extensions to your local environment as necessary (may need to restart VS Code to pick up changes)
4. Use VS Code to open the folder for the language you have selected (Avoid opening the top level folder - running & debugging the code is easier if VS Code only has to deal with one language at a time)

