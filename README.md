# EasyRegexLibrary
An easy to use library with pre-written regular expressions for some common searches like street addresses, phone numbers, and email addresses.
Currently only works for U.S. phone numbers/addresses.

To use: simply call the EasyRegex class, choose your method for searching, pass the text, and you're returned a MatchCollection of the specified search results.

 ```MatchCollection streetAddresses = EasyRegex.FindStreetAddresses("Mytext");```

You can also search a file directly using the ReadFromFile method.  

```MatchCollection result = EasyRegex.ReadFromFile(filePath, {searchMethod});```

Or use the ReadFromFileAsync method to perform the file reading asynchronously 

``` MatchCollection result = await EasyRegex.ReadFromFileAsync(filePath, {searchMethod}); ```
