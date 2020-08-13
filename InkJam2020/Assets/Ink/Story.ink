EXTERNAL SetCharacter(active)
EXTERNAL ChangeScenery(index)
EXTERNAL CalculateEndering()
EXTERNAL ActivatePoltergeist(temp)
EXTERNAL SetTime(index)
EXTERNAL ProgressDay(num)

You've been hired to test out an experimental app called “Witch Helpers” before its release. The purpose of this app is to allow the user to summon a witch of their choosing in their time of need. 

You've been given a trial version to test out for a handful of days, and then give the developers feedback. You can already tell that the app has some issues, as it’s not very clear what kind of tasks the witches are up to. It seems you'll have to figure that out yourself. 

    {SetTime(1)}
    {ProgressDay(1)}
You've been at work all day, and by the time you arrive home you realize that you feel too tired to cook food. You <i>could</i> go out and pick something up, though you can't help but wonder if giving one of the witches a call wouldn't be a better option... 
    {ChangeScenery(9)}
You unlock your phone. 
    {ChangeScenery(0)}

*You choose to call Diana.
{SetCharacter(true)}
    Diana arrives with a flourish of her dress. "I'm assuming you're the only who called me," She drawls. Her cat lets out a mewl of acknowledgement. 
    You nod your head yes. "Well I hope you have a task worthy of my caliber... I wouldn't want you wasting my time."
    **"How good are your cooking skills?"
        "My... cooking? What about it?"
    **"I'm really hungry."
        "So? What of it?"
    --"I called you because I'm hungry and I was hoping you'd cook."
   Her face is calm at first. Then she flushes an angry scarlet. 
   "How dare you waste my time with such trifles? Are you trying to make a mockery of me?"
   You raise your hands and attempt to explain, but before you know it she's gone, disappearing as suddenly as she arrived.
   {SetCharacter(false)}
    You feel a little off put by her reaction. 
           {ChangeScenery(2)}
    Perhaps you should've called another witch. 
    You end the night by ordering takeout. 
    
*You choose to call Baba Yaga.
{SetCharacter(true)}
    Baga yaga appears in your apartment. She walks over to you, squinting her eyes.
    "Hah? Who are you?" she asks, promptly sticking a finger in her ear. 
    **"How good are your cooking skills?"
        She puffs out her chest, much like a peacock. "Quite good, if I do say so myself."
    **"I'm really hungry."
        She becomes thoughtful. "So am I," she admits. "Say, how good do you taste?"
    --"What? No! I called you because I'm hungry and I was hoping you'd cook."
    She squints again. "Hmmm..."
    Before you can protest she hobbles over to your kitchen, and begins rummaging through all your wares. 
    You contemplate interrupting her, but curiosity gets the best of you. You sit down on your sofa and wait patiently as she cooks. 
    When she finally emerges, you see that she has a pot of steaming hot soup in her hands. She puts it down on a nearby table. 
     {ChangeScenery(3)}
    {SetCharacter(false)}
    "That looks fantastic!" You say, standing up. 
    She gave you a mischeavous smile with a twinkle in her eyes. "I've always been a very good cook." She says. 
            {SetCharacter(true)}
    Before you can compliment her further, she disappears.
            {SetCharacter(false)}
    You eagerly dig in to your food, then fall asleep with a full belly. 

*You choose to call Gryla.
{SetCharacter(true)}
    With a huff of smoke Gryla appears in your apartment.
    As she takes in your living room she wrinkles her nose in disgust.
    "Such meagre accomodations..." she says, strolling over to one of your chairs and making herself comfortable.
    She brings her nails up to her face and squints as she examines them. "Speak now, child. Why have you summoned me?"
    **"How good are your cooking skills?"
        She stares you in the eyes. "I beg your pardon?"
    **"I'm really hungry."
        She says nothing. She fixes you with a steely gaze so severe that you find yourself stumbling your next words. 
    --"I... erm... called you because I'm hungry and I was hoping you'd cook."
    Jutting her nose in the air, she promptly stands up. 
    "I don't know who you think I am, child, but I am not your mother," she says.
    "I <i>am</i> the mother of many other children, but you are no wayward child."
    She takes a step closer towards you. "Far from it. You are quite the unruly adult. The least you can do is cook your own meals, but apparently that's too much to ask for."
    You duck your head at her admonishments. When you look up you realize that she left without saying a goodbye.
    {SetCharacter(false)}
    You feel guilty for calling her. 
           {ChangeScenery(2)}
    Perhaps you should've called another witch. 
    You end the night by ordering takeout. 
    You go to sleep still mulling over her words.
    
