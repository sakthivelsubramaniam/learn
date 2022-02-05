
General structure
----------------

Doc = Header, spec
Header = apiversion, metadata, kind
kind = deployment
metadata = 
      name:[name] 
    | labels:
        app : [name]
    | matchLabels:
        app : [name]   

spec =
     Deployment Spec
    | container Spec

Deployment Spec = replicas, selectors, template

template = metadata,spec (container spec)

container Spec = 
    - name
      image
      ports
        -containerPort: 80
      resource
        requests :
            cpu:250m
            memory:64MI
        limits :
            cpu:500m
            memory:356MI





