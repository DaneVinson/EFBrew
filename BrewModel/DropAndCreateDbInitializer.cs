using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewModel
{
    /// <summary>
    /// Initializer that inherits DropCreateDatabaseAlways for BrewContext. Override of Seed method
    /// will seed the database with sample data.
    /// </summary>
    public class DropAndCreateDbInitializer<TContext> : DropCreateDatabaseAlways<TContext> where TContext : BrewContext
    {
        protected override void Seed(TContext context)
        {
            var draft = context.Servings.Add(new Serving() { Name = "Draft" });
            var can = context.Servings.Add(new Serving() { Name = "12 Ounce Can" });
            var bottle = context.Servings.Add(new Serving() { Name = "12 Ounce Bottle" });
            var largeCan = context.Servings.Add(new Serving() { Name = "14 Ounce Can" });
            var largeBottle = context.Servings.Add(new Serving() { Name = "22 Ounce Bottle" });

            var alt = context.BeerStyles.Add(new BeerStyle() { Name = "Alt" });
            var bitter = context.BeerStyles.Add(new BeerStyle { Name = "English Bitter" });
            var red = context.BeerStyles.Add(new BeerStyle { Name = "American Red Ale" });
            var ipa = context.BeerStyles.Add(new BeerStyle() { Name = "Indian Pale Ale" });
            var lager = context.BeerStyles.Add(new BeerStyle() { Name = "Lager" });
            var pale = context.BeerStyles.Add(new BeerStyle() { Name = "Pale Ale" });
            var pilsner = context.BeerStyles.Add(new BeerStyle() { Name = "Pilsner" });
            var porter = context.BeerStyles.Add(new BeerStyle() { Name = "Porter" });
            var stout = context.BeerStyles.Add(new BeerStyle() { Name = "Stout" });

            var deschutes = context.Breweries.Add(new Brewery() { Beers = new List<Beer>(), Location = "Bend, OR USA", Name = "Deschutes Brewing" });
            var fort = context.Breweries.Add(new Brewery() { Beers = new List<Beer>(), Location = "Astoria, OR USA", Name = "Fort George Brewing" });
            var guinness = context.Breweries.Add(new Brewery() { Beers = new List<Beer>(), Location = "Dublin, Ireland", Name = "Guiness Brewery" });
            var lucky = context.Breweries.Add(new Brewery() { Beers = new List<Beer>(), Location = "Portland, OR USA", Name = "Luck Labrador Brewing" });
            var stone = context.Breweries.Add(new Brewery() { Beers = new List<Beer>(), Location = "San Diego, CA USA", Name = "Stone Brewery" });

            deschutes.Beers.Add(new Beer() { Abv = 5.0M, Name = "Mirror Pond Pale Ale", BeerStyle = pale, Servings = new List<Serving>() { draft, bottle } });
            deschutes.Beers.Add(new Beer() { Abv = 5.2M, Name = "Black Butte Porter", BeerStyle = porter, Servings = new List<Serving>() { draft, bottle } });
            deschutes.Beers.Add(new Beer() { Abv = 5.3M, Name = "Bachelor ESB", BeerStyle = bitter, Servings = new List<Serving>() { draft, bottle } });
            deschutes.Beers.Add(new Beer() { Abv = 5.0M, Name = "Keller Pils", BeerStyle = pilsner, Servings = new List<Serving>() { draft, bottle } });
            fort.Beers.Add(new Beer() { Abv = 5.1M, Name = "1811 Lager", BeerStyle = lager, Servings = new List<Serving>() { draft, largeCan } });
            fort.Beers.Add(new Beer() { Abv = 5.5M, Name = "Sunrise Oatmeal Pale Ale", BeerStyle = pale, Servings = new List<Serving>() { draft, largeCan } });
            fort.Beers.Add(new Beer() { Abv = 7.7M, Name = "Vortex IPA", BeerStyle = ipa, Servings = new List<Serving>() { draft, largeCan } });
            fort.Beers.Add(new Beer() { Abv = 8.8M, Name = "Cavatica Stout", BeerStyle = stout, Servings = new List<Serving>() { draft, largeCan } });
            guinness.Beers.Add(new Beer() { Abv = 4.2M, Name = "Guinness Irish Stout", BeerStyle = stout, Servings = new List<Serving>() { draft, largeCan } });
            lucky.Beers.Add(new Beer() { Abv = 6.3M, Name = "Super Dog IPA", BeerStyle = ipa, Servings = new List<Serving>() { draft } });
            lucky.Beers.Add(new Beer() { Abv = 6.0M, Name = "Crazy Ludwig's Alt", BeerStyle = alt, Servings = new List<Serving>() { draft } });
            lucky.Beers.Add(new Beer() { Abv = 5.4M, Name = "Solar Flare", BeerStyle = pale, Servings = new List<Serving>() { draft } });
            lucky.Beers.Add(new Beer() { Abv = 5.5M, Name = "Rose City Red", BeerStyle = red, Servings = new List<Serving>() { draft } });
            stone.Beers.Add(new Beer() { Abv = 6.9M, Name = "Stone IPA", BeerStyle = ipa, Servings = new List<Serving>() { draft, bottle, largeBottle } });
            stone.Beers.Add(new Beer() { Abv = 5.9M, Name = "Stone Smoked Porter", BeerStyle = porter, Servings = new List<Serving>() { draft, bottle, largeBottle } });
            stone.Beers.Add(new Beer() { Abv = 5.4M, Name = "Stone Pale Ale", BeerStyle = pale, Servings = new List<Serving>() { draft, bottle, largeBottle } });
        }
    }
}
