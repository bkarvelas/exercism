module RobotName

let charListToString (charList: char []) = System.String(charList)

type Robot = {name: string}

let mkRobot() = 
    let alphabet = "ABCDEFGHIGKLMNOPQRSTUVWXYZ" 
    let numbers = "1234567890"
    let numLen = numbers.Length
    let azLen = alphabet.Length
    let random = System.Random()
    let randomLetters = [|for i in 0..1 -> alphabet.[random.Next(azLen)]|]
    let randomNumbers = [|for i in 0..2 -> numbers.[random.Next(numLen)]|]
    {name = (charListToString randomLetters) + (charListToString randomNumbers)}

let name robot =  robot.name 

let reset robot = 
    let robot1 = robot
    let newRobot = mkRobot()
    let robot2 = {robot1 with name = newRobot.name} 
    robot2