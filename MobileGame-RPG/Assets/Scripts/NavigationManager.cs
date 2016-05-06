using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class NavigationManager {
    //key, value
    /*
    public static Dictionary<string, string> RouteInformation = new Dictionary<string, string>()
    {
        {"World", "The Big Bad World"},
        {"Cave", "The Deep Dark Cave" },
        {"Village", "The Very Scary Village" },
        {"Swamp", "The Dank Rotting Swamp" },
        {"Witch", "The Evil Witch's House" },
        {"Grove", "The Calm, Quiet Grove" },
        {"Home", "Your Home Town" },
    };
    //*/
    public static Dictionary<string, Route> RouteInformation = new Dictionary<string, Route>()
    {
        {"World", new Route {routeDescription = "The Big Bad World", canTravel = true} },
        {"Cave", new Route {routeDescription = "The Deep Dark Cave", canTravel = false} },
        {"Village", new Route {routeDescription = "The Very Scary Village", canTravel = true}},
        {"Swamp", new Route {routeDescription = "The Dank Rotting Swamp", canTravel = true}},
        {"Witch", new Route {routeDescription = "The Evil Witch's House", canTravel = true}},
        {"Grove", new Route {routeDescription = "The Calm, Quiet Grove", canTravel = true}},
        {"Home", new Route {routeDescription = "Your Home Town", canTravel = true}},
    };
    /// <summary>
    /// Used to interrogate the destination list.
    /// </summary>
    /// <param name="destination"></param>
    /// <returns>Returns the text to display in the prompt.</returns>
    /// NOTE: for those of you taht like to extend on this stuff, you can also use this to create 
    /// a navigation link, which can route the player depending on INVENTORY items or other conditions
    public static string GetRouteInformation(string destination)
    {
        return RouteInformation.ContainsKey(destination) ? RouteInformation[destination].routeDescription : null;
    }

    //Will complete later
    /// <summary>
    /// Limits the players travel based on their current destination.
    /// </summary>
    /// <param name="destination">The target destination</param>
    /// <returns></returns>
    public static bool CanNavigate(string destination)
    {
        return RouteInformation.ContainsKey(destination) ? RouteInformation[destination].canTravel : false;
    }

    /// <summary>
    /// Instantiates navigation. Controls the exact things that happen when the player travels.
    /// </summary>
    /// <param name="destination">The destination that the player will navigate to.</param>
    public static void NavigateTo(string destination)
    {
        //will complete later
        //SceneManager.LoadLevel(destination);
    }
}

public struct Route
{
    public string routeDescription;
    public bool canTravel;
}