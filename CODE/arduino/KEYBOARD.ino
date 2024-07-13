/*
================================================
SEND TO THE SERIAL PORT: 0 1 2 3 4 5 6 TO THE OTHER
ARDUINO
-------------------------------------------------
0:SYSTEM DISARMED
1:TIME TO EXIT
2:SYSTEM ARMED
3:ALARM
4:TIME TO ENTRY
5:READ BYPASSZONES
6:ALARM (FIRE)
=================================================


=================================================
TYPE ZONE
-------------------------------------------------
1:TIME DELAY
2:SILENS
3:24
4:BYPASS STAY (sequence)
5:SEQUENS
6:AMESH
7:FIRE
8:TABER
9:BYPASS STAY (no sequence)

--------------------------------------------------
*/


#include <Keypad.h>
#include <LiquidCrystal_I2C.h>

#define EXIT_TIME 5
#define ENTRY_TIME 5

#define USER1A "1111A"
#define USER1D "1111D"
#define USER2A "2222A"
#define USER2D "2222D"
#define USER3A "3333A"
#define USER3D "3333D"

#define BYPASSCODE_1 "1111B"
#define BYPASSCODE_2 "2222B"
#define BYPASSCODE_3 "3333B"

#define TZ1 1
#define TZ2 4
#define TZ3 6
#define TZ4 2
#define TZ5 3
#define TZ6 7

#define TRIES 3
#define TIME_TO_LOCK 5

bool with_sound = true;

int typeZones[8]={TZ1,TZ2,TZ3,TZ4,TZ5,TZ6,10,10};
byte maskFromExitTime=0;
byte maskFromTaber=0;
byte statusZonesAtExit=0xff;

byte stay=1;//an stay=1 tha oplisei se kleitoyrgeia stay
byte hide=0;//int
int buzer = 13;
byte ready; //int
int prev=0;
byte ARMED=0;//int
byte ALARM=0;
byte FIRE=0;
byte SILENS=0;

byte tagDisarmed=0; // den eisai se katasrtasi disarmed 
byte fromFalseCode=0;//otan exo alarm kai patao lathos kodiko 
byte firstTimeBypass=0;
byte firstTimeAlarm=0;//otan dinei alarm proti fora
byte firstTimeFire=0;
byte bypass_mode=0;
byte exit_mode=0;
byte entry_mode=0;
byte code_mode=0;
byte forsed=0;
int timer=EXIT_TIME;
const byte ROWS = 4; 
const byte COLS = 4; 
byte data_count=0;
byte mastercount=0;
char kagelo = '#';
int Pass_Length= 6;
char data[6];
int tries  = 0;
int from_dis=0;

float time_to_lock =  TIME_TO_LOCK * 60000;

int Siren =12;
byte zones_status;
bool prevZone[6];
bool zone[6];
int lock_key=0;
bool bypassZones[6]={1,1,1,1,1,1};
const long interval_exit=1000;
unsigned long pm=0;

char hexaKeys[ROWS][COLS] = {
  {'1', '2', '3', 'A'},
  {'4', '5', '6', 'B'},
  {'7', '8', '9', 'C'},
  {'*', '0', '#', 'D'}
};

byte rowPins[ROWS] = {10, 9, 8, 7}; 
byte colPins[COLS] = {6, 5, 4, 3}; 

Keypad customKeypad = Keypad(makeKeymap(hexaKeys), rowPins, colPins, ROWS, COLS); 

LiquidCrystal_I2C lcd(0x20,16,2); 
unsigned long previousMillis = 0;

void setup() {
  pinMode(Siren,OUTPUT);
  pinMode(buzer,OUTPUT);
  pinMode(12,OUTPUT);
  Serial.begin(9600);
  lcd.init();
  lcd.clear();         
  lcd.backlight();      
  
  
  lcd.setCursor(2,0);  
  lcd.print("SYSTEM START");
  delay(2000);
  
  lcd.setCursor(2,1);   
  lcd.print("WAIT TO INIT");
  delay(2000);
  lcd.clear();
  
  //ftiaxno maska gia alarm kata ton xrono exodoy
  maskFromExitTime =  makeMask(1,4,5);
  maskFromTaber = makeMask(3,3,3);
  

}

