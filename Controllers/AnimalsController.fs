namespace AnimalsApi.Controllers

open Microsoft.AspNetCore.Mvc
open AnimalsApi

[<ApiController>]
[<Route("[controller]")>]
type AnimalController () =
  inherit ControllerBase()

  member _.Get() =
    [ { Name = "Fido"; Species = "Dog"}
      { Name = "Felix"; Species = "Cat"} ]