*You choose to call Pesta.
{SetCharacter(true)}
    As soon as Pesta arrives she looks around your apartment with a keen curiosity.
    "I don't meet mortals too often," she admits, giving you a shy smile. "Why have you summoned me?" 
    **"How good are your cooking skills?"
        She looks startled. "Oh! My cooking skills? Um... I don't know. I don't cook often."
    **"I'm really hungry."
        She frowns. "Oh dear, you are? Do you happen to have any food...?"
    --"I called you because I'm hungry and I was hoping you'd cook."
    That gives her pause. For a second she looks like she is going to say no, then she hangs her head in defeat.
    "I... I'll try my best," she says. 
    You lead her to your tiny kitchen. She squeezes in and stares at your cooking utensils.
    "I wonder if this is anything like brewing potions."
    The night steadily gets worse from there. Whenever Pesta tries touching an ingredient it dissolves in her hands.
    Eventually the floor is littering with the rotting leftovers of vegetables and meat. 
    Pesta is sobbing hysterically. "I'm sorry. I'm so sorry. I don't know how to make it stop."
    You quickly intervene and soothe her, assuring her that it's okay.  
    Then you send her off. She looks at you with wide, teary eyes right before she leaves. "I'm sorry," she says one last time, sniffling. 
    {SetCharacter(false)}
    Your stomach growls.     {ChangeScenery(2)}
You order takeout, mulling over your interactions with her.
Perhaps you should've called another witch. 
You go to sleep feeling dissatisfied. 
     -The next day. {ChangeScenery(8)}

    {SetTime(0)}
        {ProgressDay(2)}
You have some time before work, so you decide to go on a refreshing morning walk through a nearby park.
    {ChangeScenery(10)}
There are several missing cat signs that catch your eye.
    {ChangeScenery(6)}
You have a soft spot for cats, and feel a pang at the thought of these animals wandering sad and alone. 
This may be a good opportunity to summon a witch. Perhaps one of them would be able to help find the cats...?

*You choose to call Diana.
{SetCharacter(true)}
    {ChangeScenery(10)}
    Diana strolls up to you impatiently. "What do you want." she asks. Her cat flicks its tail.
    **Do you like cats?
        She cocks an eyebrow. "What do you think?" Her cat mews in agreement. 
    **A lot of cats have been going missing. 
        Her eyes glaze over. She look sadly over at some of the missing posters. "Yes, it seems like they have."
    --"I called you here because I was hoping you could help find the missing cats, and return them to their owner."
    She looks stunned. Then she fidgets. 
    "Well, if the purpose is to find lost cats, I suppose I could lend my time," she mumbles.
    She disappears without another word. 
    {SetCharacter(false)}
    You wait a couple of minutes to see if she would return, and then go about your day, thoroughly confused.
    Later that night you receive text messages on your phone. 
        {ChangeScenery(9)}
    It seems that she not only helped the one cat, she went around and found all the other cats as well. 
    You go to bed with a smile on your face. 
    
*You choose to call Baba Yaga.
    {ChangeScenery(10)}
    At first there is no reaction. You wonder if the app glitched. 
    Then the ground begins shaking.
    In the distance you see a house running lopsidedly towards you. A house with chicken legs.
    {SetCharacter(true)}
    Comandeering the house is none other than Baba Yaga. "I'm taking it out for a walk," she says, in response to your quizzical look."
    **Do you like cats?
        She taps her chin and hums. "They're too chewy," she says after thinking really hard.
    **A lot of cats have been going missing. 
        She grunts. "Someone's probably eating them."
        You choose to ignore her disturbing words.
    --"I called you here because I was hoping you could help find the missing cats, and return them to their owner."
    The witch rolls her shoulders, then shrugs. "Okay."
    {SetCharacter(false)}
    She gives a quick glance at the posters, and then climbs back into her cabin. The house rears all the way up.
    At first it's still. Then with no warning it begins running through the park. 
    
    You can hear the witch hollering the names of the cats, and passerby screaming as they try to avoid the onslaught of chicken legs.
    Grimacing, your turn on your heel make your way home. In hindsight, calling her was a bad idea. 


