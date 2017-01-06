##Jsoncpp에서 array접근

```cpp
    const Json::Value rules = rule.get("IntermediateDataDispachRule",Json::nullValue);
    for (int index=0; index<(int)rules.size(); index++) {
        for (int elementIndex=0; elementIndex < (int)rules[index].size(); elementIndex++) {
            int element = rules[index][elementIndex].asInt();
            ruleElement.insert(element);
        }
    }
```
