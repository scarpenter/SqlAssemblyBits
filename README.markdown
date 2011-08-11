Purpose
=======
SqlAssembyBits has a single, simple purpose: give you the text you need to use as part of a TSQL [CREATE ASSEMBLY](http://msdn.microsoft.com/en-us/library/ms189524.aspx) command. This allows you to avoid having to put the actual DLL containing your CLR assembly in a location accessible to the server.

Usage
=====
```
SqlAssemblyBits <path_to_your_dll>
```

The string necessary for the `CREATE ASSEMBLY` call will be written to standard out.  That's it!

License
=======
Simplified BSD license.  See the LICENSE file for details.

