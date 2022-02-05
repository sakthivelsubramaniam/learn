## reference https://kubernetes.io/blog/2020/05/21/wsl-docker-kubernetes-on-the-windows-desktop/
## Installing Kubenetes desktop

    # Download the latest version of KinD
    curl -Lo ./kind https://github.com/kubernetes-sigs/kind/releases/download/v0.7.0/kind-$(uname)-amd64
    # Make the binary executable
    chmod +x ./kind
    # Move the binary to your executable path
    sudo mv ./kind /usr/local/bin/


## Install Kubenetes first cluster

    #Check if the KUBECONFIG is not set
    echo $KUBECONFIG
    # Check if the .kube directory is created > if not, no need to create it
    ls $HOME/.kube
    # Create the cluster and give it a name (optional)
    kind create cluster --name wslkind
    # Check if the .kube has been created and populated with files
    ls $HOME/.kube

