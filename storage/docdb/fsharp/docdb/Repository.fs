namespace AzDocDb


module Connection =
    
    type T = {EndpointUrl:string;PrimaryKey:string}
    let devConnect = {EndpointUrl="@";
        PrimaryKey="@"
      }
    let localConnect = {EndpointUrl="https://localhost:8081/";
        PrimaryKey="C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw=="
     }
    let getConnection =
        localConnect