void loop() {
  
//--- LOCK KEYBOARD---(START)-------------------
  
 if(tries>=TRIES){
      
     unsigned long currentMillis = millis(); 
       digitalWrite(12,HIGH);
     // Ελέγχουμε αν έχει περάσει το διάστημα interval από το προηγούμενο millis
     if (currentMillis - previousMillis >= (time_to_lock)) {
    // Αποθηκεύουμε το τρέχον millis ως το προηγούμενο millis
     digitalWrite(12,LOW);
     tries=0;
     }
    
 }
 else{
     previousMillis=millis();
  }
 
//--- LOCK KEYBOARD---(END)---------------------
  
 
  
//----WHEN I AM CODING AND SYSTEM IS DISARMED--
//----ZONES CHANGE---(START)-------------------
 if(code_mode && Serial.available() != 0 && !ARMED && !FIRE){
     lcd.clear();
     readZones();//diavazo ti stelnei to allo arduino 
     isReady();  //apofasi an einai Ready kai ektyposi
     code_mode=0;
     clearData();
     //forsed=1;
     } 
//----WHEN I AM CODING AND SYSTEM IS DISARMED--
//----ZONES CHANGE---(END)-------------------
 
//---------FOR KEYBOARD -(START)--------//
char customKey = customKeypad.getKey();

if (customKey && tries<TRIES){
   
     hide=1;
     data[data_count] = customKey;  
     if(data_count==0 && customKey!=kagelo && !bypass_mode ){
       lcd.clear();
       code_mode=1;
       lcd.setCursor(0,0);
       lcd.print("ENDER CODE AND ");
       lcd.setCursor(0,1);
       if  (!ARMED && !exit_mode && !FIRE) lcd.print("PRESS A: ");
       else                        lcd.print("PRESS D: ");
       lcd.setCursor(10+data_count,1);
       lcd.print("*___");
     }
     if(!bypass_mode){
       lcd.setCursor(10+data_count,1);
       lcd.print("*");
     }
     //if read number 1 to 6  tongle bypass status Zones
     if(bypass_mode &&(customKey == '1' || customKey == '2' ||
                       customKey == '3' || customKey == '4' ||
                       customKey == '5' || customKey == '6'  )){
       if(typeZones[customKey-49] !=7 ){
            bypassZones[customKey -49 ] = !bypassZones[customKey -49 ];
        }else{
            tone(buzer,1000);
            delay(100);
            noTone(buzer);
            lcd.clear();
            lcd.setCursor(0,0);
            lcd.print("THIS ZONE CANNOT");
            lcd.setCursor(0,1);
            lcd.print("BE BYPASSED-FIRE");
            delay(2000);
            firstTimeBypass=1;
        }
          clearData();
      }
     if(bypass_mode) clearData();
     
     if(customKey==kagelo){
         lcd.clear();
         if(!bypass_mode){
            lcd.setCursor(2,0);   
            lcd.print("CLEAR CODE");
            delay(1500);
         }
            clearData();
            code_mode=0;  
         data_count--;
         hide=0; 
         if(!ARMED && !exit_mode && !bypass_mode){
              forsed=1;
           }     
         lcd.clear();
         if(ARMED && !ALARM && !entry_mode) {
              printArmedMess();
              delay(1000);
             // fromFalseCode=1;
              firstTimeAlarm=1;
         }
        else if(ARMED && ALARM==1){
              printAlarmMess();
              delay(1000);
              fromFalseCode=1;
              firstTimeAlarm=1;
         }
       else if(FIRE){
              firstTimeFire=1;
         
       }
       //if bypass mode and press #
       else if(bypass_mode){ 
              printExitBypassMess();
              delay(1000);
              lcd.clear();
              forsed=1;
              //When exit from bypass mode send zones to are bypass
              byte byteArray = 0; // Αρχικοποίηση του πίνακα byte
              for (int i = 0; i < 6; i++) {
                  if (bypassZones[i]) {
                  byteArray |= (1 << i); 
                  }
               }
              Serial.print("5");
              Serial.write(byteArray);
        }
          bypass_mode =0;
      }  

     data_count++; 
} 
// when press code check if belongs a user for ARMED SYSTEM
if(data_count == Pass_Length-1){
if(!strcmp(data,USER1A)||
       !strcmp(data,USER2A)||
       !strcmp(data,USER3A)  ){
        if(ready==1 && !ARMED && !exit_mode){ 
          lcd.clear();
          exit_mode=1;
          code_mode=0;
          timer=EXIT_TIME;
          Serial.print("1");
         }
        //IS ARMED and try to ARMED AGAIN THE SYSTEM and
        //a message appears is already Armed 
        else if(ARMED && !ALARM && !exit_mode && !entry_mode ){
          tone(buzer,1000);
          delay(100);
          noTone(buzer);
          printAlreadyArmed();
          delay(500);  
          printArmedMess();
          delay(1000);      
         }
        //IS ARMED and try to ARMED AGAIN when i am at  exit mode and
        //a message appears is already Armed 
        else if((!ARMED && exit_mode) || entry_mode){
          tone(buzer,1000);
          delay(100);
          noTone(buzer);
          lcd.clear();
          printAlreadyArmed();
          delay(1000);
          lcd.clear();
           
         }
        //IS ALARM  and try to ARMED AGAIN 
        //a alarm message appears is SYSTEM ALARM  
        else if(ARMED && ALARM==1){
              tone(buzer,1000);
              delay(100);
              noTone(buzer);
              printAlarmMess();
              delay(500);
              fromFalseCode=1;
              firstTimeAlarm=1;
              
         }
	    else if(FIRE){
              tone(buzer,1000);
              delay(100);
              noTone(buzer);
              printFireMess();
              delay(1000);
              firstTimeFire=1;
              code_mode=0;
 	     }
        //try to  ARMED SYSTEM but some zones are open and 
        //a buzzer sound will sound
        else{
          tone(buzer,1000);
          delay(100);
          noTone(buzer);
          lcd.clear();
          lcd.setCursor(1,0);  
          lcd.print(" ZONES OPEN");
          lcd.setCursor(0,1); 
          lcd.print("CLOSE TRY AGAIN");
          delay(1500);
          lcd.clear();
          code_mode=0;
          forsed=1;
        }
       
}
  
// when press code check if belongs a user for DISARMED SYSTEM
else if(!strcmp(data,USER1D)||
        !strcmp(data,USER2D)||
        !strcmp(data,USER3D) ){
          if(ARMED || exit_mode || FIRE){
             if(with_sound) noTone(buzer);
             lcd.clear();
             lcd.setCursor(1,0);  
         	   lcd.print("SYSTEM DISARMED");
         	   lcd.setCursor(3,1); 
        	   lcd.print(" WELCOME");
          	 delay(1000);
             SILENS=0;            
             stay=1;
             tagDisarmed=0;
             forsed=1;
          	 code_mode=0;
          	 exit_mode=0;
             entry_mode=0;
          	 noTone(buzer); 
            if(ALARM || ARMED || FIRE){
                for(int i=0; i<6;i++){
                   bypassZones[i] =1;
                   zone[i]=1;
                   prevZone[i]=1;    
                 }         
            }
            ARMED=0;
            ALARM=0;
            FIRE = 0;
            
          	 Serial.print(0);
             lcd.clear();
            if(!ALARM) from_dis = 1;
              
          }
        
         //SYSTEM is already DISARMED and a message appears 
         //for this
         else{
           tone(buzer,1000);
           delay(100);
           noTone(buzer);
           lcd.clear();
           lcd.setCursor(1,0);  
         	 lcd.print("SYSTEM ALREADY");
         	 lcd.setCursor(3,1); 
        	 lcd.print(" DISARMED");
           delay(1000);
           lcd.clear();
           code_mode=0;
           
			 forsed=1;
           
            }
  
}
//ENDER 0000b	 to go bypass mode
else if((!strcmp(data,BYPASSCODE_1)    ||
        !strcmp(data,BYPASSCODE_2)     ||
         !strcmp(data,BYPASSCODE_3))  && 
        !ARMED && !ALARM &&!exit_mode  && 
        !entry_mode  && !FIRE       ){
          bypass_mode=1;//!bypass_mode;
          firstTimeBypass=1;
          code_mode=0;
}
//INCORECT CODE
else{
       tries++;
       if(tries  <TRIES){
          tone(buzer,1000);
          delay(100);
          noTone(buzer);
          lcd.clear();
          lcd.setCursor(1,0);  
          lcd.print("INCORRECT CODE");
          lcd.setCursor(1,1); 
          lcd.print("  TRY AGAIN");
          delay(1000);
       }
        else{
          String min = String(TIME_TO_LOCK);
          tone(buzer,1000);
          delay(100);
          noTone(buzer);
          lcd.clear();
          lcd.setCursor(1,0);  
          lcd.print("KEYBOARD LOCK");
          lcd.setCursor(1,1); 
          lcd.print("FOR ");
          lcd.setCursor(5,1); 
          lcd.print(min);
          lcd.setCursor(7,1);
          lcd.print("MINUTES");
          delay(2000);
          lock_key=1;
       }
       
       lcd.clear();
       code_mode=0;
       if(!ARMED && !ALARM && !exit_mode && !FIRE){
              lcd.clear();
              forsed=1;
           //   readZones(); epifovo
              isReady();
       }
       if(ARMED && !ALARM && !entry_mode){
              printArmedMess();
              delay(1000);
              firstTimeAlarm=1;
       }
       if(ARMED && ALARM){
              printAlarmMess();
              delay(1000);
              fromFalseCode=1;
              firstTimeAlarm=1;
       }
       if(FIRE){
            firstTimeFire=1;
       }
}
 hide=0;
 clearData();
                                    
}
//------ FOR KEYBOARD (END) -------------//
  
//-------BYPASS MODE (START)--------------// 
if(bypass_mode){
  if(firstTimeBypass){
    lcd.clear();
    lcd.setCursor(1,0);
    lcd.print("ZONES BYPASS");
    firstTimeBypass=0;
  }
    lcd.setCursor(1,1);
    printZonesBypass();
}
  
//-------BYPASS MODE (END)--------------//
  
  
//-------EXIT MODE (START)-----------------//
if(exit_mode){
  unsigned long cm = millis();
  if(cm - pm >= interval_exit){
    pm=cm;
    if(!hide){lcd.setCursor(1,0);  }
    if(!hide){lcd.print("SYSTEM ARMED");}
    if(!hide){lcd.setCursor(1,1);}
    if(!hide){lcd.print("TIME LEFT :");}
	
    
      if(timer>=10){
           if(!hide)lcd.setCursor(13,1);
           if(!hide)lcd.print(timer);
           if(with_sound) tone(buzer, 880);
           delay(30); 
           noTone(buzer); 
       }
      else{
           if(timer==9){
              if(with_sound) tone(buzer, 880);
           }
           //ta sec einai 1 psifio kai moy to metakinoyse
           //kai to buzer xtipaei sinexomena
           if(!hide) lcd.setCursor(13,1);
           if(!hide) lcd.print(" ");
           if(!hide) lcd.setCursor(14,1);
           if(!hide) lcd.print(timer);
       } 
      
      if(Serial.available() > 0) {
          //agnoo zones poy exoyn anoixei typo (1,5) kata tin diarkeia 
          //tis exodoy
           byte tempStatusZones=Serial.read();
           for(int i=0;i<8;i++){
              //an den anoixe katholoy kapoia exodos kata tin diarkeia toy oplismpou
              //tha oplisei me stay
              if(typeZones[i]==1 && !bitRead(tempStatusZones,i))
                stay=0;
              zone[i]=zone[i] && bitRead(tempStatusZones, i);
           }
           statusZonesAtExit = tempStatusZones & maskFromExitTime;
           if(maskFromExitTime!=statusZonesAtExit){
              ARMED=1; 
              ALARM=1;
              firstTimeAlarm=1;
              exit_mode=0;
             // Serial.print("3");
              fromFalseCode=1;
              statusZonesAtExit=0xff;
              forsed=1;
             
            }
      }
      timer--;
      if(timer==-1){
        
        //an den exei anoixei kapoia eisodos kata ton oplismo
        //tote tha oplisoyme me stay
        if(stay){
          for(int i=0;i<6;i++){
            if(typeZones[i]==4 || typeZones[i] == 9)
              bypassZones[i]=0;
          }
         byte byteArray = 0; // Αρχικοποίηση του πίνακα byte
           for (int i = 0; i < 6; i++) {
             if (bypassZones[i]) {
               byteArray |= (1 << i); 
               }
            }
                
              Serial.print("5");
              Serial.write(byteArray);
        
        
        }
        
        
        
        
        ARMED=1;
        firstTimeAlarm=1;
        exit_mode=0;
        noTone(buzer); 
        printArmedMess();
        while (Serial.available() > 0) 
             Serial.read();
        
        if(!stay)Serial.print("2");
        
        clearData();
        hide=0;
       }
    
    }
}
  
//-------EXIT MODE (END)----------------//
  
//-------WHEN SYSTEM ARMED (START)------//
  if(ARMED && !entry_mode && !ALARM && ! FIRE){
    if(1/*Serial.available()!=0*/){
        readZones();
        for(int i=0;i<6;i++){
          if(zone[i]==0){
            if(typeZones[i]==1){
              if(!ALARM){
               entry_mode=1;
               timer=ENTRY_TIME;
               //ARMED=0;
               lcd.clear();
               break;
               }
             }
            else if(typeZones[i]==7){
               FIRE=1;
               firstTimeFire=1;
             }
            else{ 
              firstTimeAlarm=1;
              ALARM=1;
              readZones();
            }
            tagDisarmed=1;
           }
         }
     }
 }
//-------WHEN SYSTEM ARMED (END)------//  
  
//-------ALARM MODE (START)-----------------//
if(ALARM){
    if(firstTimeAlarm){
       clearData();
	   lcd.clear();
       lcd.setCursor(1,0);  
       lcd.print("SYSTEM ALARM :");
       //if(with_sound) tone(buzer, 880);
      // firstTimeAlarm=0;
    }  
  if(Serial.available()!=0 || firstTimeAlarm){
   readZones();
    for(int i=0;i<6;i++){
      if(zone[i]==0 && typeZones[i]!=2 && SILENS == 0 ){
        if(with_sound)  {
             tone(buzer, 880);
        }
       }
     }
     
   printZonesOpen();
  }
  firstTimeAlarm=0;
}
//-------ALARM MODE (END)-----------------//
//-------FIRE MODE (START)-----------------//
if(FIRE){
    if(firstTimeFire){
       //readZones();
       clearData();
	   lcd.clear();
       lcd.setCursor(1,0);  
       lcd.print("SYSTEM FIRE :");
       if(with_sound) tone(buzer, 880);
      // firstTimeAlarm=0;
    }  
  if(Serial.available()!=0 || firstTimeFire){
    readZones();
    printZonesOpen();
    if(code_mode){
       code_mode=0;
       firstTimeFire=1;
    }else{
      firstTimeFire=0;
    }     
  }
}  
//-------FIRE MODE (END)--------------------//
  
//-------ENTRY MODE (START)-----------------//  
if(entry_mode){
   unsigned long cm = millis();
  if(cm - pm >= interval_exit){
    pm=cm;
    if(!hide)lcd.setCursor(1,0);  
    if(!hide)lcd.print("DISARM SYSTEM ");
    if(!hide)lcd.setCursor(1,1);
    if(!hide) lcd.print("TIME LEFT :");
    if(with_sound) tone(buzer, 880);
      if(timer>=10){
           if(!hide)lcd.setCursor(13,1);
           if(!hide)lcd.print(timer);
       }
      else{
           //ta sec einai 1 psifio kai moy to metakinoyse
           //kai to buzer xtipaei sinexomena
           if(!hide) lcd.setCursor(13,1);
           if(!hide) lcd.print(" ");
           if(!hide) lcd.setCursor(14,1);
           if(!hide) lcd.print(timer);
       } 
      
      if(Serial.available() > 0) {
          //agnoo zones poy exoyn anoixei typoy (1,5) kata tin diarkeia 
          //tis eidosoy
           byte tempStatusZones=Serial.read();
           zones_status=zones_status & tempStatusZones;
           for(int i=0;i<8;i++){
              zone[i]=zone[i] && bitRead(tempStatusZones, i);
           }
           statusZonesAtExit = tempStatusZones & maskFromExitTime;
           if(maskFromExitTime!=statusZonesAtExit){
             // ARMED=1; 
              ALARM=1;
              firstTimeAlarm=1;
              entry_mode=0;
             // exit_mode=0;
             //Serial.print("3");
              fromFalseCode=1;
              statusZonesAtExit=0xff;
              forsed=1;
             
            }
      }
      timer--;
      if(timer==-1){
        ALARM=1;
        firstTimeAlarm=1;
        entry_mode=0;
        noTone(buzer); 
        forsed=1;
       // printArmedMess();
        while (Serial.available() > 0) 
             Serial.read();
        
        Serial.print("3");
       }
    
    }
}

//-------ENTRY MODE (END)-----------------//

//-------CHECK READY (START) -----------//
  
if ((Serial.available() != 0 && !exit_mode && !code_mode && !ARMED && !FIRE && !bypass_mode ) || forsed) {
                                           
  // Επεξεργασία των μεμονωμένων bits
 
  readZones();//diavazo ti stelnei to allo arduino 
  isReady();  //apofasi an einai Ready kai ektyposi

  //isTaber();   //koitao an kapoio taber edose alarm
}

//-------CHECK READY (END) -----------//  
 
}
//----------------------------------------//
//--------------FUNCTIONS-----------------//

