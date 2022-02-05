https://kind.sigs.k8s.io/docs/user/quick-start


``` cmd
curl -Lo ./kind https://kind.sigs.k8s.io/dl/v0.10.0/kind-linux-amd64

chmod +x ./kind

mv ./kind /some-dir-in-your-PATH/kind
kubectl cluster-info --context kind-kind

kind delete cluster

kind create cluster --name kind-2

kind export logs

------```
installation unsuccessfull