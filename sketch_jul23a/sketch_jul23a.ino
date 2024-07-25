#include <Servo.h>

//Led pin 13
String data;
char d1;

//Servo
String x;
int servoAngleValue;
Servo s1;

//RGB LED
String r;
int ledValue;


void setup() {

  //Setup serial port
  Serial.begin(9600);

  //Define 13th pin as Output pin so that we can control the embedded LED
  pinMode(13,OUTPUT);

  //Define 3th pin as Output pin so that we can control the red LED
  pinMode(3,OUTPUT);

  //Attach servo to pin 9
  s1.attach(9);

}

void loop() {

  //Check whether if Serial Port available first
  if(Serial.available())
  {
    //Take the data sent from VS as string first
    data = Serial.readString();

    //Pass string to char at defined index (0)
    d1 = data.charAt(0);

    //Check whether if the char is 'A' or 'a'. 'A' is open, 'a' is off.
    switch(d1)
    {
      case 'A' : // A = turn on
      digitalWrite(13,HIGH);
      break;

      case 'a' : // a = turn off
      digitalWrite(13,LOW);
      break;

      case 'S' : // S = set servo angle
      //In data string the first value at index 0 will be 'S' and then the angle value will be storing after 1 as index and point is turning those values at index 1,2,3,4 etc to substring
      x = data.substring(1);

      //Convert the value stored in string to real value
      servoAngleValue = x.toInt();

      //Send value to defined servo(s1)
      s1.write(servoAngleValue);

      //Wait for servo to finish its movement
      delay(100);
      break;

      case 'R' : //Set the RED LED intensity
      r = data.substring(1);
      ledValue = r.toInt();
      analogWrite(3, ledValue);
      break;

      
    }

  }

}
