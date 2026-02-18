**Install MongoDB:**
```sh
helm install balkfet-mongodb oci://registry-1.docker.io/cloudpirates/mongodb \
    --namespace balkfet-infra \
    --create-namespace \
    --version 0.12.2 \
    --set auth.enabled=false \
    --set persistence.size=1Gi
```

**Install the app with a given configuration:**
```sh
kubectl apply -f deployment/local/
# OR
kubectl apply -f deployment/prod/
```

**Troubleshooting:**
Start a busybox pod to test connectivity to MongoDB:
```sh
kubectl run -it --rm --restart=Never bubo --image=busybox:latest -- /bin/sh
# Inside the busybox pod, test connectivity to MongoDB:
ping balkfet-mongodb-headless.balkfet-infra.svc.cluster.local
nc -zv balkfet-mongodb-headless.balkfet-infra.svc.cluster.local 27017
```