*You choose to call Gryla.
{SetCharacter(true)}
    {ChangeScenery(10)}

    The imposing woman bears down on you the second she arrives. 
    "What do you want?" she asks, scowling. 
    **Do you like cats?
        Her face flickers with confusion. "Cats? I feel nothing one way or another."
    **A lot of cats have been going missing. 
        "Oh. I see."
    --"I called you here because I was hoping you could help find the missing cats, and return them to their owner."
    She appears deep in thought. "I appreciate you wanting to help these animals," she says at last.
    "But it's not my responsibility, nor do I know the first thing about finding these creatures." 
    She grabs one of the signs and examines it closely.
    "I'll tell my children to keep an eye out," she says, putting the sign back.
    She leaves without another word. After a while you also head back. 
    
    {SetCharacter(false)}
    You don't receive any other information from her.
    You assume that she isn't able to find the cats. 
    
*You choose to call Pesta.
{SetCharacter(true)}
    {ChangeScenery(10)}
    Pesta appears right next to you, making you jump. The grass at her feet wither.
    "Hello!" she hums. 
    **Do you like cats?
        She cocks her head. "I suppose. Could never get close to them though." She shifts her feet. 
    **A lot of cats have been going missing. 
        Her eyes become wide. "Oh no, that's horrible!"
    --"I called you here because I was hoping you could help find the missing cats, and return them to their owner."
        She opens and closes her mouth several times, then grimances. 
        "I'm sorry, I don't think that's a good idea. I think I'd melt the cats." 
        The thought makes you shudder. You give her a sympathetic nod, and thank her for hearing your request.
        With a <i>pop</i> she's gone, leaving a trail of smoldering grass in her wake.
                {SetCharacter(false)}
        You examine the missing cat posters again. The more you think about it, the more you doubt any of the witches could really be of any help. 
        You leave the park, deep in thought. 

-The next day. {ChangeScenery(8)}


    {SetTime(0)}
        {ProgressDay(3)}
Today is your day off. You eagerly wake up and head over to your balcony garden to check out your plants.
To your horror, you see that the entire thing is overgrown.
{ChangeScenery(11)}
It looks like a jungle took root and grew overnight. 
You know right away that this isn't a situation you can handle. You have to call a witch. 

*You choose to call Diana.
{SetCharacter(true)}
    Diana appears next to you. She gives you a suspicious look, then at the sight of your plants her eyes widen.
    "Your garden is cursed! Foolish girl, who have you angered?"
    **"I don't know who or what caused this."
        She tuts under her breath. "That won't make this any easier."
    **"Is this a curse? No one has any reason to curse me."
        She gives a snort.
    --"Do you think you can fix this?"
    Diana massages her temples. "Ugh. No, I don't think I can. I'll give it a try anyways."
    The witch begins her spellwork. One by one cats appear in your apartment with a <i>pop</i>. 
    They ignore you and make a beeline for the witch, forming a circle around her and mewling in tune with her chanting. 
    When she is finished she takes a breath. She looks at your garden--still very overgrown--and then at you with a frustrated gleam in her eyes. 
    "It didn't work," she says.
    You feel tired. "That's ok," you say weakly. It's getting late, and you want to be left alone. 
    She doesn't say anything further, just snaps her finger and then she, along with the cats, are gone.
    {SetCharacter(false)}
    You walk over to your plants and grimace at the sight. Maybe someone else would've been able to help.
    You put it out of mind for now and go to bed. 
    
