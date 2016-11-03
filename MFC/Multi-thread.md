# Windows Multi-Thread 

> Windows의 Process는 할당된 메모리 영역에 각종 자원을 담고 있는 컨테이너이다.

> 운영체제는 Kernel은 Process Kernel Object와 Thread Kernel Object를 관리한다.

> 한 프로세스의 가상공간은 
> * 32bit windows :  4GB (User 2GB + Kernel 2GB)
> * 64bit windows : 16TB (User 8TB + Kernel 8TB)


Priority
Process : Priority Class
Thread  : Priority Level

MFC Thread 

```cpp
CWinThread * AfxBeginThread(AFX_THREADPROC, LPVOID pParam, int nPriority = THREAD_PRIORITY_NORMAL, UINT nStackSize=0, DWORD dwCreateFlags=0, LPSECURITY_ATTRIBUTES lpSecurityAttrs= NULL); // worker Thread
CWinThread * AfxBeginThread(CRuntimeClass* pThreadClass, int nPriority = THREAD_PRIORITY_NORMAL, UINT nStackSize=0, DWORD dwCreateFlags=0, LPSECURITY_ATTRIBUTES lpSecurityAttrs= NULL); // UI Thread
```    
* Worker Thread : AFX_THREADPROC
* UI Thread : CRuntimeClass *
 - CWinThread subclass를 실행시키고 CWinThread subclass InitInstance에서 CFraemWnd subclass를 생성한다.
 - CWinApp CWinThread의 subclass이다.

TODO : 
- [ ] 각 객체의 생성관계 및 이벤트 전체 흐름 정리하기

## Synchronization

* CCriticalSection : user mode, 빠름, 프로세스 내에서만 적용
* CMutex : kernel mode, 느림, 프로세스간에도 적용, 이름으로 구별
* CEvnet : event.Lock()을 하면, SetEvent될때까지 기다림
 - auto reset event : SetEvent될때, 기다리고 있는 therad중 하나만 깨우고 자동으로 reset됨
 - manual reset event : SetEvent될때, 기다리는 thread전부를 깨움,상태가 유지되므로 reset해주어야 함.
* CSemaphore : 자원에 접근할 수 있는 thread수를 제어
