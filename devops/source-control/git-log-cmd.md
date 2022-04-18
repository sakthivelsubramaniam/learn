| commnad | description 
|---|--|
| git log -n 10 --pretty=format:"%an %h" | auther and hash |
| get log -n 10 --pretty=oneline <filename> | file name |
| git log --oneline  |  one line commit |
| git log -n 10 --pretty=oneline | format syntax |
| git log --stat   | |
|  git log --patch/ -p | files that modified, with modification detail |
| git log --after="yy-mm-dd"   | git log after particular date |
| git log --after="2019-11-01" --before="2019-11-08 "  | after and before |
| git log --author="Author name"   | filter by auther |
| git log --grep=" Commit message."   | filter commit by message |
| git log <commit hash> | log by commit id |
| git log <filename> | log history of the file |
| git log <since commitId>..<until commitId> | log history by range |
| git log -n 3 -onelin | limits the number of commits |