*You choose to call Baba Yaga.
{SetCharacter(true)}
    The old witch looks unhappy to be in the apartment. "Whadya want?" she asks, scratching her back.
    You gesture towards your balcony. She hobbles up to it, and hums as she stares at it with squinted eyes. 
     **"I don't know who or what caused this."
        "That's makes two of us."
    **"Is this a curse? No one has any reason to curse me."
        She scratches her chin. "They don't need one! Some like cursing for fun." She cackles, and you have no doubt that she is one of those people. 
    --"Do you think you can fix this?"
    The witch rubs her hands together. "Maybe. Dunno."
    She begins her spell work. She waves her hands wildly in the air while muttering under her breath. 
    Sometimes she leaps across the room, making wild gestures to seemingly no one. 
    Intrigued by the sight, you sit down on a couch and watch her work. 
    When she finally stops, she is panting. Shaking her head, she says, "Didn't work."
    Without stating anything further, she disappears.
    {SetCharacter(false)}
    You're still gaping at the spot where she just was. Then you curse your luck. Of course she doesn't get the job done. 
    You place a hand on your forehead. A migraine is coming. Deciding to deal with this problem later, you head off to bed. 


*You choose to call Gryla.
{SetCharacter(true)}
    The witch shows up disgruntled. "There better be a reason for this disturbance, child."
    You explain your situation as you take her over to your balcony. She eyes the plants with distaste.
     **"I don't know who or what caused this."
        She sighs. "This would have been an easier problem to solve if you did."
    **"Is this a curse? No one has any reason to curse me."
        She cocks an eyebrow. "This doesn't look like something caused out of no reason. But, perhaps, if a stray spell went awry..."
    --"Do you think you can fix this?
        She purses her lips. "I suppose I can try."
        She puts two fingers in her mouth and whistles. You hear the sound of laughter, following by objects in your apartment getting knocked over.
        Then you see the vines thrashing about.
        Gryla explains to you that her children are trying to rip apart the vines. But to no avail--everytime one gets ripped off, another grows back in its place. 
        Finally she turns to you and says, "I'm sorry, I don't think it can be done."
        You give a curt nod, and say your goodbyes as she and her multitudes of children leave.       
        {SetCharacter(false)}
        Placing your hands on your hips, you sigh and stare at your once beloved garden.
        You decide to sleep away your worries. 
        
        
*You choose to call Pesta.
{SetCharacter(true)}
    Pesta arrives right away, her eyes wide in surprise. "What's wrong??" She asks.
    You take her to your balcony. She "ooohed" at the sight of the plants.
     **"I don't know who or what caused this."
        "Sometimes no one causes things like this," she says, examining the plants further. "Sometimes it just happens"
    **"Is this a curse? No one has any reason to curse me."
        Pesta gives a small smile. "I don't see why anyone would want to curse you."
    --"Do you think you can fix this?"
         She hesitates. "I suppose I can try..."
        She touches all the plants one by one. They slowly decay, and then deteriorate.
        It takes a while, but eventually she gets through all of them. 
        Pesta beams at her handiwork. "There!" she says.
        All your plants are gone, reduced to heaps of dust. But you feel happy that your balcony is cleared. You return her smile. 
        Pesta is giddy with joy. "I'm glad I was useful!" She says her goodbyes, and leaves.
        {SetCharacter(false)}
        It's well into the day, and you suddenly feel exhausted. You return to you room to sleep. 

-The next night. {ChangeScenery(9)}

    {SetTime(1)}
        {ProgressDay(4)}

You awake to the sound of a large bang. Grumbling, you push yourself out of your bed and head over to your living room.
In shock, you realize that everything has been flung over. Your furniture is floating in the air, poised to crash any minute.
{ActivatePoltergeist(true)}
This is an emergency. You quickly whip out your phone, and get ready to call. 

