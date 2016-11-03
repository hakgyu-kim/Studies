#IOCP(I/O Completion Port)

**Context :**

* client server model에서 다수의 클라이언트가 있다.


**Problem :**

* client당 thread를 하나씩 생성하면 다수의 thread가 생성된다.
* context swiching overhead 발생하므로, core 수 보다 작게 thread를 생성하자.


**Solution :**

* Windows에서는 IO Completion Port API를 이용하여 적은 수의 thread로 다수의 client를 대응할 수 있다.


```cpp
HANDLE WINAPI CreateIoCompletionPort(
  _In_     HANDLE    FileHandle,
  _In_opt_ HANDLE    ExistingCompletionPort,
  _In_     ULONG_PTR CompletionKey,
  _In_     DWORD     NumberOfConcurrentThreads
);

BOOL WINAPI PostQueuedCompletionStatus(
  _In_     HANDLE       CompletionPort,
  _In_     DWORD        dwNumberOfBytesTransferred,
  _In_     ULONG_PTR    dwCompletionKey,
  _In_opt_ LPOVERLAPPED lpOverlapped
);

BOOL WINAPI GetQueuedCompletionStatus(
  _In_  HANDLE       CompletionPort,
  _Out_ LPDWORD      lpNumberOfBytes,
  _Out_ PULONG_PTR   lpCompletionKey,
  _Out_ LPOVERLAPPED *lpOverlapped,
  _In_  DWORD        dwMilliseconds
);
```

m_hIOCP = CreateIoCompletionPort(INVALID_HANDLE_VALUE, NULL, 0, 0)로 IOCP핸들을 생성한다.

_ref_

https://msdn.microsoft.com/ko-kr/library/windows/desktop/aa363862(v=vs.85).aspx
