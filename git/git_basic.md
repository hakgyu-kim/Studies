## git basic

* show last log

> git log -1

* add current chanage and create commit

> git commit -m "commit message" -a

* create branch from branch

> git branch RB_1.0 master

* change branch

> git checkout RB_1.0

* create tag

> git tag 1.0 RB_1.0

* show tag

> git tag

* get change on RB_1.0 onto master

> git checkout master

> git rebase RB_1.0

* delete branch

> git branch -d RB_1.0

* create branch from tag(1.0)

> git branch RB_1.0.1 1.0

* create archive with tag 1.0

> git archive --format=zip --prefix=mysite-1.0/ 1.0 > mysite-1.0.zip

* show difference

> git diff

> git diff -- cached

