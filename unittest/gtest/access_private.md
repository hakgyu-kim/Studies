# Test with private member

**문제점**

Junit에서는 private member 접근에 제한이 없으나, C환경에서는 접근할 수 없음.

**해결방법**

gtest의 testcase class를 target class의 friend로 선언함

* helper macro

```cpp
#pragma once
#ifdef GTEST_INCLUDE_GTEST_GTEST_H_
#define FRIENDCLASS(fixture, test) \
    friend class GTEST_TEST_CLASS_NAME_(fixture,test);
#define TEST_FRIENDS \
    FRIENDCLASS(SomeClassTest, create_instance);
#else 
#define TEST_FRIENDS
#endif
```

* test target
```cpp
class SomeClass
{
TEST_FRIENDS;
private:
    
public:
    SomeClass(void);
}
```
