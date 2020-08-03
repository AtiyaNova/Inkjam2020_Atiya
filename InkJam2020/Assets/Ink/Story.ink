EXTERNAL SetCharacter(active)
EXTERNAL ChangeScenery(index)
EXTERNAL CalculateEndering()

Recently, I’ve been hired to test out an experimental app called “Witch Helpers” before its release. The whole purpose of this app is to allow the user to summon a witch of their choosing in their time of need. 

I’ve been given a trial version to test out for a handful of days, and then give the developers feedback. Already I can tell that the app has some issues—it’s not very clear what kind of tasks the witches are up to. I guess I’ll have to figure that out myself… 

Day 1
    {ChangeScenery(1)}
I've been at work all day, and by the time I arrive home I realized that I had no food left. I could go out and buy groceries again... but I need to use the app. Maybe one of the witches could help...?
    {ChangeScenery(0)}

*You choose to call Diana.
{SetCharacter(true)}
    Diana arrived.
    "I'm assuming you're the only who called me, mortal" She asked. I nod my head yes. "I'm goddess of the witches or smth or another, don't waste my time."
    **"How good are your cooking skills?"
        I don't understand.
    **"I'm really hungry."
        What of it?
    --"I called you because I'm hungry and I was hoping you'd cook."
   "How dare you waste my time with such trifles?" 
   She turned on her heel and stormed off, her cat mewling after her. 
   {SetCharacter(false)}
    Your stomach growled in hunger. You decided to just order takeout.
    
*You choose chose to call Baba Yaga.
{SetCharacter(true)}
    Baga yaga arrived.
    "Hah? Who are you?"
    **How good are your cooking skills?
        "Quite good if I do say so myself."
    **I'm really hungry.
        "So am I. Perhaps I should eat you?"
    --"I called you because I'm hungry and I was hoping you'd cook."
    "Oh! That's easy. I can do that."
    {ChangeScenery(3)}
    {SetCharacter(false)}

*You choose to call Gryla.
{SetCharacter(true)}
    Gryla arrived in a huff of smoke. She wrinkled her eyes as she took in your shabby apartment. 
    "You have such meagre accomodations here," she said, strolling over to one of your chairs and making herself comfortable.
    "Now, what did you ask me to do?
    **"How good are your cooking skills?"
        She stared you in the eyes. "I beg your pardon?"
    **"I'm really hungry."
        She said nothing. She fixed you with a steely gaze so severe that you find yourself stumbling the next words. 
    --"I called you because I'm hungry and I was hoping you'd cook."
    At first she was silent. Then her wrinkled face blushed an angry red. "How dare you waste my time in such a way?" She demanded. 
    When you didn't answer, she let out a shriek of anger, and vanished herself out of your apartment. 
    {SetCharacter(false)}
    
*You choose to call Pesta.
{SetCharacter(true)}
    Pesta entered your apartment hesitantly. She looked around at your belongings with a keen curiousity.
    "I don't meet mortals too often," she admitted, giving you a small smile. "Why have you summoned me?"
    **"How good are your cooking skills?"
        She looked startled. "Oh! My cooking skills? Not great, I'll admit."
    **"I'm really hungry."
        "Oh dear, you are? Do you happen to have any food...?"
    --"I called you because I'm hungry and I was hoping you'd cook."
    She paused. For a second she looked like she was going to say no, then she hung her head in defeat.
    "I'll give it a try," she said.
    You lead her to your tiny kitchen. She squeezed in and curiously looked at your cooking utensils.
    "I wonder if this is anything like brewing potions."
    You're not even sure what she did, or how it happened, but eventually all your kitchen utensils start melting. 
    Pesta is sobbing hysterically. "I'm sorry, I'm so sorry, I don't even know how I'm doing this..."
    She tried to grab a frying pan, and shrieked when the handle melted in her palm. 
    You quickly intervene. "It's all right, I don't mind," you soothe, though in reality you were grimacing while thinking about the astronomical repair costs. 
    The night ends with you sending a teary Pesta off with kind assurances, regretting having called her in the first place.
    {ChangeScenery(2)}
    {SetCharacter(false)}

-The next day. 

Day 2

While going out on a walk, you notice signs up for missing cats.
You have a soft spot for cats, and feel bad that these animals have been separated from their owners.
You realize that this could be a good opportunity to summon a witch. Perhaps one of them would be able to help find the cats...?

*You choose to call Diana.
{SetCharacter(true)}
    Diana strolled up to you impatiently. "What do you want." she asked. Her cat flicked its tail.
    **Do you like cats?
        She scoffed in indignation. "What do you think?"
    **A lot of cats have been going missing. 
        Her eyes glazed over. She looked sadly over at some of the missing posters. "Yes, it seems like they have."
    --"I called you here because I was hoping you could help find the missing cats, and return them to their owner."
    She looked stunned. Then her face flushed. "Well. I suppose if it's to find innocent cats, I could spare my time."
    {SetCharacter(false)}
    She snapped her fingers and disappeared. You wait a couple of minutes to see if she would return, and then go about your day.
    That night you receive a text on your phone. It turns out that she had found all the cats, and returned them to their rightful home.
    
