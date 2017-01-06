## embedding json string on source code

```c
#define LONG_STRING_CONST(...) #__VA_ARGS__
/* usage : can be used for initialization of long string that has new line and quotation mark etc.

char const* jobDispatcherConfig1_json = LONG_STRING_CONST(
{
    "JobDispatherRule": {
            "NumberOfDuplication": 1
    }
}
);

*/
```
