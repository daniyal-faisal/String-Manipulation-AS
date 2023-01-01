DECLARE str1, thisstr : STRING

str1 <-- ""
thisstr <-- ""

OUTPUT("Enter string:")
str1 <-- INPUT
thisstr <-- UCase(str1)

If str1 = thisstr Then
  OUTPUT("All alphabets are capitial")
Else
  OUTPUT("Alphabets are small.")
End If
