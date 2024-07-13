/*

================================================
SEND TO THE SERIAL PORT STATUS FROM THE 6 ZONES
TO THE OTHER ARDUINO
-------------------------------------------------

=================================================
================================================
SystemState -> GET VALUES FROM OTHER ARDUINO 
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

#define TZ1 1
#define TZ2 4
#define TZ3 6
#define TZ4 2
#define TZ5 3
#define TZ6 7

byte maskFromExitTime=0;
byte maskFromZonesTamber =0;


byte statusZonesAtExit=0xff;
int typeZones[8]={TZ1,TZ2,TZ3,TZ4,TZ5,TZ6,10,10};

byte tagDisarmed=0;//an to systhma den einai disartmed /gia fire
byte firstTimeArmed;
byte number;
byte prevnumber=0x80;
byte bypassZones=0xff;
byte SILENS=0;
int SystemState=0;
int comeFromAlarm=0;
const long interval=200;
unsigned long pm=0;


int sensor1=A0;
int sensor2=A1;
int sensor3=A2;
int sensor4=A3;
int sensor5=A4;
int sensor6=A5;

int SIREN=13;
int SILENS_ALARM =10;
int ARMED=12;
int SIRENFIRE=11;
  

void setup() {
  
pinMode(sensor1,INPUT);
pinMode(sensor2,INPUT);
pinMode(sensor3,INPUT);
pinMode(sensor4,INPUT);
pinMode(sensor5,INPUT);
pinMode(sensor6,INPUT);
  
pinMode(SIREN,OUTPUT); 
pinMode(SIRENFIRE,OUTPUT);
pinMode(ARMED,OUTPUT);
pinMode(SILENS_ALARM ,OUTPUT); 
pinMode(6,OUTPUT);


//etoimazo maska gia exit time
maskFromExitTime =  makeMask(1,4,5);
maskFromZonesTamber = makeMask(3,8,8);

  
  // Begin the Serial at 9600 Baud 
  Serial.begin(9600);
  Serial.flush();
  delay(2000);
}

void loop() {
//--------RECEIVING DATA-------------------//
  if(Serial.available() != 0 && SystemState != 5){
   byte a = Serial.read();
   SystemState=char(a)-'0';
  }
  
//--------SYSTEM DISARMED (START) -------//
if(SystemState==0){
   digitalWrite(ARMED,LOW);
   digitalWrite(SIREN,LOW);
   digitalWrite(SIRENFIRE,LOW);
   digitalWrite(SILENS_ALARM,LOW);
   SILENS=0;
   tagDisarmed=0;
   byte tempStatusZones = refreshZones();
   for(int i=0;i<6;i++){
      if(!(tempStatusZones&(1<<i))){
        if(typeZones[i]==7){
        SystemState=6;
         }
        if((typeZones[i] == 3 || typeZones[i] == 2)  && SystemState !=6){
          SystemState=3;
          if(typeZones[i]==2) SILENS=1;
        }
      }
    }
  //Check if taber zone is open
  
}
//------- SYSTEM DIASARMED (END) --------//
  
  
//---------SYSTEM TIME TO EXIT (START)---------//

if(SystemState==1){
  byte tempStatusZones;
   while(1){
     tempStatusZones=refreshZones();
   //  for(int i=0;i<8;i++){
         //zone[i]=zone[i] && bitRead(tempStatusZones, i);
   //  }
     statusZonesAtExit = tempStatusZones & maskFromExitTime;
     if(maskFromExitTime!=statusZonesAtExit){
         SystemState=3;
         break;
     }
     if(Serial.available()!=0){
       byte a = Serial.read();
        SystemState=char(a)-'0';
       // SystemState=Serial.parseInt();
       // delay(1000);
        if(SystemState==5){//an oplizoyme me stay apoononoyma kai meta oplizoyme
          while(1){
             if(Serial.available() != 0){
                bypassZones = Serial.read();
                SystemState=2;
                break;
           }
          }
         }
          
        if(SystemState==2)
          firstTimeArmed=1;
		break;
      }
   
    }//endwhile 
 
   prevnumber=number-1;
}
//---------SYSTEM TIME TO EXIT (END)---------//  
  
//---------SYSTEM ARMED MODE (START)---------//
if(SystemState==2){
  if(firstTimeArmed)refreshZones();
  firstTimeArmed=0;
  digitalWrite(ARMED,HIGH);
  byte tempStatusZones;
  //byte currentState;
  while(1){
    tempStatusZones = refreshZones();
    for(int i=0;i<6;i++){
      if(!(tempStatusZones&(1<<i))){
        if(typeZones[i]==1){
           if(SystemState!=3){
              SystemState=4;
              break;
            }
         }
        else if(typeZones[i]==7){
            SystemState=6;
            break;
        }
         else{ 
           SystemState=3;
           break;
             }
      }
    }//end for
    if(SystemState==4 || SystemState ==3 || SystemState == 6){
      tagDisarmed=1;
      break;
    }
    if(Serial.available() != 0){
       SystemState=Serial.parseInt();
       if(SystemState==0)
          bypassZones=0xff;//clear bypass zones
       break;
    } 
  
  }
}
//---------SYSTEM ARMED MODE (END)-----------//
  
//---------SYSTEM ALARM MODE (START)---------//
if(SystemState==3){
  //digitalWrite(ARMED,HIGH);
  digitalWrite(SIREN,LOW);
  digitalWrite(SILENS_ALARM,HIGH);
  //Serial.print(1); 
 // byte currentState;
  byte tempStatusZones;
  while(1){
    tempStatusZones = refreshZones();
    for(int i=0; i<6 ; i++){
      if(!(tempStatusZones&(1<<i))){
        
        if(typeZones[i]!=2 && typeZones[i]!=7 && SILENS==0){
           digitalWrite(SIREN,HIGH);
           digitalWrite(SILENS_ALARM,LOW);
        }
        if(typeZones[i]==7){
           SystemState = 6;
           break;
        }
      }
    }
    if(SystemState == 6) break;
    if(Serial.available() != 0)
       SystemState=Serial.parseInt();
    if(SystemState==0){
      
         comeFromAlarm=1;
         bypassZones=0xff;//clear bypass zones
         break;
    }
    refreshZones();
   }
}
//---------SYSTEM ALARM MODE (END)-----------//
  
//---------SYSTEM ENTRY MODE (START)-----------// 
  if(SystemState==4){
    digitalWrite(6,HIGH);//on led entry time
    byte tempStatusZones;
    while(1){
    tempStatusZones=refreshZones();
   //  for(int i=0;i<8;i++){
         //zone[i]=zone[i] && bitRead(tempStatusZones, i);
   //  }
     statusZonesAtExit = tempStatusZones & maskFromExitTime;
     if(maskFromExitTime!=statusZonesAtExit){
         SystemState=3;
         break;
     }
     if(Serial.available() != 0){
       SystemState=Serial.parseInt();
       if(SystemState==0)
          bypassZones=0xff;
       break;
     }
    } 
     digitalWrite(6,LOW);
  }
//---------SYSTEM ENTRY MODE (END)-----------//  
//---------SYSTEM READ BYPASS ZONES (START)--//
  if(SystemState==5){
    //read bypass zones from keyboard
    while(1){
      if(Serial.available() != 0){
        bypassZones = Serial.read();
        SystemState=0;
        break;
      }
    }
  }
//---------SYSTEM READ BYPASS ZONES (START)--//
  
//---------SYSTEM FIRE MODE (START) ---------//
  if(SystemState==6){
    digitalWrite(SIRENFIRE,HIGH);
    while(1){
    refreshZones();
    //kata to fire koitao an exo kai alarm alla mono 
    //otan exo oplisei
    for(int i=0;i<6;i++){
        if(!(number &(1<<i)) && typeZones[i]!=7 && tagDisarmed)
           digitalWrite(SIREN,HIGH);
        
      }
       
    if(Serial.available() != 0)
       SystemState=Serial.parseInt();
    if(SystemState==0){
         comeFromAlarm=1;
         bypassZones=0xff;//clear bypass zones
         break;
    }
  }
 }
//---------SYSTEM FIRE MODE (END) ---------//  
}

//-------------FUNCTIONS-----------------//
//return if zone is bypass
bool checkBypassZones(int bit){
   bool state =  bypassZones & (0x01<<bit);
   return !state;
 }
//chech  sensors open or close
int checkStateSensor(int sensorNo){
    if(!(analogRead(sensorNo) < 700 && analogRead(sensorNo)> 650))
        return 0;//checkByType(sensorNo);    
     else 
        return 1;
}
//////////////////////////////////
int checkByType(int sensorNo){
   //oplismeno
    if(SystemState==2)      
     
   //afoplismeno
   if(SystemState==0)
       return 1;
   //einai eisodos?
   //bypass me stay?
   //siopili?
}
////////////////////////////////////////
byte refreshZones(){

     unsigned long cm = millis();
     if(cm - pm >= interval || comeFromAlarm){
     pm=cm;
 
  
     bitWrite(number, 7, 0); // Bit 7
     bitWrite(number, 6, 0); // Bit 6
     bitWrite(number, 5, checkStateSensor(sensor6) || checkBypassZones(5)|| whenFireMaskZone(5)); // Bit 5
     bitWrite(number, 4, checkStateSensor(sensor5) || checkBypassZones(4)|| whenFireMaskZone(4)); // Bit 4
     bitWrite(number, 3, checkStateSensor(sensor4) || checkBypassZones(3)|| whenFireMaskZone(3)); // Bit 3
     bitWrite(number, 2, checkStateSensor(sensor3) || checkBypassZones(2)|| whenFireMaskZone(2)); // Bit 2
     bitWrite(number, 1, checkStateSensor(sensor2) || checkBypassZones(1)|| whenFireMaskZone(1)); // Bit 1
     bitWrite(number, 0, checkStateSensor(sensor1) || checkBypassZones(0)|| whenFireMaskZone(0)); // Bit 0
     
   
     if(number!= prevnumber || comeFromAlarm){
         comeFromAlarm=0;
         Serial.write(number);
       }
     prevnumber = number ;
       
     return number;
    }
   return number;
}
              
//an exo thn zonh 2 san zoni eisodoy kai thelo na ftiaxo maska 
//gia pies einai eisodou tha paro 11111101
byte makeMask(int a,int b,int c){
  int i;
  byte maska;
  for(i=0;i<8;i++){
    if(typeZones[i]==a || typeZones[i]==b || typeZones[i]==c  || typeZones[i]==10)
      bitClear(maska,i);
    else
      bitSet(maska,i);
  }
  return maska;
}




//otan eimai se alarm apo p[irasfaeia apomonono oti den einai zoni pyrasfaleia
int whenFireMaskZone(int noZone){
    if(typeZones[noZone]!=7 && SystemState==6 && !tagDisarmed)
       return 1;
    else
      return 0;
  }