*You choose to call Baba Yaga.
    At first there was nothing. Then the ground began shading. Baga Yaga showed up in her giant house, fitted with chicken legs and all. 
    {SetCharacter(true)}
    She gave you a grunt.
    **Do you like cats?
        She tapped her chin. "They're too chewy for me lately."
    **A lot of cats have been going missing. 
        "Oh? I wonder if they're being eaten."
    --"I called you here because I was hoping you could help find the missing cats, and return them to their owner."
    The witched lolled her head back and forth. Finally she shrugged, "Couldn't hurt to give a try."
    {SetCharacter(false)}
    She gave a quick glance at the posters, and then climbed back into her cabin. The house reared up, and began running lopsidedly through the park.
    
    You could hear the witch hollering the names of the cats, and passerby screaming as they tried to avoid the onslaught of chicken legs.
    Grimacing, your promptly make your way home. Perhaps calling her wasn't such a good idea after all. 


*You chooseI chose to call Gryla.
{SetCharacter(true)}
    The imposing woman bore down on you the second she arrived. "What do you want?"
    **Do you like cats?
        Her face flickered with confusion. "Cats? I feel nothing one way or another."
    **A lot of cats have been going missing. 
        "Oh. I see."
    --"I called you here because I was hoping you could help find the missing cats, and return them to their owner."
    She appeared deep in thought. "I appreciate that you tried to enlist my help for... this."
    "However, it's not my responsibility." She shook her head. "I have Yule Lads to look after."
    {SetCharacter(false)}
    She promptly left without another word. 
    
*You choose to call Pesta.
{SetCharacter(true)}
    Pesta nervously hobbled over to you. As she did so, the grass near her feet slowly withered in her wake.
    She gave you a cheery wave. "Hello!"
    **Do you like cats?
        She cocked her head. "I suppose. Could never get close to them though." She shifted her feet sadly. 
    **A lot of cats have been going missing. 
        Her eyes were wide. "Oh no, that's horrible!"
    --"I called you here because I was hoping you could help find the missing cats, and return them to their owner."
        She opened and closed her mouth several times, and then grimaced. 
        "I'm sorry, I don't think that's a good idea. I think I'd melt the cats." 
        {SetCharacter(false)}
        You give a sympathetic nod. She turned around and walked back, the withered grass disintigrating with each of her steps. 

-The next day. 

Day 3

Today is your day off. You eagerly wake up and head over to your balcony garden, happy to give your plants some love and care.
To your horror, you see that the plants were horribly overgrown. 
Your balcony looked like a jungle, and some of the floor was cracked under the weight.
This isn't a situation you can handle. You have to call a witch. 

*You choose to call Diana.
{SetCharacter(true)}
    Diana looked at you suspiciously. When you let her to your garden her eyes widened.
    "Your garden is cursed! Who have you angered?"
    **"I don't know who caused this."
        She tutted under her breath. 
    **"No one has any reason to curse me."
        She gave a snort.
    --"Do you think you can fix this?"
    Diana massaged her temples. "Ugh. No, I don't think I can. I'll give it a try anyways."
    The witch began her spellwork. You didn't know what she was doing, but whatever it was involved lots of cats and dancing. 
    When she finished she looked at you with a frustrated gleam in her eyes. "It didn't work." She said flatly.
    {SetCharacter(false)}
    Before you could apologize for wasting her time, she strutted out of your apartment. 
    
*You choose to call Baba Yaga.
{SetCharacter(true)}
    The old witch looks unhappy to see you. "What?" She spat.
    You gestured towards your balcony. She hobbled towards it, and hummed as she stared at it with squinted eyes. 
     **"I don't know who caused this."
        "Neither do I," she said. 
    **"No one has any reason to curse me."
        She rolled her bony shoulders. "They wouldn't need one."
    --"Do you think you can fix this?"
    The witch rubbed her hands together. "We'll see."
    She began waving her hands wildly in the air, muttering under her breath as she did so. 
    You sat down in your couch and watched her, patiently waiting for her spell to work.
    It didn't. The old witch didn't even bother telling you as much. 
    {SetCharacter(false)}
    She just sighed, shook her head, and walked out of your apartment, leaving you gaping in disbelief.


