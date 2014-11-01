
// ServoJoy - sample code from morzel.net blog post 

#include <Servo.h>  

const byte setupReadyLedPin = 8;
const byte panServoPin = 10;
const byte tiltServoPin = 12;
const byte separator = 255;

Servo panServo; 
Servo tiltServo; 

void setup() {  
    pinMode(setupReadyLedPin, OUTPUT);
         
    panServo.attach(panServoPin);   
    tiltServo.attach(tiltServoPin);   
    
    Serial.begin(9600); // Open connection with PC
    
    digitalWrite(setupReadyLedPin, HIGH);
}

void loop() {      
    if (Serial.available() > 2) {            
        byte panAngle = Serial.read();
        byte tiltAngle = Serial.read();
        byte thirdByte = Serial.read();
         
        if (panAngle != separator && tiltAngle != separator && thirdByte == separator) {         
            // Moving servos
            panServo.write(panAngle);
            tiltServo.write(tiltAngle);
        }
    }       
}
