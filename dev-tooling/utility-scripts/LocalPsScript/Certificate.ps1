
# list the certificate from store
get-childitem ‘cert:\localMachine\my\’

# remove the certicate from store
Remove-Item ‘cert:\localMachine\my\C24F7E09E885AA89DC39DD4D78B9B38A9052CE79’
