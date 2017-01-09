## Map 

# key의 값 확인하기

* map[key]로 값을 얻을 수 있다.
* key[]연산자로 key에 해당하는 value를 읽는 경우, key가 없으면 (key,0)으로 추가하는 문제가 있다. 아래와 같이 확인할 수 있다.
```cpp
    if (mMap.find(id) == mMap.end()) {
        return 0;
    }
```
