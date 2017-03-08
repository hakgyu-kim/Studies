# doxygen

http://onecellboy.tistory.com/342

## basic comment
```c
/**
 *
 * @brief 테스트를 위한 클래스이다.
 * @details 내부에서 아무짓도 안한다.
 * @author oncellboy
 * @date 1234-12-12
 * @version 0.0.1
 *
 */
class Test{
}
```

http://stackoverflow.com/questions/11190838/doxygen-code-tag-kills-indentation

## doxygen sample code format

```c
/*! Sample:

\code{.cpp}
void main(int argc, char** argv)
{
    if (argc < 2)
    {
        cout << "no way!" << endl;
    }
    else
    {
        foobar(argv[1]);
    }
}
\endcode
*/
```