//clear code and start again
void clearData(){
  while(data_count !=0){
    data[data_count--]=0;
  }
}

//message system ARMED
void printArmedMess(){
        lcd.clear();
        lcd.setCursor(2,0);
        lcd.print("SYSTEM ARMED");
        lcd.setCursor(0,1);
        lcd.print("CODE TO DISARMED");
}
//message system ALARM
void printAlarmMess(){
        lcd.clear();
        lcd.setCursor(2,0);
        lcd.print("SYSTEM ALARM");
        lcd.setCursor(0,1);
        lcd.print("CODE TO DISARMED");
}

//message system ALREADY ARMED
void printAlreadyArmed(){
        lcd.clear();
        code_mode=0;
        lcd.setCursor(1,0);  
        lcd.print("SYSTEM ALREADY");
        lcd.setCursor(3,1); 
        lcd.print("   ARMED");     
}
//message system exit from bypass mode
void printExitBypassMess(){
        lcd.clear();
        lcd.setCursor(0,0);  
        lcd.print("EXIT FROM BYPASS");
        lcd.setCursor(3,1); 
        lcd.print("   MODE");
}
//message system is fire cannot armed
void printFireMess(){
        lcd.clear();
        lcd.setCursor(1,0);  
        lcd.print("ALARM OF FIRE");
        lcd.setCursor(1,1); 
        lcd.print("CANNOT ARMED");
}
//message  PRINT ZONES
void printZonesOpen(){
         if(!zone[0]){
            lcd.setCursor(1,1); 
            lcd.print("1");
          }
          else if(!ARMED){
            lcd.setCursor(1,1); 
            lcd.print("_");
          } 
          if(!zone[1] ){
            lcd.setCursor(3,1); 
            lcd.print("2");
          }
          else if(!ARMED){
            lcd.setCursor(3,1); 
            lcd.print("_");
          } 
          if(!zone[2]){
            lcd.setCursor(5,1); 
            lcd.print("3");
          }
          else if(!ARMED){
            lcd.setCursor(5,1); 
            lcd.print("_");
          } 
          if(!zone[3]){
            lcd.setCursor(7,1); 
            lcd.print("4");
          }
         else if(!ARMED){
            lcd.setCursor(7,1); 
            lcd.print("_");
          } 
          if(!zone[4]){
            lcd.setCursor(9,1); 
            lcd.print("5");
          }
          else if(!ARMED){
            lcd.setCursor(9,1); 
            lcd.print("_");
          } 
          if(!zone[5]/* &&(!FIRE || typeZones[5]==7)*/){
            lcd.setCursor(11,1); 
            lcd.print("6");
          }
          else if(!ARMED){
            lcd.setCursor(11,1); 
            lcd.print("_");
          } 

}
void printZonesBypass(){
    
         if(!bypassZones[0]){
            lcd.setCursor(1,1); 
            lcd.print("1");
          }
          else if(!ARMED){
            lcd.setCursor(1,1); 
            lcd.print("_");
          } 
          if(!bypassZones[1]){
            lcd.setCursor(3,1); 
            lcd.print("2");
          }
          else if(!ARMED){
            lcd.setCursor(3,1); 
            lcd.print("_");
          } 
          if(!bypassZones[2]){
            lcd.setCursor(5,1); 
            lcd.print("3");
          }
          else if(!ARMED){
            lcd.setCursor(5,1); 
            lcd.print("_");
          } 
          if(!bypassZones[3]){
            lcd.setCursor(7,1); 
            lcd.print("4");
          }
         else if(!ARMED){
            lcd.setCursor(7,1); 
            lcd.print("_");
          } 
          if(!bypassZones[4]){
            lcd.setCursor(9,1); 
            lcd.print("5");
          }
          else if(!ARMED){
            lcd.setCursor(9,1); 
            lcd.print("_");
          } 
          if(!bypassZones[5]){
            lcd.setCursor(11,1); 
            lcd.print("6");
          }
          else if(!ARMED){
            lcd.setCursor(11,1); 
            lcd.print("_");
          } 

}
void readZones(){
 
  if(!forsed  || from_dis==1){
    
  if(from_dis==0)zones_status = Serial.read();
  from_dis=0;
 
  zone[7] = bitRead(zones_status, 7); // Bit 7
  zone[6] = bitRead(zones_status, 6); // Bit 6
  zone[5] = bitRead(zones_status, 5); // Bit 5
  zone[4] = bitRead(zones_status, 4); // Bit 4
  zone[3] = bitRead(zones_status, 3); // Bit 3
  zone[2] = bitRead(zones_status, 2); // Bit 2
  zone[1] = bitRead(zones_status, 1); // Bit 1
  zone[0] = bitRead(zones_status, 0); // Bit 0
  }
  forsed=0;
  if(isFire()){//koitao an kapoia pirasfaleia edose alarm[
    FIRE=1;
    firstTimeFire=1;
    for(int i=0;i<6;i++){
      if(typeZones[i] !=7 && tagDisarmed==0)//edo thelo tag an exei ginei alarm
         zone[i]=1;
    }
  }
  if(isTaber() && ALARM==0 && exit_mode==0 && entry_mode==0 && FIRE==0 && ARMED == 0){
       ALARM=1;
       ARMED=1;
       firstTimeAlarm=1;
       if(isSilens()) SILENS=1;
}
  if(ALARM || FIRE){
    for (int i = 0; i < 6; i++) {
       zone[i] = zone[i] & prevZone[i];
       prevZone[i]=zone[i];
      }
  }else if(!ARMED && !ALARM && !FIRE){
    for (int i = 0; i < 6; i++) {
       prevZone[i]=1;
      }
    } else{
      for (int i = 0; i < 6; i++) {
       prevZone[i]=zone[i];
       }
    }
   
}

