
$(document).ready(function(){
    class Ship
  {
    constructor(name, crew, fuel, hull, speed, img) {
        this.name = name;
        this.crew = crew;
        this.fuel = fuel;
        this.hull = hull;
        this.speed = speed;

        this.credits = 500;
        this.img = img;
        this.isWorking = false;
        this.isDamaged = false;
        this.isDestroyed = false;
        this.dockedPlanet = null;
        this.maxFuel = fuel;
        this.maxHull = hull;
    }
    start(planet) {

        if (!planet instanceof Planet) {
            console.log("Can't go to something that is not a planet")
            return
        }

        let fuelNeeded = this.fuel - (planet.distance * 20);
        if (this.dockedPlanet === planet) {
            console.log("Can't go to a planet that a ship is docked on")
            return
        }

        if (this.isDamaged === true || this.isDestroyed || this.crew < 1) {
            console.log("Can't start the ship");
            return;

        } else {
            this.isWorking = true;
            console.log(`ship is heading to ${planet.name}`)
            setTimeout(() => {
                this.fuel = this.fuel - fuelNeeded;
                this.dock(planet)
            }, planet.distance * 1000 / this.speed);
            return


        }
    }

    dock(planet) {
        let that = this;
        console.log(`Ship is docking ${planet.name}`)
        setTimeout(() => {
            console.log(`${that.name} is docked`)
            planet.shipsDocked.push(this);
            that.isWorking = false;
            that.dockedPlanet = planet.name;


        }, 2000)







    }
}


class Planet{
    constructor(name, size, population, distance, development){
        this.name = name;
        this.size = size;
        this.population = population;
        this.distance = distance;
        this.shipsDocked = [];
        this.development = development;
    }
    getMarketPrice(price){
        return this.development * price - Math.floor(this.population / this.size);
    }
    repair(ship){
        if(!ship instanceof Ship){
            console.log(`${ship} is not a ship.`);
            return;
        }
        if(this.shipsDocked.length === 0){
            console.log(`You are not docked on this planet!`);
            return;
        }
        if(ship.hull >= ship.hullMax){
            console.log(`Your ship is in great shape already!`);
            return;
        }
        let price = this.getMarketPrice(game.price.repair);
        if(ship.credits >= price){
            ship.credits -= price;
            ship.hull = ship.hullMax;
            ship.isDamaged = false;
            console.log("Hulls repaired!");
        } else {
            console.log(`You need ${price - ship.credits} more credits.`);
        }
    }
    refuel(ship){
        if(!ship instanceof Ship){
            console.log(`${ship} is not a ship.`);
            return;
        }
        if(this.shipsDocked.length === 0){
            console.log(`You are not docked on this planet!`);
            return;
        }
        if(ship.fuel >= ship.fuelMax){
            console.log(`Your fueltank is already full!`);
            return;
        }
        if(this.ship )
        console.log(game.price.fuel);
        let price = this.getMarketPrice(game.price.fuel);
        if(ship.credits >= price){
            ship.credits -= price;
            ship.fuel = ship.fuelMax;
            console.log("Ship refuled!");
        } else {
            console.log(`You need ${price - ship.credits} more credits.`);
        }
    }
    hireCrewMember(ship){
        if(!ship instanceof Ship){
            console.log(`${ship} is not a ship.`);
            return;
        }
        if(this.shipsDocked.length === 0){
            console.log(`You are not docked on this planet!`);
            return;
        }
        let price = this.getMarketPrice(game.price.crew);
        if(ship.credits >= price){
            ship.credits -= price;
            ship.crew += 1;
            console.log("A new crew member boarded the ship!");
        } else {
            console.log(`You need ${price - ship.credits} more credits.`);
        }
    }
}



let price = {
        fuel: 50,
        repair: 60,
        crew: 80
    }

var ships = [
    new Ship("StarFighter", 3, 380, 500, 0.5, "img/StarFighter.png"),
    new Ship("Crushinator", 5, 540, 400, 0.2, "img/Crushinator.png"),
    new Ship("Scouter", 1, 300, 300, 0.9, "img/Scouter.png")
]

var planets = [
    new Planet("Rubicon9", 300000, 2000000, 4, 2, "img/Rubicon9.png"),
    new Planet("R7", 120000, 4000000, 7, 3, "img/R7.png"),
    new Planet("Magmus", 500000, 10000000, 6, 1, "img/Magmus.png"),
    new Planet("Dextriaey", 50000, 500000, 9, 3, "img/Dextriaey.png"),
    new Planet("B18-1", 250000, 4000000, 12, 2, "img/B18-1.png")
]


ships[2].start(planets[1])
setTimeout(() => {
    console.log(planets[3].refuel(planets[1]))
   


}, 15000)


})