*You choose to call Gryla.
{SetCharacter(true)}
    The witch showed up disgruntled. "There better be a reason for this disturbance, child."
    You explained your situation to her as you took her over to your balcony. She eyed the plants with distaste.
     **"I don't know who caused this."
        She sighed. "This would have been an easier problem to solve if you did."
    **"No one has any reason to curse me."
        She cocked an eyebrow. "This doesn't look like something caused out of no reason. But, perhaps, if a stray spell went awry..."
    --"Do you think you can fix this?
        She pursed her lips. "I suppose I can try."
        She put two fingers in her mouth and whistled. You heard the sound of laughter, following by objects in your apartment koncked over. 
        Gryla explained to you that her children were trying to rip apart the vines. But to no avail--everytime one was ripped off, another grew back in its place. 
        Finally she turns to you and says, "I'm sorry, I don't think it can be done."
        {SetCharacter(false)}
        You gave a curt nod, and say your goodbyes as she and her multitudes of children leave. 
        
*You choose to call Pesta.
{SetCharacter(true)}
    Pesta arrived in a hurry, her eyes wide in surprise. "What's wrong??" She asked.
    You took her to your balcony, where she assessed the damage.
     **"I don't know who caused this."
        The witch frowned and shook her head. "It may've been no one."
    **"No one has any reason to curse me."
        Pesta gave a small smile. "No, I don't think they would."
    --"Do you think you can fix this?"
        "I... I think so." Hesitantly she began working on your garden.
        She touched all the plants one by one, and they slowly rotted from the inside, and deteriorated.
        Eventually they were all gone. Pesta beamed at her handiwork. "There!"
        {SetCharacter(false)}
        "Thank you!" You said, smiling back at her. She bid adeau and left. 
    
    -The next day. 

Day 4

The next night you awoken to the sound of a large bang. Grumbling you push yourself out of your bed and head over to your living room.
In shock, you realize that everything has been flung over. Dishes were floating in the air, poised to crash any minute. 
This was definitely an emergency. You quickly whip out your phone, and get ready to call. 

*You choose to call Diana.
{SetCharacter(true)}
    Diana arrived, looking annoyed. Her cat was still deep asleep on her shoulders.
    "What is the meaning of thi--" she gave a pause when she noticed the flying objects.
     **"What's going on?!"
        Diana sucked in her breath. "Poltergeists."
    **"Do you know how to stop this?"
        Diana stuttered. "I... I'm not sure."
    --"Please help me!"
    "Okay, okay, I'll try," she said. 
    And tried she did. She summoned her cats and channeled the full power of the moon, but nothing seemed to be working.
    Eventually the poltergeist stopped smashing everything. She looked at you, wide-eyed.
    "I'm sorry, I did all I could."
    {SetCharacter(false)}
    You thanked her for her time, and bid her adeau, looking around your house with unabashed misery. 
    
    
*You choose to call Baba Yaga.
{SetCharacter(true)}
    When the old hag finally arrives, it's almost dawn.
    She looked like she was going to curse you out, but when her eyes alighted on the mess she gaped.
  **"What's going on?!"
        "Kid, I got no clue."
    **"Do you know how to stop this?"
        "How should I know?"
    --"Please help me!"
    She scratched her chin. "Have you tried making yourself a meal? That usually calms me down."
    {SetCharacter(false)}
    You let out a puff of anger and kick her out, cursing the waste of time. 

*You choose to call Gryla.
{SetCharacter(true)}
    Gryla arrives and looks around your apartment suspiciously. "What is..." she paused at the sight of the flying objects. "Oh."
    **"What's going on?!"
        "It's a poltergeist, child."
    **"Do you know how to stop this?"
        She gave a grim smile. "Luckily for you, I do."
    --"Please help me!"
    Gryla told you to return to your room. 
    As you did, you hear her talking with the poltergeist in question--they talked well past the point you fell asleep.
    When you wake up and return to your living room you see that everything has been returned to normal. 
    If it hadn't been for Gryla's text message saying that she took care of the problem, you would've thought it was a dream.
    
*You choose to call Pesta.
    Pesta nervously looked into your apartment, and gasped at the sight of the mess.
    **"What's going on?!"
        "A malignant spirit!" She said excitedly. "Oh, but I don't know what kind."
    **"Do you know how to stop this?"
        "I... I don't think so."
    --"Please help me!"
    "Well, I'll try..." She said as she rushed in. 
    It was no use. She tried fixing your problems, but instead she melted all the destroyed items.
    In your frustration, you told her to leave. She squealed and apologized, and ran out.
    {SetCharacter(false)}
    The poltergeist left when it got bored. In exhaustion, you head to your bedroom.

  -The next day. 

Ending
You tell the company your complaints with the app. Primarily that it wasn't clear at all what the witches were willing to do.

Turns out that among the testers you were one of the lucky ones. Many others have met a harsher fate by crossing the line with these witches. The company decides not to realize the app after all. In hindsight, it really doesn't seem like a good idea. 


-->END