##set 사용법


```cpp
std::set<int> mySet;
mySet.insert(element);
nCount = mySet.size();
```

* find element

```cpp
    // if ruleElement has 0,1,2,3
    int count = ruleElement.count(1); // count is 1
    count = ruleElement.count(4);  // count is 0
    
    if( ruleElement.find(5) == ruleElement.end() ) { // not in this set
        int err = 1;
    }
```
