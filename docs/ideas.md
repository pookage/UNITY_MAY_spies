# Ideas

## Summary

You play as either the spies or security; **Spies** have to hack the central terminal to steal data without being captured, and **Security** need to identify and capture the spies.

The Entire scenario happens as part of a crowded mob, within which the spies can camoflauge themselves to hide from security.

Security can stop and question anyone in the crowd in an attempt to capture a spy, but stopping an innocent bystander will increase the anxiety of the crowd; if it gets too anxious then the crowd will feel persecuted, may riot, and become hostile to security.


## Spies

Spies need to complete a number of steps before they're able to hack the central terminal :

	1. Unlock the door providing access to the mainframe
	2. Start the hack
	3. Escape with the hacked data

There are multiple ways to achieve each goal:

### Unlock the door providing acccess to the mainframe

This door can be unlocked in multiple ways :

1. It can be blown open with explosives
2. A physical override key can be pickpocketed from the security guard
3. They can sneak behind a security guard unnoticed
4. They can hack a security guard so that when they open a door it reveals the security code for the spies to use


- Explosives / ingredients for explosives need to be found before they can be made into something usable.
- As pickpocketing takes time, then it may be easy to spot any member of the crowd remaining stationary next to a security guard
- Gaining entry by sneaking-in behind a security guard may cause suspicion if anybody sees it happening
- Hacking security guard requires ???

### Start the hack

1. If the spies have physical access to the terminal (have unlocked the door), they can brute-force it directly
2. Spies can also compromise a security guard, so that whenever they check on the status of the terminal the hack progresses slightly
3. They can slowly hack it remotely from any network port

- physical access is stationary, and so if anyone sees a member of the crowd inside the terminal then they're almost definitely a spy
- hacking a security guard requires ???
- network port access is stationary, and due to the very slow progress made during this attempt it's risky for lowest reward

### Escape with the hacked data

Once the data has been retrieved then the spies need to escape the scenario with it; but must also do it whilst blending in with the crowd and not being caught by security.

## Security

In order to foil the plans of the spies, Security can implement a number of different methods :

1. Install CCTV to add line-of-sight to some areas, and if guards get too close then they're revealed as spies.
2. Patrol the area, watching for anything suspicious
3. Add security counter-measures to alert whenever something is being hacked

- CCTV requires money, which is obtained by foiling minor criminal attempts like the mob robbing ATMs
- Patrolling only gives LOS 


## Notes

- Spies that have been identified but not detained are highlighted (red?) for as long as they're actively being 'spotted', as soon as they are out of LOS then their colour slowly reverts back to the colour of the crowd, requiring them to be actively identified again.


