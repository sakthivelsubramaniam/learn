
## configuration
 
* should be done in the settings
``` json
    "vim.insertModeKeyBindings": [
    {
      "before": ["j", "j"],
      "after": ["<Esc>"]
    },
  ],
 "vim.normalModeKeyBindingsNonRecursive": [
    {
        "after" : ["Q"],
        "before" : ["<C-v>"]
    }
],
```

## Visula block mode

 <C-q> - move to visual block mode
 <C-a> - from visual block mode move to multi-cursor, normal 