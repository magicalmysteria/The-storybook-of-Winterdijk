
/*void loop() {
  // If the analog value is higher than 512
  if ( analogRead(A0) > 512 ) {
  Serial.println("right");
    
    // turn the LED on
    //digitalWrite(13, HIGH);
  } 
  else if ( analogRead(A0) < 348 ) {
    Serial.println("left");
  }
  
  else {
    // turn the LED off
    //digitalWrite(13, LOW);
  }
}
*/
// constants won't change. They're used here to set pin numbers:
const int buttonPin = 2;     // the number of the pushbutton pin

// variables will change:
int buttonState = 0;         // variable for reading the pushbutton status

void setup() {
  //pinMode(13, OUTPUT);
  Serial.begin(9600);

  pinMode(buttonPin, INPUT);
}

void loop() {
  // read the state of the pushbutton value:
  buttonState = digitalRead(buttonPin);

  // check if the pushbutton is pressed. If it is, the buttonState is HIGH:
  if (buttonState == HIGH) {
    Serial.println("Text");
    // turn LED on:
  } else {
    Serial.println("No text");
    // turn LED off:
  }

   if ( analogRead(A0) > 900 ) 
   {
     Serial.println("right");
   }
    else if ( analogRead(A0) < 800 ) {
    Serial.println("left");
    }
}
