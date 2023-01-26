let testBalloon


function setup() {
    let canvas = createCanvas(640, 480)
    canvas.parent("gameContainer")
    testBalloon = new Balloon()
}

function draw() {
    //a nice sky blue background
    background(135, 206, 235)
    testBalloon.blowAway()
    testBalloon.checkBounds()
    fill(testBalloon.col)
    circle(testBalloon.x, testBalloon.y, testBalloon.r)
}

class Balloon {
    constructor() {
        this.x = random(width)
        this.y = random(height)
        this.r = 25
        this.vx = 0
        this.vy = 0
        this.col = color(random(255), random(255), random(255))
        this.popped = false
    }

    blowAway() {
        //calculate the blow away force
        let d = dist(this.x, this.y, mouseX, mouseY)
        let force = -10 / (d * d)
        
        //apply the force to the existing velocity
        this.vx += force * (mouseX - this.x)
        this.vy += force * (mouseY - this.y)
    
        //also add some friction to take energy out of the system
        this.vx *= 0.95
        this.vy *= 0.95
    
        //update the position
        this.x += this.vx
        this.y += this.vy
    }

    checkBounds() {
        if (this.x < 0 + this.r) this.x = 0 + this.r
        if (this.x > width - this.r) this.x = width - this.r
        if (this.y < 0 + this.r) this.y = 0 + this.r
        if (this.y > height - this.r) this.y = height - this.r
    }
}

