#define LED 13
const int BUZZER = 10;
//const int LED = 13;  같은 의미



 
void setup(void)
{
  pinMode(9, OUTPUT);//buzzer
  pinMode(13, OUTPUT);//led indicator when singing a note
 
}
void loop()
{
  //sing the tunes
  sing(1);
  sing(1);
  sing(2);
}
int song = 0;
 
void sing(int s) {
  // iterate over the notes of the melody:
  song = s;
  if (song == 2) {
    Serial.println(" 'Underworld Theme'");
    int size = sizeof(underworld_melody) / sizeof(int);
    for (int thisNote = 0; thisNote < size; thisNote++) {
 
      // to calculate the note duration, take one second
      // divided by the note type.
      //e.g. quarter note = 1000 / 4, eighth note = 1000/8, etc.
      int noteDuration = 1000 / underworld_tempo[thisNote];
 
      buzz(melodyPin, underworld_melody[thisNote], noteDuration);
 
      // to distinguish the notes, set a minimum time between them.
      // the note's duration + 30% seems to work well:
      int pauseBetweenNotes = noteDuration * 1.30;
      delay(pauseBetweenNotes);
 
      // stop the tone playing:
      buzz(melodyPin, 0, noteDuration);
 
    }
 
  } else {
 
    Serial.println(" 'Mario Theme'");
    int size = sizeof(melody) / sizeof(int);
    for (int thisNote = 0; thisNote < size; thisNote++) {
 
      // to calculate the note duration, take one second
      // divided by the note type.
      //e.g. quarter note = 1000 / 4, eighth note = 1000/8, etc.
      int noteDuration = 1000 / tempo[thisNote];
 
      buzz(melodyPin, melody[thisNote], noteDuration);
 
      // to distinguish the notes, set a minimum time between them.
      // the note's duration + 30% seems to work well:
      int pauseBetweenNotes = noteDuration * 1.30;
      delay(pauseBetweenNotes);
 
      // stop the tone playing:
      buzz(melodyPin, 0, noteDuration);
 
    }
  }
}
 
void buzz(int targetPin, long frequency, long length) {
  digitalWrite(13, HIGH);
  long delayValue = 1000000 / frequency / 2; // calculate the delay value between transitions
  //// 1 second's worth of microseconds, divided by the frequency, then split in half since
  //// there are two phases to each cycle
  long numCycles = frequency * length / 1000; // calculate the number of cycles for proper timing
  //// multiply frequency, which is really cycles per second, by the number of seconds to
  //// get the total number of cycles to produce
  for (long i = 0; i < numCycles; i++) { // for the calculated length of time...
    digitalWrite(targetPin, HIGH); // write the buzzer pin high to push out the diaphram
    delayMicroseconds(delayValue); // wait for the calculated delay value
    digitalWrite(targetPin, LOW); // write the buzzer pin low to pull back the diaphram
    delayMicroseconds(delayValue); // wait again or the calculated delay value
  }
  digitalWrite(13, LOW);
 
}




// 숨겨진 main에서 setup과 loop 호출을 해서 이 프로그램이 작동하는 것
void setup() {
  // put your setup code here, to run once:
  // 시리얼 통신 속도 (baudrate : 통신 속도)
  Serial.begin(9600); // 9600 : 문자 정보 전송 속도
  // LED 출력 설정
  pinMode(LED, OUTPUT);  //부저 제어
}

void loop() {
// //  put your main code here, to run repeatedly:
//  // 데이터 송신 : 아두이노 -> PC
//  Serial.print("온도:26.5");
//  Serial.println();
//  delay(2000);

  // 데이터 송신 : PC -> 아두이노
  controlSystem();
  sing();
  
}

void controlSystem() {if (Serial.available()){ // Serial.available : 데이터가 수신되어졌으면
      char ch = Serial.read();
      if (ch == '1') {
          digitalWrite(LED, HIGH);
          Serial.println("LED ON");
        }
        else if (ch == '0') {
          digitalWrite(LED, LOW);
          Serial.println("LED OFF");  
        }
        else if( ch=='2'){
        
        }
        else if(ch=='3'){
          
        }
        delay(50);
    }}
