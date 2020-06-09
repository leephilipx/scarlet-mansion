## Available character emotions:
| Character | Emotions |
| :-------- | :------- |
| ```Masao``` | ```angry```, ```neutral```, ```sad```, ```shocked```, ```smiling``` |
| ```Rinni``` | ```angry```, ```happy```, ```sad```, ```shocked```, ```smiling``` |
| ```Tatsumi``` | ```angry```, ```happy```, ```neutral```, ```sad```, ```shocked```, ```smiling``` |
| ```Yuna``` | ```angry```, ```sad```, ```shocked```, ```smiling``` |

Supplementary characters: ```You```, ```emptytextobject```
| Additional charater: ```Detective``` , ```Red Stone``` |
---

## Introduction Script

> Note: Double space at the end of a line for line break

### Information
{size=80}You are a {color=#ffff2d}detective{/color} in this game.{/size}{w=0.8}\n\n\n{i}{color=#fff2cf}Look out for {/color}{color=#ff4545}important{/color}{color=#fff2cf} clues!{/color}{/i}  

### Background 1: Outside Mansion
```You``` Wow, Tatsumi's home sure is big!  
```You``` The auction is happening today, I wonder, do those cars belong to the other bidders? (dif)    
```You``` Hmm, they look wealthy ... I wonder who Tatsumi invited? (dif)  

### Flashback
5 days ago ...{w=0.5}  

### Background 2: Flashback to Detective's Home 
```emptytextobject``` {audio=Phone Ringing}Ring ring ...{w=0.8} (Call from Tatsumi){w=1.8}  
```Tatsumi.smiling``` {audio=Phone Answer}{w=0.5}Hey, old friend!  
```You``` Hey Tatsumi! (dif)   
```You``` It's been a while, how are you doing?  
```Tatsumi.sad``` Yeah, I guess so. I have been so busy with my invention... (dif)   
```Tatsumi.happy``` Speaking of the invention, I just completed it! (dif)   
```Tatsumi.smiling``` I will be auctioning it at my house in Kyoto this Saturday. Will you be available then? (dif)    
```You``` Congratulations!  
```You``` Why do you need me there though?  
```Tatsumi.neutral``` Listen ...{w=0.5} The bidders I've invited are influential people.  
```Tatsumi.neutral``` I need you there in case something unexpected happens.  
```You``` Alright, I understand. I'll go undercover at your event.  
```Tatsumi.neutral``` Great! I'll send you the details.  
```Tatsumi.happy``` Thanks a lot pal!    
```You``` You're welcome, see you there.{w=0.8}{audio=Phone Answer} (dif)   

### Background 3: Outside Mansion
```Rinni.smiling``` {audio=Car Door}{w=2.5}Hi, are you here for the auction too? I'm Rinni, nice to meet you.  
```You``` Hi Rinni, yeah I am, nice to meet you too. (dif)  
```Rinni.smiling``` Well, this is a rather exquisite auction here. You must be an important person.  
```You``` Yeah, I guess so.  
```Rinni.smiling``` I see. Well I just had a long flight, from Paris.  
```Rinni.smiling``` I do believe the other bidders are from various countries as well. (dif)   
```Tatsumi.happy``` {audio=Door Open}{i}* interrupts *{/i}{w=1.5}  Welcome everyone! Please come in!  
```Tatsumi.smiling``` The other guests have just arrived too. Please come in, make yourselves comfortable. (dif)  

### Background 4: Inside Mansion
```Tatsumi.smiling``` Over here, we have Masao from Toronto.  (dif)
```Masao.smiling```  {i}* nods *{/i} Hey.  
```Tatsumi.smiling``` And Yuna from Sydney.  (dif)
```Yuna.smiling```  Hello. It's been a long flight huh? You guys look exhausted.  
```Rinni.sad``` Yeah, it was quite a long flight. Even in First Class.  
```You``` I'm from Tokyo, nice to meet you guys.  
```Tatsumi.smiling``` You two can unpack upstairs and freshen up.  
```Tatsumi.happy``` Our auction will begin in an hour!  

(put a fade here? ) (dif)  

### Background 5: Auction Starts
```Tatsumi.smiling``` Good evening everyone I want to first start by saying thanks you all for coming to today's auction. (dif)  
```Tatsumi.happy``` I hope you guys will be able to make good use of my invention! (dif)  
```Tatsumi.neutral``` Now lets begin ...{w=1}  
```Tatsumi.smiling``` Yes, Yuna?  
```Yuna.smiling``` 100k!  
```Rinni.smiling``` Make that double!  
```Masao.neutral``` ...  

### Background 6: Blackout
```Tatsumi.shocked``` Oh! Whats going on?!  
```Tatsumi.shocked``` A blackout??  

### Background 7: Auction Disrupted
```Tatsumi.shocked``` The safe ... its open!{w=0.5} My invention is gone!  
```Tatsumi.angry``` Who stole it?!{w=1} I have a security system to lock down the house down for emergencies like this! (dif)    
```Tatsumi.angry``` I will find who took it. (dif)  
```Masao.angry``` It's gonna take forever to find the culprit.  
```Masao.angry``` I think I'll head back to my room first!  
```Yuna.angry``` Me too!  
```Rinni.angry``` Well, there's nothing else to do now.  
```Rinni.angry``` I'll just look around ... This place is huge.  

### Canvas - Instructions
- Try to finish the game within 30 minutes
- WASD to move around
- Press [P] to Pause
- Press [Q] to bring up your inventory
- Press [E] to interact with objects (magnifying glass will be shown)
- Press [E] to interact with characters when their nametag turn yellow
---

## Ending 1 - Yuna accused  

### Background 1: The inside of the house image (Fireplace one)  
```Tatsumi.shocked``` You think the person who stole my invention is ...{w=0.5} Yuna?  
```Tatsumi.sad``` But why do you think she stole it?   
```You``` There is a high chance she was worried Rinni might out bid her.   
```Tatsumi.sad``` Yeah that could be why... {w=0.5} What do you think she wanted it for?   
```You``` No clue, but lets call the police they should be able to recover your invention from Yuna.   

(put the fade in and out animation in between?)   

### Background 2: The inside of the house image (Maybe a siren sound?)   
```Yuna.shocked``` Whats going on?    
```Rinni.shocked``` Why are there police outside the mansion?   
```Masao.neutral``` ... {w=0.5} Are they here to let us out?    
```Tatsumi.sad``` We have called the police. {w=0.5} We know who stole the invention.  
```Detective``` Miss Yuna, You are under arrest. We have reason to believe you are resposible for the dissaperence of Sir Tatsumi invention.  
```Yuna.shocked``` Who me???  
```Yuna.angry``` I want to know what proof you have against me.   
```Detective``` You have the right to remain silent. My fellow detective here will let you know all the evidence found.  
```You``` * Nods *   

(put the fade in and out animation in between?)   
### Background 3: Outside with cop car (ending-background-2)   
```Detective``` Miss Yuna please get inside the police car.    
```Yuna.angry``` Hmphhh.   
(door shut sound?)  
```Detective``` Sir Tatsumi we found your invention hidden in her room as we were searching it.     
```Tatsumi.happy``` Oh thank you!   
```You``` So what was your invention?   
```Tatsumi.neutral``` Oh I never did tell you did I?   
```Tatsumi.neutral``` I was experimenting the other day with this stone.     
```Tatsumi.shocked``` And I found out that this stone might have the power to transport people to the digital world.  
```Tatsumi.neutral``` I call this the Red Stone.   
```Yuna.angry``` Hi yahhhh. (Glass breaking sound or door breaking sound?)   
```Detective``` What was that sound?  
```Yuna.sad``` My plan to transport everyone to my new program was foiled.     
```Yuna.smiling``` * Grabs Red Stone from Tatsumi * But I can still transport 2 people.     
```Yuna.smiling``` Oh detective, you are coming with me.  

(maybe in between these 2 no need to make them click?)  
(Screen slowly become white then fade to black)  

### Background 4: (ehhh something like the "you are a detctive scene")  
- (To be continued in the minecraft world...)  



## Ending 2 - Wrong ending  

### Background 1: The inside of the house image (Fireplace one)  
```Tatsumi.shocked``` You think the person who stole my invention is ... ?{w=0.5}    
```You``` Yes I belive so.   
```Tatsumi.sad``` I see ok I will call the local police.    

(put the fade in and out animation in between?)   

### Background 2: The inside of the house image (Maybe a siren sound?)   
```Yuna.shocked``` Whats going on?    
```Rinni.shocked``` Why are there police outside the mansion?   
```Masao.neutral``` ... {w=0.5} Are they here to let us out?    
```Tatsumi.sad``` We have called the police. {w=0.5} We know who stole the invention.  
```Detective``` Hello, we received a report saying that Sir Tatsumi Invention has been stolen... and that one of you has it...    
```Rinni.shocked``` What do you mean detective?   
```Yuna.shocked``` Are you sure it didn't just decided to take a vacation?  
```Masao.neutral``` ...   
```Detective``` My fellow detective here has looked at all the evidence.  
```You``` * Nods *  
```Detective``` I am sure invention is with ...  
```Yuna.smiling``` Do you mean this invention? The Red stone?     
```Rinni.shocked``` Whaaa  
```Masao.shocked``` Huhhhh?  
```Tatsumi.shocked``` The Red Stone.  
```Yuna.smiling``` Oh my, you all didn't suspect me at all. Tee-hee!  
```Yuna.smiling``` I heard the Red Stone can transport people to the digital world.  
```Yuna.smiling``` Now I will use its power to transport the whole world!  
```Red Stone``` * Beep * Beginning transport in... 3... 2...  
```You``` * Jumps in front of the Red Stone *  
```Yuna.shocked``` Huh?  
```Red Stone``` 1... Transporting 2 people...  

(maybe in between these 2 no need to make them click?)   
(Screen slowly become white then fade to black)  

### Background 4: (ehhh something like the "you are a detctive scene")  
- (To be continued in the minecraft world...)  

## Thank you guys 😊
