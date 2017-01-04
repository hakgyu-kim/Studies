# CPP STL(Standard Template Libaray)

* vector

vector는 size와 capacity를 가진다.

capacity는 담을수 있는 양이다.

size는 담겨 있는 데이터 양이다.


```cpp
#include <vector>
#include <queue>
#include <iostream>
#include <string>

class SomeData 
{
private:
    int a;
    int b;
public:
    SomeData() {
        a = 0;
        b = 0;
    }
    SomeData(int a, int b) {
        this->a = a;
        this->b = b;
    }
    ~SomeData() {}
    void setData(int a, int b) {
        this->a = a;
        this->b = b;
    }
    string toString() {
        return new string("
    }
};

int main(void)
{
    std::vector<SomeData*> v1;
    std::cout << v1.capacity() << std::endl;
    std::vector<SomeData> v2(100);
    int v1_size = sizeof(v1);
    int v2_size = sizeof(v2);
    SomeData* d = new SomeData();
    v1.push_back(d);
    v1.pop_back();
    std::queue<SomeData*> q1;
    int q1_size = sizeof(q1);
    d = new SomeData(1,1);
    q1.push(d);
    d = new SomeData(2,2);
    q1.push(d);
    d = q1.front();
    q1.pop();
}
```