*You choose to call Diana.
{SetCharacter(true)}
    Diana arrives, looking annoyed. Her cat is deep asleep on her shoulders.
    "What is the meaning of thi--" she freezes when she notices the flying objects.
     **"What's going on?!"
        Diana sucks in her breath. "Poltergeists."
    **"Do you know how to stop this?"
        Diana stutters. "I... I'm not sure."
    --"Please help me!"
    "Okay, okay, I'll try," she says. 
    She begins her spellwork. You can't tell what she's doing, but it doesn't seem to lessen the onslaught of the poltergeist. 
    Eventually it stops when morning strikes. She looks at you, wide-eyed
    {ActivatePoltergeist(false)}
    "I'm sorry, I did all I could."
    You thank her for her time, and say your goodbyes.
    {SetCharacter(false)}
    You look around your mess of an apartment in misery. 

    
*You choose to call Baba Yaga.
{SetCharacter(true)}
    When the old hag finally arrives, it's almost dawn.
    She looks annoyed to be here. "Whadya want?" she asks, shuffling her feet. 
    Then she takes notice of the flying furniture. "Oh. That's what. 
  **"What's going on?!"
        "I got no clue."
    **"Do you know how to stop this?"
        "How should I know?"
    --"Please help me!"
    She scratches her chin. "You know what. I'll make some food. That usually helps."
    You assume she means food for you, but to your surprise she disappears.
    {SetCharacter(false)}
    You let out a grunt of frustration and make your way to your room, barring the door shut and hiding under the blanket. 
    Eventually the sound of the poltergeist wreaking havoc dies down, and you're able to get a small burst of sleep. 
    {ActivatePoltergeist(false)}

*You choose to call Gryla.
{SetCharacter(true)}
    Gryla arrives and looks around your apartment suspiciously. "What is..." she pauses at the sight of the flying objects. "Oh."
    **"What's going on?!"
        "It's a poltergeist, child."
    **"Do you know how to stop this?"
        She gives a grim smile. "Luckily for you, I do."
    --"Please help me!"
    Gryla tells you to return to your room. 
    As you do so, you hear her talking with the poltergeist in question--they talk well past the point you fell asleep.
    {ActivatePoltergeist(false)}
    When you wake up and return to your living room you see that everything has been returned to normal. 
    If it hadn't been for Gryla's text message saying that she took care of the problem, you would've thought it was a dream.
    
*You choose to call Pesta.
    Pesta arrives and nervously looks around your apartment, gasping at the sight of the mess.
    **"What's going on?!"
        "A malignant spirit!" She says excitedly. "Oh, but I don't know what kind."
    **"Do you know how to stop this?"
        "I... I don't think so."
    --"Please help me!"
    "Well, I'll try..." She says. 
    She begins by trying to reason with the spirit. She melts some of the objects it tries to throw in an effort to lessen some of the damage.
    Nothing is working. It's still breaking things in your apartment, until finally morning struck, and it is gone. 
        {ActivatePoltergeist(false)}
    Pesta keeps apologizing. "I'm so sorry, I should've been better, I should've..."
    You interrupt her apology and say that it's okay. She looks at you tearfully and nods.
    The two of you say your goodbyes.
    {SetCharacter(false)}
    You're exhausted. Even though it's morning you walk back to your bedroom, and crawl into bed. 

-The next day. {ChangeScenery(8)}
    {ProgressDay(5)}
    {SetTime(0)}
    ->BestEnding

==BestEnding==
You tell the company your complaints with the app. Primarily that it wasn't clear at all what the witches were willing to do.

Turns out that among the testers you were one of the lucky ones. Many others have met a harsher fate by crossing the line with these witches. The company decides not to realize the app after all. In hindsight, it really doesn't seem like a good idea. 
->DONE 

==WorstEnding==
You have a plethora of angry complaints that you hand over to the company.

You tell them that your appartment is in ruins, that you've had a very stressful handful of days, and that calling the witches at times was more trouble than it was worth!

Not to mention that you couldn't tell what they were willing to do half the time.

The company apologizes profusely and tells you that they were planning on scrapping the app all together. Turns out you weren't the only one with a negative experience.
->DONE

==MixedEnding==
You aren't sure how to feel about the app. You tell the company as much when you report to them, and say that as much as it could have its uses, it can also backfire if you don't pick correctly. 

The company lets you know that they were thinking of scrapping the app altogether due to numerous complaints from other testers. You understand the frustrations completely.
->DONE

-->END