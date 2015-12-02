# Access-Code-Generator
Uses MAC address and SHA1 hash function to generate unique computer validation key for simple authentication
![First page](https://github.com/rjbarna/Access-Code-Generator/blob/master/pic1.PNG?raw=true)
## More Info (Intended Use):
I created this to generate access codes that would be used to authenticate computers ... steps to follow:

1. Send this program over + another that requires authentication
2. User runs this program and sends back access key to host (this could be automated but there was no need at the time)
3. Host adds this key to the database
4. The user runs the other program. Since the key is in the database, the user is granted access
5. The other program authenticates by generating the same key as this program and sending it to the server for authentication
6. This was/can be used to authenticate a whole package of applications
