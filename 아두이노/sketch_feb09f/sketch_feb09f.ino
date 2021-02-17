#define LED 13
#define BUZZER 9
#define SERVO 8

#define DO1 262 // 4옥타브 도
#define RE  294
#define MI  330
#define FA  349
#define SOL 392
#define LA  440
#define SI  494
#define DO2 523

#define DELAY 300

const int hakGyo[] = { SOL, SOL, LA , LA , SOL, SOL, MI, SOL, SOL, MI, MI, RE, SOL, SOL, LA, LA, SOL, SOL, MI, SOL, MI, RE, MI, DO1};

void musicStart(){
  for(int i=0; i<sizeof(hakGyo)/sizeof(int); i++){
    tone(BUZZER, hakGyo[i],300);
    delay(DELAY);
  }
}
  
#include <Servo.h>

Servo myservo;  // create servo object to control a servo
// twelve servo objects can be created on most boards

int pos = 0;    // variable to store the servo position

void setup() {
   Serial.begin(9600); // 9600 : 문자 정보 전송 속도
  // LED 출력 설정
  pinMode(LED, OUTPUT);
  pinMode(BUZZER,OUTPUT);

  myservo.attach(8);

}
void servo(){
   for (pos = 0; pos <= 720; pos += 1) { // goes from 0 degrees to 180 degrees
    // in steps of 1 degree
    myservo.write(pos);              // tell servo to go to position in variable 'pos'
    delay(2);                       // waits 15ms for the servo to reach the position
  }
  for (pos = 720; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
    myservo.write(pos);              // tell servo to go to position in variable 'pos'
    delay(2);                  
}
}

void loop() {
  // put your main code here, to run repeatedly:
controlSystem();
}

void controlSystem(){
  if (Serial.available()){
      char ch = Serial.read();
      if (ch == '0') { 
          digitalWrite(LED, LOW);
          Serial.println("LED OFF");
        }
        else if(ch == '1'){
          digitalWrite(LED, HIGH);
          Serial.println("LED ON");
          }
        else if(ch == '2'){
          musicStart();
        }
        else if(ch=='3'){
          servo();
          Serial.println("서보");
        }
   }
}
