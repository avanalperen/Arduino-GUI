#include <Servo.h>

//Led pin 13
String data;
char d1;

//Servo
String x;
int servoAngleValue;
Servo s1;

//RGB LED
String l;
int ledValue;

//Pushbutton
unsigned long lastDebounceTime = 0;
unsigned long debounceDelay = 5;
int buttonState;
int lastButtonState = HIGH; 

//Potentiometer
bool openPot = false;

//Purpose of debounce timer is to indicate that the button is not pushed in that time againly to control it in more efficient way
void handleButton(void)
{
  //Read pin 4
  int reading = digitalRead(4);

  //Switch changed state
  if(reading != lastButtonState)
  {
    //Reset the debouncing timer - millis()
    lastDebounceTime = millis();
  }

  //Wait for the debounce timer 
  if((millis() - lastDebounceTime) > debounceDelay)
  {
    //If the button state has changed
    if(reading != buttonState)
    {
      buttonState = reading; 

      //Send data if button state is high
      if(buttonState == HIGH) 
      {
        Serial.println("p");
      }
    }
  }
  //Save the reading for the next time through the loop
  lastButtonState = reading;
}

//To take values from potentiometer and handle the data about it
void handlePot(void)
{
  String val;
  static int old = 0;
  int current = 0 , upper, lower;

  current = analogRead(A0);

  //To avoid jigger every time we use upper and lower method with if statements
  upper = current + 2;
  lower = current - 2;

  if(current != old)
  {
    //If its lower value bigger than old it updates value automatically and also, if its upper value is equals or lower than old value
    if((old <= lower) || (old >= upper))
    {
      val = String(current);
      
      delay(200);

      Serial.print("v");
      Serial.println(val);

      //At the and it makes old value equal to current for catching new lower value
      old = current;
    }
  }
}

void setup() {

  //Setup serial port
  Serial.begin(9600);

  //Define 13th pin as Output pin so that we can control the embedded LED
  pinMode(13, OUTPUT);

  //Define 3th pin as Output pin so that we can control the red LED
  pinMode(3, OUTPUT);

  //Define 5th pin as Output pin so we control the grey LED
  pinMode(5,OUTPUT);

  //Define 6th pin as Output pin so we can control the blue LED
  pinMode(6,OUTPUT);

  //Define 4th pin as Input Pullup pin so that pushbutton can be followed whether is pushed or not
  pinMode(4, INPUT_PULLUP);

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

      case 'R' : //Set the RED LED intensity(3rd Pin)
      l = data.substring(1);
      ledValue = l.toInt();
      analogWrite(3, ledValue);
      break;

      case 'G' : //Set the GREY LED intensity(5th Pin)
      l = data.substring(1);
      ledValue = l.toInt();
      analogWrite(5, ledValue);
      break;

      case 'B' : //Set the BLUE LED intensity(6th Pin)
      l = data.substring(1);
      ledValue = l.toInt();
      analogWrite(6, ledValue);
      break;

      case 'O' : //Start send potentiometer value
      openPot = true;
      break;

      case 'o' : //Stop send potentiometer value
      openPot = false;
      break;

    }   
  }

  //Call pushbutton function
  handleButton();
  
  if(openPot == true)
  {
    //Call potentiometer function
    handlePot();
  }
  
}


