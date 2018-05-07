# Netfluid.Web http://netfluid.org/
Easy embeddable application server to expose class an methods over the net

##Getting started
To expose a method all you need to do is to mark it with the Route attribute.
The route defines on wich URL the method will be invoked.

```
[Route("/my/rest")]
public static dynamic List()
{
    //When a method returns a class or an enumerable they are automatically JSON serialized
    return Database.Elements.All;
}
```

Distinguish HTTP methods:
```
[Route("/myclass")]
class MyClass
{
    [Route("/","POST")]public dynamic Create() { /*....*/ }
    [Route("/","GET")]public dynamic Read() { /*....*/ }
    [Route("/","POST")]public dynamic Update() { /*....*/ }
    [Route("/","GET")]public dynamic elete() { /*....*/ } 
}
```

Method parameters are automatically parsed from POST and GET arguments.
```
[Route("/myclass")]
class MyClass
{
    dynamic SignUp(string username, string password, EMailAddress address) { /*...*/ }
}
```

To enable the automatic parsing on self defined class, add the **public static T Parse(string)** method to the class
```
class User
{
    public string Id;
    public string Name;
    public string Password;
    
    public static User Parse(string id)
    {
        return Database.Where(x=>x.Id==id);
    }
}
```

```
class Exposer
{
    [Route("/user")]
    public static dynamic ShowUser(User user)
    {
        return user;
    }
}
```

To set in-URL parameters, mark them with **:**
```
[Route("/new/:date/:value")]
public static dynamic MyMthod(DateTime date, MyEnum value)
{
    /*....*/
}
```

Accessing the context

Netfluid.Web contains a wrapper to the **HttpListenerConxtext**, his name is **Context**.
To access the current context just define a parameter in your method using the context type
```
[Route("/")]
public static dynamic MyMthod(Context cnt)
{
    cnt.Request.Files.ForEach(x=>Console.WriteLine(x.FileName));
}
```

To set and read session value, use the *Session* method of the context
```
[Route("/")]
public static dynamic MyMthod(Context cnt)
{
    if(cnt.Session<User>("user")==null)
        cnt.Session<User>("user", User.Anonymous);
}
```

To grant or not access to part of your website, use the **Filter**.
If a filter returns something different from **false** the execution of the current context is stopped and the value returned.
If a filter defines a Route, the filter is invoked only on URLs matching that regex, otherwise is invoke on any URL.

```
[Filter]
public static dynamic WalledGarden(Context cnt)
{
    if(cnt.Session<User>("user")==null)
        return new MustacheTemplate("./login.html");
    
    return false;
}
```

