#작업중에 원격의 최신상태 가져오기


__1.임시커밋 생성__
> git commit -m "temp"

__2.commit id 확인__
> git log

__3.신규 브랜치생성__
> git checkout origin/master -b bbb

__4.원격의 최신으로 가져오기__
> git pull

__5.임시커밋 가져오기__
> git cherry-pick 4882a8979c51cc755f0c66e9ab1d22a442a48553



## how to change master branch
__1.로컬의 master를 임시로 다른이름으로 변경__
> git branch -m master abcde

__2.신규 브랜치를 master로 변경__
> git branch -m bbb master

__3.이전 master 브랜치 삭제__
> git branch -D abcde

__작업을 계속한다.__

__merged commit은 rebase하면 정리된다.__
> git rebase
