# SIMD Basic

SIMD : Single Instruction Multiple Data
병렬프로세서의 한 종류로, 하나의 명령어로 여러개의 값을 동시에 계산하는 방식이다.
인텔에서 MMX(MultiMedia eXtension)에서 시작되었고, SSE(Streaming SIMD Extension)을 거처, AVX(Advance Vector eXtension)으로 발전하였다.
원리는 128bit, 256bit 512bit register를 탑재하여 8bit, 16bit, 32bit 데이터 여러개를 하나의 레지스터에 동시에 로딩하고, 동일한 연산을 병렬연산하게 하여, 처리속도를 빠르게한다.

* 128bit : XMM
* 256bit : YMM
* 512bit : GMM

128bit register를 사용하면, 32bit data 4개를 한번에 로드할 수 있고, 두 register에 data를 담아 4쌍의 데이터 연산을 동시에 수행할 수 있다.

방법
* Assembly language : 빠르지만 어렵다.
* Instrinsic function : C code와 유사, 빠르다.
* C class : 성능이 떨어진다.
* Automatic Vectorization : 성능 보장이 안된다.


https://software.intel.com/sites/landingpage/IntrinsicsGuide/
