class Car{
    constructor(x, y, width, height){
        this.x = x
        this.y = y
        this.width = width
        this.height = height

        this.speed = 0
        this.accerleration = 0.2
        this.maxSpeed = 5
        this.friction = 0.05
        this.angle = 0

        this.controls = new Controls()
    }

    update(){
        if(this.controls.foward){
            this.speed += this.accerleration
        }
        if(this.controls.reverse) {
            this.speed -= this.accerleration
        }

        if (this.speed > this.maxSpeed) {
            this.speed = this.maxSpeed;
        }
        if (this.speed < -this.maxSpeed/2) {
            this.speed = -this.maxSpeed/2
        }
        if(this.speed > 0){
            this.speed -= this.friction
        }
        if(this.speed < 0){
            this.speed += this.friction
        }

        if(Math.abs(this.speed) < this.friction){
            this.speed = 0
        }

        if (this.controls.left) {
            this.angle += 0.03
        }
        if (this.controls.right) {
            this.angle -= 0.03
        }

        this.y -= this.speed;
    }

    draw(ctx){
        ctx.beginPath();
        ctx.rect(
            this.x - this.width/2,
            this.y - this.height/2,
            this.width,
            this.height
        )
        ctx.fill();
    }
}