Utility Type 
-----
* it is used for type transformation
## Pick<Type,Key>

```TypeScript
// Consider PersonInfo type having keys `name` as `string` and `age` as `number`
type PersonInfo = {
  name: string;
  age: number;
};

// PersonName is new type created by Pick<T, Key> by extracting `name` from `PersonInfo`
type PersonName = Pick<PersonInfo, "name">;

// Output:
// PersonName = { name:string }
const person: PersonName = { name: "John Doe" };
```

## Return<Type>

```TypeScript
// Function `createPerson()` returns a PersonInfo object having keys `name` of type `string` and `age` of type `number`
function createPerson(): PersonInfo {
  return {
    name: "John Doe",
    age: 30,
  };
}

// T1 is the new type created by ReturnType<typeof createPerson>
type T1 = ReturnType<typeof createPerson>;

```
## 