Feature: Req002 - DrawCards
	shuffle a deck of cards, draw one or more cards from a deck

@Sanity @regression @priority2
Scenario Outline: TC_ST_L1_DrawCards_P0001 - shuffle a deck of cards, draw one or more cards from a deck
Given user shuffle <deck_count> deck of cards with <jokers_enabled>
When user draw <count> number of cards
Then success should be <success>, cards count draw should be <count>, remaining cards count should be <remaining>
Examples: 
| deck_count | jokers_enabled | count | success | remaining |
| 1          | True           | 2     | True    | 52        |
| 1          | False          | 4     | True    | 48        |