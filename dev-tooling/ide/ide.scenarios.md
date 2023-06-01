Block copy
---

**from**
```batch
1 'apple'
2 'orange'
3 'pear'
4 $fruit1 =
5 $fruit2 =
6 $fruit3 =

```

**to **
```batch
1
2
3
4 $fruit1 = 'apple';
5 $fruit2 = 'orange';
6 $fruit3 = 'pear';

```
### vs code
1. go to insert mode
2. <C + Alt + Shift> + Arrow keys to block select  the blocks to copy
3. go to start position of past
4. <C + Alt + Shift> + Arrow keys to block select three line
1. <C + v> to past 
 
### vs
1. go to insert mode
2. <Alt + Shift> + Arrow keys to block select  the blocks to copy
3. go to start position of past
4. <Alt + Shift> + Arrow keys to block select three line
1. <C + v> to past 

---
## to copy the method or function
1. go to { 
2. V%y