// system ready or not
void isReady(){
        Serial.flush();
        if(zones_status ==0x3F || zones_status ==0xFF)
           ready=1;
        else  ready=0;
  
       if(!prev==ready)
         lcd.clear();
       prev=ready;
 
  switch (ready) {
      case 1:
          //lcd.clear();
          lcd.setCursor(1,0);  
          lcd.print("SYSTEM READY");
          lcd.setCursor(1,1); 
          lcd.print("ENDER YOUR CODE");
          //ready=2;
       break;
      case 0:
          if(!FIRE) lcd.setCursor(1,0);  
          if(!FIRE) lcd.print("OPEN ZONES :");
          if(!FIRE) printZonesOpen();
       //  ready=2;
        break;
     default:
          break;
    
   }
}
bool compareBoolArray(bool ar1[],bool ar2[]){
  bool returnBool=true;
  int i;
    for(i=0;i<sizeof(ar1);i++){
      if(ar1[i]!=ar2[i])
        returnBool=false;
    }
  return returnBool;
}

//ftiaxno maska analoga me ton typo zonis poy anaziti
//an exo thn zonh 2 san zoni eisodoy kai thelo na ftiaxo maska 
//gia pies einai eisodou tha paro 11111101
byte makeMask(int a,int b,int c){
  int i;
  byte maska;
  for(i=0;i<8;i++){
    if(typeZones[i]==a || typeZones[i]==b ||  typeZones[i]==c || typeZones[i]==10)
      bitClear(maska,i);
    else
      bitSet(maska,i);
  }
  return maska;
}
// is any fire zones open?
bool  isFire(){
   bool a=false;
   for(int i=0;i<6;i++){
      if(!(zones_status&(1<<i))){
        if(typeZones[i]==7){
          a = true;
         }
      }
    }
   return a;
}
// is taber
bool  isTaber(){
   bool a=false;
   for(int i=0;i<6;i++){
      if(!(zones_status&(1<<i))){
        if(typeZones[i]==3 || typeZones[i]==2 ){
          a = true;
         }
      }
    }
   return a;
}
  
bool  isSilens(){
   bool a=false;
   for(int i=0;i<6;i++){
      if(!(zones_status&(1<<i))){
        if(typeZones[i]==2 ){
          a = true;
         }
      }
    }
   return a;
}


